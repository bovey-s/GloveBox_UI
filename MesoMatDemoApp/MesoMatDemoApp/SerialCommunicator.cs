using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using Ivi.Visa;
using Ivi.Visa.FormattedIO;

namespace MesoMatDemoApp
{
    public class SerialCommunicator : IDisposable
    {
        private SerialPort serialPort;
        private Queue<byte> recievedData = new Queue<byte>();
        public bool frmflg;
        private readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //GBIP connect
        public IMessageBasedSession session;
        public IMessageBasedFormattedIO formattedIO;

        public SerialCommunicator(IMessageBasedSession inLIAsession)//, IMessageBasedSession outLIAsession, IMessageBasedSession Ksession)
        {
            log4net.Config.XmlConfigurator.Configure();
            //log4net.GlobalContext.Properties["LogFileName"] = "test_log.log"; OLD
            frmflg = true;
            //serialPort = new SerialPort(port, baud_rate);
            //serialPort.RtsEnable = true;
            //serialPort.DataReceived += DataReceived;
            // checks serial port connection, returns error on no connection
            try
            {
                formattedIO = new MessageBasedFormattedIO(inLIAsession);

                //session.TerminationCharacterEnabled = true;

                formattedIO.WriteLine("*IDN?");
                Console.WriteLine(formattedIO.ReadLine());
                //session.LockResource();
            }
            catch (NativeVisaException visaException)
            {
                Console.WriteLine("couldn't connect", visaException);
            }
        }

        public void DataReceived(object sender, EventArgs e)
        {

        }

      

        public double[] LIAprobe(string cmd1, string cmd2)
        {
            double[] output = { 0, 0 };
            //formattedIO.SkipUntilEnd();
            formattedIO.WriteLine(cmd1);
            Thread.Sleep(25);
            Console.WriteLine("check");
            //Console.WriteLine(formattedIO.ReadLine());
            output[0] = Convert.ToDouble(formattedIO.ReadLine());
            Thread.Sleep(25);
            Console.WriteLine(output[0]);
            Thread.Sleep(25);
            formattedIO.WriteLine(cmd2);
            output[1] = Convert.ToDouble(formattedIO.ReadLine());

            //add other LIA and Keithley as you set them up
            return output;
        }

        public double[] KeithProbe(string cmd1, string cmd2, bool on, bool OK)
        {
            double[] output = { 0.00069, 0 };
            formattedIO.DiscardBuffers();
            
            if (on && OK)
            {
                formattedIO.WriteLine(cmd1);
                Thread.Sleep(10);
                //Console.WriteLine(formattedIO.ReadLine());
                output[0] = Convert.ToDouble(formattedIO.ReadLine());
                Console.WriteLine(output[0]);
                Thread.Sleep(10);
                formattedIO.WriteLine(cmd2);
                output[1] = Convert.ToDouble(formattedIO.ReadLine());
            }

            if (output[0] == 0)
            {
                output[0] = 0.00069;
            }

            return output;
        }

        


        //Sends arduino empty input, outputs the output values of resistance in a floating point array
        public double[] SendCommand(string cmd, int expected_bytes, int delay_time)
        {
            log.Info("sending command");
            int errorNum = 0;
            double[] output = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //ADD
            bool tryAgain = true;
            while (tryAgain == true)
            {
                Thread.Sleep(delay_time);  //works here only (this input delays to the nearest six seconds, i do not know why)
                try
                {
                    log.Info("resetting input buffer");
                    serialPort.DiscardInBuffer();
                    //writes command
                    log.Info(string.Format("sending command: {0}", cmd));
                    serialPort.Write(cmd);
                    //writes new line character
                    serialPort.Write(new byte[] { 10 }, 0, 1);
                    long startTime = DateTime.Now.Ticks;
                    int pingNumber = 0;
                    while (serialPort.BytesToRead < expected_bytes)
                    {
                        
                        if (DateTime.Now.Ticks - startTime > 6e7)
                        {
                            // checks for response from Arduino, exits on unexpected delay
                            pingNumber += 1;
                            log.Error("No immediate response, pinging again");
                            serialPort.DiscardInBuffer();
                            Console.WriteLine("ping again");
                            serialPort.Write(cmd);
                            serialPort.Write(new byte[] { 10 }, 0, 1);
                            startTime = DateTime.Now.Ticks;
                            if (pingNumber > 10){
                                try
                                {
                                    Dialog Errormsg = new Dialog("The hardware is not responding as expected, the selected COM port may not correspond to a MesoMat DAQ.", "Error", false); ;
                                    Errormsg.ShowDialog();
                                }
                                catch
                                {

                                }
                                Environment.Exit(-1);
                            }
                        }
                        Thread.Sleep(1);
                    }
                    string line = serialPort.ReadLine();
                    log.Info(string.Format("the recieved command was: {0}", line));
                    string[] parts = line.Split(',');
                    for (int i = 0; i < 30; i++) //ADD
                    {
                        parts[i] = parts[i].Trim();
                    }
                    //List<string> parts = line.Split(',').Select(p => p.Trim()).ToList();
                    foreach (string index in parts)
                    {
                        log.Info(index);
                    }
                    for (int i = 0; i < 30; i++) //ADD
                    {
                        log.Info(string.Format("looking at {0}",parts[i]));
                        output[i] = float.Parse(parts[i]);
                        log.Info(string.Format("Channel {0} was determined to be {1}, output is {2}", i, parts[i],output[i]));
                        //Console.WriteLine(output[i]);
                    }
                    tryAgain = false;
                    log.Info("the tryAgain flag was successfully set to false");
                }
                catch
                {
                    errorNum += 1;
                    log.Error(String.Format("A communication error occured, error number {0}", errorNum));
                    Console.WriteLine(String.Format("Com error number {0}", errorNum));
                   
                    if (errorNum >= 12)
                    {
                        log.Error("Too many unexpected transmissions, shutting down... ");
                        try
                        {
                            Dialog Errormsg = new Dialog("The hardware was disconnected.", "Error", false); ;
                            Errormsg.ShowDialog();
                        }
                        catch
                        {

                        }
                        Environment.Exit(-1);
                    }
                }
            }
            return output;
        }


        public void Dispose()
        {
            frmflg = false;
            if (serialPort != null)
            {
                serialPort.Dispose();
            }
            
            Environment.Exit(0);

        }
    }
}
