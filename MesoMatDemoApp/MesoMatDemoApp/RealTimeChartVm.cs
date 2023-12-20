using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Threading;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Geared;
using LiveCharts.WinForms;
using Ivi.Visa;
using Ivi.Visa.FormattedIO;
using static System.Collections.Specialized.BitVector32;

namespace MesoMatDemoApp
{
    public class RealTimeChartVm
    {
        private double _sensor;
        public double Rate_Threshold;
        public double Amplitude_Threshold;
        public double _k1_strain;
        public double _k2_strain;
        public double _k3_strain;
        public double _k4_strain;
        public bool _flag;
        public bool _changing_channel;
        public bool _isReady;
        public double _floor;
        private SerialCommunicator port1;
        private SerialCommunicator port2;
        private SerialCommunicator portK;
        private int keepRecords;
        private Action readFromThread;
        private bool stop, record;

        //variables for LCD light ring
        public bool update_sens;
        public double sens;

        static AutoResetEvent event1 = new AutoResetEvent(false);
        public static readonly object _locker = new object();
        public static ReaderWriterLock rwl = new ReaderWriterLock();

        //GBIP connect
        public IMessageBasedSession sessionLIA1;
        public IMessageBasedFormattedIO formattedIO1;

        public IMessageBasedSession sessionLIA2;
        public IMessageBasedFormattedIO formattedIO2;

        public IMessageBasedSession sessionKeith;
        public IMessageBasedFormattedIO formattedIOK;

        public bool KeithOn;
        public bool FourWire;
        public int keepRecs = 150;
        public bool OK = false;
        public int current = 0;

        public class DateModel
        {
            public System.DateTime DateTime { get; set; }
            public double Value { get; set; }
        }

 

        public RealTimeChartVm(int GPIB1, int GPIB2, int GPIBK)
        {
            //generate GPIB connection string
            string connectstr1 = "GPIB::"+Convert.ToString(GPIB1)+"::INSTR";
            string connectstr2 = "GPIB::" + Convert.ToString(GPIB2) + "::INSTR";
            string connectstrK = "GPIB::" + Convert.ToString(GPIBK) + "::INSTR";
            //now open a session for 1 instrument
            //Lockin 1 open
            try
            {
                sessionLIA1 = GlobalResourceManager.Open(connectstr1) as IMessageBasedSession;
                Console.WriteLine("connected");
                formattedIO1 = new MessageBasedFormattedIO(sessionLIA1);

                //session.TerminationCharacterEnabled = true;

                //formattedIO1.WriteLine("FREQ 1.40");
                formattedIO1.WriteLine("*IDN?");
                Console.WriteLine(formattedIO1.ReadLine());
            }
            catch (NativeVisaException visaException)
            {
                Console.WriteLine("couldn't connect", visaException);
            }
            //Lockin 2 open
            try
            {
                sessionLIA2 = GlobalResourceManager.Open(connectstr2) as IMessageBasedSession;
                Console.WriteLine("connected");
                formattedIO2 = new MessageBasedFormattedIO(sessionLIA2);

                //session.TerminationCharacterEnabled = true;

                //formattedIO1.WriteLine("FREQ 1.40");
                formattedIO2.WriteLine("*IDN?");
                Console.WriteLine(formattedIO2.ReadLine());
            }
            catch (NativeVisaException visaException)
            {
                Console.WriteLine("couldn't connect", visaException);
            }
            //Keith open
            try
            {
                sessionKeith = GlobalResourceManager.Open(connectstrK) as IMessageBasedSession;
                Console.WriteLine("connected");
                formattedIOK = new MessageBasedFormattedIO(sessionKeith);

                //session.TerminationCharacterEnabled = true;

                formattedIOK.WriteLine("*IDN?");
                Console.WriteLine(formattedIOK.ReadLine());
                KeithOn = false;
                FourWire = false;
                //formattedIOK.WriteLine("SOUR:CURR 0.00001");
            }
            catch (NativeVisaException visaException)
            {
                Console.WriteLine("couldn't connect", visaException);
            }


            //old stuff
            //values holds the data displayed in the chart
            Values = new GearedValues<DateModel>().WithQuality(Quality.Highest);
            ResValues = new GearedValues<DateModel>().WithQuality(Quality.Highest);
            //data holds the raw resistance values from the arduino; used for signal processing
            DataMatrix = new List<double[]>();
            TimeMatrix = new List<DateTime>();
            ChannelIndex = new int();
            Data = new List<double>();
            ChannelIndex = 2; //HERE MELIS
            _changing_channel = false;
            Outputs = new List<double>();
            TempCalEnabled = false;
            StrainCalEnabled = true;
            Enabled = true;
            _k1_strain = 0;
            _k2_strain = 0;
            _k3_strain = 0;
            _k4_strain = 0;
            _floor = -88;
            update_sens = false;
            // for shm sample (low GF)
            Rate_Threshold = (double) 0.02;
            Amplitude_Threshold = (double) 0.02;
            this._flag = false;

            /* for sensing tape sample:
            Rate_Threshold = 6;
            Amplitude_Threshold = 10;*/

            _isReady = false;
            

        }

        public bool IsReading { get; set; }
        public int delay_time { get; set; }
        public GearedValues<DateModel> Values { get; set; }
        public List<double[]> DataMatrix { get; set; }
        public List<DateTime> TimeMatrix { get; set; }
        public int ChannelIndex { get; set; }
        public GearedValues<DateModel> ResValues { get; set; }
        public List<double> Data { get; set; }
        public List<double> Outputs { get; set; }
        public bool TempCalEnabled { get; set; }
        public bool StrainCalEnabled { get; set; }
        public bool Enabled { get; set; }
        public string RecordPath { get; private set; }
        public DateTime StartTime { get; private set; }

        public void Close()
        {
            stop = true;
            port1.Dispose();
            sessionLIA1.Dispose();
            port2.Dispose();
            sessionLIA2.Dispose();
            portK.Dispose();
            sessionKeith.Dispose();
            Environment.Exit(-1);
        }

        public void Clear()
        {
            Values.Clear();
            ResValues.Clear();
            Data.Clear();
            
            for (int i = 0; i < keepRecords; i++)
            {
                //Values.Add(new DateModel { DateTime = System.DateTime.Now - TimeSpan.FromSeconds((keepRecords - i) * 120 / 1000.0), Value = GetOutput() });
                ResValues.Add(new DateModel { DateTime = System.DateTime.Now - TimeSpan.FromSeconds((keepRecords - i) * 120 / 1000.0), Value = _sensor });
                Data.Add(_sensor);
            }
        }

        public void Start()
        {
            stop = false;
            Task.Factory.StartNew(readFromThread);
        }


        public double GetOutput()
        {
            //if strain rate is boave threshold then show resistance
            double StrainRate = CalcStrainRate();
            double x = this._sensor;
            if (this._floor == -88)
                this._floor = x;
            Console.WriteLine(StrainRate);
            Console.WriteLine(x - this._floor);
            Console.WriteLine(StrainRate < Rate_Threshold);
            Console.WriteLine((x - this._floor) < Amplitude_Threshold);

            if ( (StrainRate < Rate_Threshold && (x - this._floor) < Amplitude_Threshold) || ((x - this._floor) < 0) || this._flag)
            {
                this._flag = false;
                this._floor = x;
                Console.WriteLine("No Signal");
                return 0;
                
            } 
            else 
            {
                Console.WriteLine("Signal Detected!");
                //return (StrainCalEnabled ? (_k1_strain * (x - this._floor)) : x - this._floor);
                double x2 = (x - this._floor);
                return (StrainCalEnabled ? (_k1_strain * x2 + _k2_strain * x2 *x2 + _k3_strain * x2*x2*x2 + _k4_strain * x2*x2*x2*x2 ): x2);
                //return StrainCalEnabled ? (_k_strain * (x - this._floor) ) : x - this._floor;
            }

            

        }

        public double CalcStrainRate()
        {
            //uses linear regression to estimate strain rate
            int points_considered = Math.Min(10, Data.Count());
            double avgX = 0;
            double avgY = 0;
            int endindex = Data.Count() - 1; 
            

            DateTime refTime = System.DateTime.Now;
            refTime.AddHours(1);

            for (int i = 0; i < points_considered; i++)
            {
                avgY += Data[endindex - i];
                avgX += refTime.Ticks - ((DateModel)Values[endindex - i]).DateTime.Ticks;
            }

            avgX /= points_considered;
            avgY /= points_considered;

            double covariance = 0;
            double variance = 0;

            for (int i = 0; i < points_considered; i++)
            {
                double xpoint = refTime.Ticks - ((DateModel)Values[endindex - i]).DateTime.Ticks;
                double ypoint = Data[endindex - i];
                covariance += (ypoint - avgY) * (xpoint - avgX);
                variance += (xpoint - avgX) * (xpoint - avgX);
            }
            return Math.Abs((double)1e7*covariance / variance);

        }


        public void StartRecording(string filepath, DateTime startTime)
        {

            record = true;
            RecordPath = filepath;
            StartTime = startTime;

        }

        public void StopRecording()
        {
            record = false;
        }
        public void ChangeChannel(int Channel)
        {
            if (_changing_channel == false)
            {
                _changing_channel = true;

                ChannelIndex = Channel;
                //Values.Clear();
                ResValues.Clear();
                Data.Clear();

                rwl.AcquireReaderLock(500);
                
                int IndexNum = Math.Min(keepRecords, DataMatrix.Count());

                for (int i = 0; i < IndexNum; i++)
                {
                    //Values.Add(new DateModel { DateTime = TimeMatrix[i], Value = GetOutput() });

                    ResValues.Add(new DateModel { DateTime = TimeMatrix[i], Value = DataMatrix[i][ChannelIndex] });
                    Data.Add(DataMatrix[i][ChannelIndex]);
                }
                rwl.ReleaseReaderLock();
                
                
                _changing_channel = false;
            }
            
        }

        public void Read(string comPort, int keepRecords, int sampleRate, double k1_strain, double k2_strain, double k3_strain, double k4_strain)
        {
            this._k1_strain = k1_strain;
            this._k2_strain = k2_strain;
            this._k3_strain = k3_strain;
            this._k4_strain = k4_strain;

            this.keepRecords = keepRecords;
            port1 = new SerialCommunicator(sessionLIA1); //output LIA
            port2 = new SerialCommunicator(sessionLIA2); //reading LIA
            portK = new SerialCommunicator(sessionKeith); //Keithley

            double[] incomingtot = { 0, 0, 0, 0, 0, 0 };

            double[] incoming1 = { 0, 0 };
            double[] incoming2 = { 0, 0 };
            double[] incomingK = { 0, 0 };

            //byte[] data = port.SendCommand(new byte[] { 48 }, 4);
            //_sensor = BitConverter.ToSingle(data, 0);
            Console.WriteLine("sending first command");
            /*double[] incoming = port.SendCommand("0", 1, delay_time);
            Console.WriteLine(incoming);
            if (incoming[ChannelIndex] != 0)
            {
                TimeMatrix.Add(System.DateTime.Now - TimeSpan.FromSeconds(sampleRate / 1000.0));
                DataMatrix.Add(incoming);
                _sensor = incoming[ChannelIndex];
            }*/
            Console.WriteLine("starting new thread");
            /*
            for (int i = 0; i < keepRecords; i++)
            {
                Values.Add(new DateModel { DateTime = System.DateTime.Now - TimeSpan.FromSeconds((keepRecords - i) * sampleRate / 1000.0), Value =  GetOutput() });
                ResValues.Add(new DateModel { DateTime = System.DateTime.Now - TimeSpan.FromSeconds((keepRecords - i) * sampleRate / 1000.0), Value = _sensor });
                Data.Add(_sensor);
            }*/

            readFromThread = () =>
            {
                while (!stop)
                {
                    Thread.Sleep(100);
                    formattedIO1.DiscardBuffers();
                    incoming1 = port1.LIAprobe("OUTP? 3", "OUTP? 4");
                    formattedIO2.DiscardBuffers(); 
                    incoming2 = port2.LIAprobe("OUTP? 3", "OUTP? 4");
                    formattedIOK.DiscardBuffers();
                    incomingK = portK.KeithProbe("SOUR:CURR?", "MEAS:VOLT?", KeithOn, OK);

                    incomingtot[0] = incoming1[0];
                    incomingtot[1] = incoming1[1];
                    incomingtot[2] = incoming2[0];
                    incomingtot[3] = incoming2[1];
                    //incomingtot[4] = (double)current;
                    incomingtot[4] = incomingK[0];
                    incomingtot[5] = incomingK[1];
                    
                    

                    _sensor = incomingtot[0];
                    Thread.Sleep(100);
                    //Console.WriteLine(DataMatrix.Count());
                    //incoming = port.SendCommand("0", 4, delay_time);
                    if (incomingtot[0] != 0)
                    {
                        _isReady = true;
                        _sensor = incomingtot[ChannelIndex];
                    }
                    if (record && RecordPath != null && File.Exists(RecordPath) && _changing_channel == false)
                    {
                        using (StreamWriter writer = File.AppendText(RecordPath))
                        {
                            //writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6}",
                            //    (System.DateTime.Now - StartTime).TotalSeconds,
                            //    Decimal.Round((decimal)incomingtot[0], 4),
                            //    Decimal.Round((decimal)incomingtot[1], 4),
                            //    Decimal.Round(1000000*(decimal)incomingtot[2], 4),
                            //    Decimal.Round((decimal)incomingtot[3], 4),
                            //    Decimal.Round((decimal)current, 4),
                            //    Decimal.Round((decimal)incomingtot[5], 4)));
                            //writer.Close();
                            if (KeithOn)
                            {
                                writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                                    (System.DateTime.Now - StartTime).TotalSeconds,
                                    Decimal.Round((decimal)incomingtot[0], 4),
                                    Decimal.Round((decimal)incomingtot[1], 4),
                                    Decimal.Round(1000000 * (decimal)incomingtot[2], 4),
                                    Decimal.Round((decimal)incomingtot[3], 4),
                                    //Decimal.Round((decimal)current, 4),
                                    Decimal.Round(1000000 * (decimal)incomingtot[4], 4),
                                    Decimal.Round((decimal)incomingtot[5], 4),
                                    Decimal.Round((decimal)(incomingtot[5]/incomingtot[4]/1000), 4)));
                                writer.Close();
                            }
                            else
                            {
                                writer.WriteLine(String.Format("{0},{1},{2},{3},{4}",
                                    (System.DateTime.Now - StartTime).TotalSeconds,
                                    Decimal.Round((decimal)incomingtot[0], 4),
                                    Decimal.Round((decimal)incomingtot[1], 4),
                                    Decimal.Round(1000000 * (decimal)incomingtot[2], 4),
                                    Decimal.Round((decimal)incomingtot[3], 4),4)+",Nan,NaN,Nan");
                                writer.Close();
                            }
                            
                        }
                    }
                    /*
                    if (record && RecordPath != null && File.Exists(RecordPath) && _changing_channel == false)
                    {
                        using (StreamWriter writer = File.AppendText(RecordPath))
                        {//ADD (also why 20 above but 19 below?)
                            writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28},{29},{30}",
                                (System.DateTime.Now - StartTime).TotalSeconds,
                                Decimal.Round((decimal)incoming[0], 4),
                                Decimal.Round((decimal)incoming[1], 4),
                                Decimal.Round((decimal)incoming[2], 4),
                                Decimal.Round((decimal)incoming[3], 4),
                                Decimal.Round((decimal)incoming[4], 4),
                                Decimal.Round((decimal)incoming[5], 4),
                                Decimal.Round((decimal)incoming[6], 4),
                                Decimal.Round((decimal)incoming[7], 4),
                                Decimal.Round((decimal)incoming[8], 4),
                                Decimal.Round((decimal)incoming[9], 4),
                                Decimal.Round((decimal)incoming[10], 4),
                                Decimal.Round((decimal)incoming[11], 4),
                                Decimal.Round((decimal)incoming[12], 4),
                                Decimal.Round((decimal)incoming[13], 4),
                                Decimal.Round((decimal)incoming[14], 4),
                                Decimal.Round((decimal)incoming[15], 4),
                                Decimal.Round((decimal)incoming[16], 4),
                                Decimal.Round((decimal)incoming[17], 4),
                                Decimal.Round((decimal)incoming[18], 4),
                                Decimal.Round((decimal)incoming[19], 4),
                                Decimal.Round((decimal)incoming[20], 4),
                                Decimal.Round((decimal)incoming[21], 4),
                                Decimal.Round((decimal)incoming[22], 4),
                                Decimal.Round((decimal)incoming[23], 4),
                                Decimal.Round((decimal)incoming[24], 4),
                                Decimal.Round((decimal)incoming[25], 4),
                                Decimal.Round((decimal)incoming[26], 4),
                                Decimal.Round((decimal)incoming[27], 4),
                                Decimal.Round((decimal)incoming[28], 4),
                                Decimal.Round((decimal)incoming[29], 4)));
                            //Thread.Sleep(3000);
                            writer.Close();
                        }
                    }*/


                    if (Enabled && _changing_channel == false)
                    {
                        IsReading = true;
                        

                        if (ResValues.Count < keepRecs)
                        {
                            TimeMatrix.Add(System.DateTime.Now - TimeSpan.FromSeconds(sampleRate / 1000.0));
                            rwl.AcquireWriterLock(250);
                            DataMatrix.Add(incomingtot);
                            rwl.ReleaseWriterLock();
                            //Values.Add(new DateModel { DateTime = System.DateTime.Now - TimeSpan.FromSeconds(sampleRate / 1000.0), Value = GetOutput() } );
                            ResValues.Add(new DateModel { DateTime = System.DateTime.Now - TimeSpan.FromSeconds(sampleRate / 1000.0), Value = _sensor });
                            Data.Add(_sensor);
                        }
                        if (ResValues.Count > keepRecs - 1)
                        {
                            TimeMatrix.Remove(TimeMatrix.FirstOrDefault());
                            rwl.AcquireWriterLock(250);
                            DataMatrix.Remove(DataMatrix.FirstOrDefault());
                            rwl.ReleaseWriterLock();
                            //Values.Remove(Values.FirstOrDefault());
                            ResValues.Remove(ResValues.FirstOrDefault());
                            Data.RemoveAt(0);
                        }
                        IsReading = false;
                    }

                }
            };

            Start();
        }


        //new functions!!

        public double[] Getdata(int N, int j)
        {
            double[] output = { };
            rwl.AcquireReaderLock(250);
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(DataMatrix.Count);
                Console.WriteLine(DataMatrix.Count - (i - N));
                Console.WriteLine(DataMatrix[DataMatrix.Count - (N - i)][j] + "!!!");
                output.Append(DataMatrix[DataMatrix.Count-(N-i)][j]);
            }
            rwl.ReleaseReaderLock();
            Console.WriteLine(output.Length);
            return output;
        }

        public void SetV1(decimal V)
        {
            formattedIO1.WriteLine("SLVL " + V);
        }

        public void SetV2(decimal V)
        {
            formattedIO2.WriteLine("SLVL " + V);
        }

        public void SetF1(decimal F)
        {
            formattedIO1.WriteLine("FREQ " + F);
        }

        public void SetF2(decimal F)
        {
            formattedIO2.WriteLine("FREQ " + F);
        }

        public void KeithOnOff(bool on, decimal curr)
        {
            if (!on) 
            { 
                decimal newcurr = curr / 1000000;
                //setCurr(newcurr);
                Thread.Sleep(10); //allow setting before turning on
                formattedIOK.WriteLine("OUTP ON");
            }
            else { formattedIOK.WriteLine("OUTP OFF"); }

        }

        public void changeSens1(int i)
        {
            if (i < 0 || i > 26) { return; }
            else
            {
                formattedIO1.WriteLine("SENS " + i);
            }
        }

        public void changeSens2(int i)
        {
            if (i < 0 || i > 26) { return; }
            else
            {
                formattedIO2.WriteLine("SENS " + i);
            }
        }

        public void setCurr(decimal curr)
        {
            decimal roundedcurr = decimal.Round(curr,9);
            string currstring = Convert.ToString(roundedcurr);
            formattedIOK.WriteLine("SOUR:CURR " + currstring);
        }

        public bool FourWireMode()
        {
            if (!FourWire)
            {
                formattedIOK.WriteLine("CURR:RSEN ON");
                FourWire = true;
                return true;
            }
            else if (FourWire)
            {
                formattedIOK.WriteLine("CURR:RSEN OFF");
                FourWire = false;
                return false;
            }
            else return false;
        }

        public void setVlim(string vlimstring)
        {
            formattedIOK.WriteLine("SOUR:CURR:VLIM " + vlimstring);
        }

    }

}
