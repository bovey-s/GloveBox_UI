using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Numerics;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Defaults;
using LiveCharts.Events;
using LiveCharts.Geared;
using LiveCharts.Wpf;
using MesoMatDemoApp.Properties;
using Ivi.Visa;
using Ivi.Visa.FormattedIO;
using static MesoMatDemoApp.RealTimeChartVm;
using System.Threading;
using System.Windows.Markup;

namespace MesoMatDemoApp
{ 
    public partial class MainWindow : Form
    {
        private delegate void SafeCallDelegate();

        private string comPort;
        static public RealTimeChartVm _viewModel;
        System.Windows.Forms.Timer _timer, strainCalTimer, dataRecordTimer;
        private int strainMode = 0;
        private double[] cal_vals_0, cal_vals_1;
        private double[]  sensors;
        private string filePath, dataFilePath;
        private bool isRecording;

        private DateTime recordingStartTime;
        private int time_s;
        private int time_m;
        private int time_h;
        private int total_time;
        private int keepRecords = 150;
        const int sampleRate = 1; // seconds
        private bool keepalldata = false;
        private int datacount = 0;
        public bool VFavg = false;
        public double VFmag = 0;
        public double VFphase = 0;

        private decimal currentSet = 100;

        //LIA definitions
        private string[] str521 = { "5", "2", "1" };
        private string[] str10s = { "x100", "x10", "x1" };
        private string[] strunits = { "V", "mV", "uV", "nV" };
      

        public MainWindow(string port, int inLIA, int outLIA, int Keith)
        {
            _viewModel = new RealTimeChartVm(outLIA, inLIA, Keith);

            InitializeComponent();
            Console.WriteLine("main window started");
            this.comPort = port;
            var dayConfig = Mappers.Xy<DateModel>()
                    .X(dayModel => (double)dayModel.DateTime.Ticks / TimeSpan.FromSeconds(1).Ticks)
                    .Y(dayModel => dayModel.Value);
            

            cartesianChart2.DisableAnimations = true;
            cartesianChart2.Zoom = ZoomingOptions.None;
            cartesianChart2.DataTooltip = null;
            cartesianChart2.Background = Brushes.White;
            cartesianChart2.BorderBrush = Brushes.Black;
            cartesianChart2.BorderThickness = new Thickness(1);
            cartesianChart2.AxisX.Add(new Axis
            {
                LabelFormatter = value => new System.DateTime((long)(value * TimeSpan.FromSeconds(1).Ticks)).ToString("hh:mm:ss"),
                Title = "Time",
                FontSize = 14,
                Foreground = Brushes.Black,
                BarUnit = 50000

            }) ;
            cartesianChart2.AxisY.Add(new Axis
            {
                LabelFormatter = value => String.Format("{0:F4}", 1000*value),
                Title = "Voltage (mV)",//Ω
                FontSize = 14,
                Foreground = Brushes.Black
            });
            cartesianChart2.Series.Add(new GLineSeries(dayConfig)
            {
                Values = _viewModel.ResValues,
                Fill = Brushes.Transparent,
                PointGeometry = null,
                Foreground = Brushes.Black,
                ToolTip = false,
                Title = "Voltage (V)"
            });


            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1;
            _timer.Tick += new EventHandler(this.UpdateReadout);
            _timer.Start();

            _viewModel._k1_strain = 1;
            _viewModel._k2_strain = 0;
            _viewModel._k3_strain = 0;
            _viewModel._k4_strain = 0;

            Console.WriteLine(string.Format("starting main window on port {0}", port));
            //_k = (float)Properties.Settings.Default["k"];
            _viewModel.Read(comPort, keepRecords, (int) sampleRate, _viewModel._k1_strain, _viewModel._k2_strain, _viewModel._k3_strain, _viewModel._k4_strain);
            Console.WriteLine("done");
        }

        public void UpdateReadout(object sender, EventArgs e)
        {   //updates the readout text box as well as resistance ring
            while (_viewModel.IsReading) { } // ???
            double threshold = 20000;
            try
            {
                
                if (_viewModel._isReady && !_viewModel.IsReading)
                {
                    //Console.WriteLine("mainwindow lock");
                    time_h = int.Parse(SampleHours.Text);
                    time_m = int.Parse(SampleMinutes.Text);
                    time_s = int.Parse(SampleSeconds.Text);
                    total_time = time_h * 3600 + time_m * 60 + time_s;
                    if (total_time > 6)
                    {
                        total_time = total_time - 6;
                    }
                    else
                    {
                        total_time = 0;
                    }
                    _viewModel.delay_time = total_time * 1000;


                    rwl.AcquireReaderLock(500); 

                    int index = _viewModel.DataMatrix.Count() - 1;
                    //output LIA info
                    try { outLIArBox.Text = _viewModel.DataMatrix[index][0].ToString(); }
                    catch { outLIArBox.Text = "error"; }
                    try { outLIAthetaBox.Text = _viewModel.DataMatrix[index][1].ToString(); }
                    catch { outLIAthetaBox.Text = "error"; }
                    //measure LIA info
                    try { inLIArBox.Text = _viewModel.DataMatrix[index][2].ToString(); }
                    catch { inLIArBox.Text = "error"; }
                    try { inLIAthetaBox.Text = _viewModel.DataMatrix[index][3].ToString(); }
                    catch { inLIAthetaBox.Text = "error"; }
                    //Keith info
                    if (_viewModel.KeithOn)
                    {
                        try { KcurrentBox.Text = _viewModel.DataMatrix[index][4].ToString(); } //current measurement, not output though: CHANGE
                        catch { KcurrentBox.Text = "error"; }
                        try { KrBox.Text = _viewModel.DataMatrix[index][5].ToString(); }//needs to be R, change in viewmodel
                        catch { KrBox.Text = "error"; }
                    }
                    else
                    {
                        KcurrentBox.Text = "NaN";
                        KrBox.Text = "NaN";
                    }
                    

                    rwl.ReleaseReaderLock();

                    /*DataBox1_1.Text = _viewModel.DataMatrix[index][0].ToString();
                    if (_viewModel.DataMatrix[index][0] < threshold)
                        Ind1_1.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                    else
                        Ind1_1.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);*/
                }
            

            }
            catch
            {
                Console.WriteLine("there was a null error updating channels");
            }


        }


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\calibrations";
            fileDialog.Filter = "CAL Files (*.cal) | *.cal";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadCalibration(fileDialog.FileName, fileDialog.SafeFileName,true);
            }
        }

        private void MainWindow_FormClosing(object sender, EventArgs e)
        {

            _viewModel.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            dataFileNameLabel_Click(sender, e);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }


        static public void ChangeRateThreshold(float value)
        {
            _viewModel.Rate_Threshold = value;
            _viewModel.sens = value* 100.0f;// 600.0f;
            _viewModel.update_sens = true;
        }

        private void saveCalibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog fileDialog = new SaveFileDialog();
            //fileDialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\calibrations";
            fileDialog.Filter = "CAL Files (*.cal) | *.cal";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                dataFilePath = fileDialog.FileName;
                SaveCalibration(fileDialog.FileName, Path.GetFileName(dataFilePath));
            }

        }

        private void SaveCalibration(string path, string filename)
        {



            using (StreamWriter writer = new StreamWriter(path))
            {
                /*
                writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5}", _viewModel._k1_strain, _viewModel._k2_strain, _viewModel._k3_strain, _viewModel._k4_strain, _viewModel.Rate_Threshold,_viewModel.Amplitude_Threshold));
                Console.WriteLine(String.Format("Saved calibration values: {0},{1},{2},{3},{4},{5}", _viewModel._k1_strain, _viewModel._k2_strain, _viewModel._k3_strain, _viewModel._k4_strain, _viewModel.Rate_Threshold, _viewModel.Amplitude_Threshold));
                */
                writer.WriteLine(String.Format("{0},{1},{2}", _viewModel._k1_strain, _viewModel.Rate_Threshold, _viewModel.Amplitude_Threshold));
                Console.WriteLine(String.Format("Saved calibration values: {0},{1},{2}", _viewModel._k1_strain, _viewModel.Rate_Threshold, _viewModel.Amplitude_Threshold));


            }

            Properties.Settings.Default["loadedFilePath"] = path;
            Properties.Settings.Default["loadedFileName"] = filename;
            Properties.Settings.Default.Save();

        }

        private void viewCalibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void startRecordingButton_Click(object sender, EventArgs e)
        {

            if (!isRecording)
            {
                SaveFileDialog recordingFileDialog = new SaveFileDialog();
                //saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\data";
                recordingFileDialog.Filter = "CSV Files (*.csv) | *.csv";
                keepalldata = true;
                datacount = 0;

                if (recordingFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dataFilePath = recordingFileDialog.FileName;
                    dataFileNameLabel.Text = Path.GetFileName(dataFilePath);
                    if (File.Exists(dataFilePath))
                    {
                        Dialog warningDialog = new Dialog(String.Format("The file '{0}' already exists.\nAre you sure you want to overwrite it?", Path.GetFileName(dataFilePath)), "Warning", true);
                        warningDialog.ShowDialog();
                        if (!warningDialog.GetStatus()) return;
                    }
                }

                if (dataFilePath == null)
                {
                    Dialog errorDialog = new Dialog("You have not created a file.", "Error", false);
                    errorDialog.ShowDialog();
                    return;
                }

                try
                {
                    using (StreamWriter writer = new StreamWriter(dataFilePath))
                    {//ADD
                        //writer.WriteLine("Time (s),Output R (V),Output Theta (Degrees),Input R (uV),Input Theta (Degrees),Supply Current (uA),Voltage (V)");
                        writer.WriteLine("Time (s),I_magnet (A),theta_magnet (Degrees),V_xy (uV),theta_xy (Degrees),I_xx (uA),V_xx (V),R_xx (kOhms)");
                        writer.Close();
                    }

                    recordingLabel.Visible = true;
                    recordingStartTime = System.DateTime.Now;
                    startRecordingButton.Text = "Stop Recording;";
                    _viewModel.StartRecording(dataFilePath, recordingStartTime);

                    dataRecordTimer = new System.Windows.Forms.Timer();
                    dataRecordTimer.Interval = 1000;
                    dataRecordTimer.Tick += new EventHandler((s, e2) =>
                    {
                        recordingLabel.Text = (System.DateTime.Now - recordingStartTime).ToString("hh\\:mm\\:ss");
                    });
                    dataRecordTimer.Start();

                    isRecording = true;
                    _viewModel.keepRecs = 32400;
                    _viewModel.current = Convert.ToInt32(KcurrentUpDown.Value);
                    //cartesianChart2.AxisX.Remove(dataRecordTimer);
                    /*cartesianChart2.AxisX.Add(new Axis
                    {
                        LabelFormatter = value => (System.DateTime.Now - recordingStartTime).ToString("hh\\:mm\\:ss"),
                        Title = "Time",
                        FontSize = 14,
                        Foreground = Brushes.Black,
                        BarUnit = 50000

                    });*/

                } catch (Exception IOException)
                {
                    Dialog errorDialog = new Dialog("It seems this file is being used by another process", "Error", false);
                    errorDialog.ShowDialog();
                    dataFilePath = null;
                    dataFileNameLabel.Text = "(Click Start to Choose File Name and Location)";
                    return;
                }
                
                

            }
            else
            {

                dataFilePath = null;
                dataFileNameLabel.Text = "(Click Start to Choose File Name and Location)";
                dataRecordTimer.Stop();
                startRecordingButton.Text = "Start Recording;";
                recordingLabel.Visible = false;
                recordingLabel.Text = "00:00:00";
                isRecording = false;


                _viewModel.StopRecording();
            }

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void dataFileNameLabel_Click(object sender, EventArgs e)
        {
           

        }

        private void tareButton_Click(object sender, EventArgs e)
        {
            //set flag that resets strain
            _viewModel._flag = true;
        }

        private void channelUpDown_ValueChanged(object sender, EventArgs e)
        {           
            _viewModel.ChangeChannel((int)channelUpDown.Value-1);
        }

        private void elementHost3_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void SampleHours_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SampleHours.Text, "  ^ [0-9]"))//accept integer values for sample rate
            {
                time_h = int.Parse(SampleHours.Text);
                total_time = time_h * 3600 + time_m * 60 + time_s;
                if (total_time > 6)
                {
                    total_time = total_time - 6;
                }
                _viewModel.delay_time = total_time * 1000;
            }
        }

        private void SampleMinutes_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SampleMinutes.Text, "  ^ [0-9]"))//accept integer values for sample rate
            {
                time_m = int.Parse(SampleMinutes.Text);
                total_time = time_h * 3600 + time_m * 60 + time_s;
                if (total_time > 6)
                {
                    total_time = total_time - 6;
                }
                _viewModel.delay_time = total_time * 1000;
            }
        }

        private void SampleSeconds_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SampleSeconds.Text, "  ^ [0-9]"))//accept integer values for sample rate
            {
                time_s = int.Parse(SampleSeconds.Text);
                total_time = time_h * 3600 + time_m * 60 + time_s;
                if (total_time > 6)
                {
                    total_time = total_time - 6;
                }
                _viewModel.delay_time = total_time * 1000;
            }
        }

        private void in521Box_Click(object sender, EventArgs e)
        {
            in521Box.Items.Clear();
            in521Box.Items.AddRange(str521);
        }

        private void out521Box_Click(object sender, EventArgs e)
        {
            out521Box.Items.Clear();
            out521Box.Items.AddRange(str521);
        }

        private void in10sBox_Click(object sender, EventArgs e)
        {
            in10sBox.Items.Clear();
            in10sBox.Items.AddRange(str10s);
        }

        private void out10sBox_Click(object sender, EventArgs e)
        {
            out10sBox.Items.Clear();
            out10sBox.Items.AddRange(str10s);
        }

        private void inUnitsBox_Click(object sender, EventArgs e)
        {
            inUnitsBox.Items.Clear();
            inUnitsBox.Items.AddRange(strunits);
        }

        private void outUnitsBox_Click(object sender, EventArgs e)
        {
            outUnitsBox.Items.Clear();
            outUnitsBox.Items.AddRange(strunits);
        }

        private void inVoltageBox_ValueChanged(object sender, EventArgs e)
        {
            _viewModel.SetV2(inVoltageBox.Value);
        }

        private void outVoltageBox_ValueChanged(object sender, EventArgs e)
        {
            _viewModel.SetV1(outVoltageBox.Value);
        }

        private void outFreqBox_ValueChanged(object sender, EventArgs e)
        {
            _viewModel.SetF1(outFreqBox.Value);
        }

        private void inFreqBox_ValueChanged(object sender, EventArgs e)
        {
            _viewModel.SetF2(inFreqBox.Value);
        }

        private void OnOffButton_Click(object sender, EventArgs e)
        {
            _viewModel.OK = false;
            button1.Enabled = true;
            _viewModel.KeithOnOff(_viewModel.KeithOn, KcurrentUpDown.Value);
            if (!_viewModel.KeithOn)
            {
                OnOffButton.Text = "Output On";
                _viewModel.KeithOn = true;
            }
            else
            {
                OnOffButton.Text = "Output Off";
                _viewModel.KeithOn = false;
            }
            
        }

        private void KcurrentUpDown_ValueChanged(object sender, EventArgs e)
        {
            currentSet = KcurrentUpDown.Value/(1000000);
           // if (_viewModel.KeithOn)
            ///{
                _viewModel.setCurr(currentSet);
           // }
        }

        private void ModeChange_Click(object sender, EventArgs e)
        {
            if (!_viewModel.KeithOn)
            {
                bool modechange = _viewModel.FourWireMode();
                if (modechange) { ModeChange.Text = "Switch to 2-Wire"; }
                else { ModeChange.Text = "Switch to 4-Wire"; }
            }
        }

        private void InputSens_Click(object sender, EventArgs e)
        {
            string box1 = in521Box.Text;
            string box2 = in10sBox.Text;
            string box3 = inUnitsBox.Text;
            int sensval = -1;
            if (box1 == "0" || box2 == "0" || box3 == "0")
            {
                Console.WriteLine("JAIL");
            }
            else
            {
                if (box1 == "2") { sensval += 1; }
                if (box1 == "5") { sensval += 2; }
                if (box2 == "x10") { sensval += 3; }
                if (box2 == "x100") { sensval += 6; }
                if (box3 == "uV") { sensval += 9; }
                if (box3 == "mV") { sensval += 18; }
                if (box3 == "V") { sensval += 27; }
                if (sensval == -1 || sensval > 26) { Console.WriteLine("out of range"); }
                //change the sensitivity value
                _viewModel.changeSens2(sensval);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _viewModel.OK = true;
            button1.Enabled = false;
        }

        private void tableLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void KcompUpDown_ValueChanged(object sender, EventArgs e)
        {
            string Vlim = Convert.ToString(KcompUpDown.Value);
            _viewModel.setVlim(Vlim);
        }

        private void OutputSens_Click(object sender, EventArgs e)
        {
            string box1 = out521Box.Text;
            string box2 = out10sBox.Text;
            string box3 = outUnitsBox.Text;
            int sensval = -1;
            if (box1 == "0" || box2 == "0" || box3 == "0")
            {
                Console.WriteLine("JAIL");
            }
            else
            {
                if (box1 == "2") { sensval += 1; }
                if (box1 == "5") { sensval += 2; }
                if (box2 == "x10") { sensval += 3; }
                if (box2 == "x100") { sensval += 6; }
                if (box3 == "uV") { sensval += 9; }
                if (box3 == "mV") { sensval += 18; }
                if (box3 == "V") { sensval += 27; }
                if (sensval == -1 || sensval > 26) { Console.WriteLine("out of range"); }
                //change the sensitivity value
                _viewModel.changeSens1(sensval);
            }
        }

        private void PlotReset_Click(object sender, EventArgs e)
        {
            _viewModel.ResValues.Clear();
            _viewModel.Data.Clear();
            _viewModel.ResValues.Add(new DateModel { DateTime = _viewModel.TimeMatrix[_viewModel.TimeMatrix.Count - 1], Value = _viewModel.DataMatrix[_viewModel.DataMatrix.Count-1][_viewModel.ChannelIndex] });
            _viewModel.Data.Add(_viewModel.DataMatrix[_viewModel.DataMatrix.Count - 1][_viewModel.ChannelIndex]);
        }

        private void VFbutton_Click(object sender, EventArgs e)
        {
            /*if (isRecording && _viewModel.ResValues.Count > 60)
            {
                double vfmag = 0;
                double vfphase = 0;
                double[] avg = _viewModel.Getdata(30, 0);
                double[] p_avg = _viewModel.Getdata(30,1);
                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine(avg.Length);
                    Console.WriteLine(i + "???");
                    vfmag+= avg[i];
                    vfphase+= p_avg[i];
                }
                VFmag = vfmag / 30;
                VFphase = vfphase / 30;
                VFmagbox.Text = Convert.ToString(VFmag);
                VFPhaseBox.Text = Convert.ToString(VFphase);
                VFavg = true;
            }*/
            VFavg = true;
        }

        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        static public bool CheckFileFormat(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string[] cals = reader.ReadLine().Split(',');

                CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                ci.NumberFormat.CurrencyDecimalSeparator = ".";
                try
                {
                    float.Parse(cals[0], NumberStyles.Any, ci);
                    float.Parse(cals[1], NumberStyles.Any, ci);
                    float.Parse(cals[2], NumberStyles.Any, ci);/*
                    float.Parse(cals[3], NumberStyles.Any, ci);
                    float.Parse(cals[4], NumberStyles.Any, ci);
                    float.Parse(cals[5], NumberStyles.Any, ci);*/
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        static private double RSD( double d, int digits)
        {
            //rounds to x significant digits
            if (d == 0)
                return 0;

            double scale = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(d))) + 1);
            return scale * Math.Round(d / scale, digits);
        }

        static public void LoadCalibration(string path, string filename, bool showdialog)
        {

            using (StreamReader reader = new StreamReader(path))
            {
                string[] cals = reader.ReadLine().Split(',');
                Console.WriteLine("{0},{1}", cals[0], cals[1]);
                float k1, k2, k3, k4, RT, AT;
                CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                ci.NumberFormat.CurrencyDecimalSeparator = ".";
                try
                {
                    k1 = float.Parse(cals[0], NumberStyles.Any, ci);/*
                    k2 = float.Parse(cals[1], NumberStyles.Any, ci);
                    k3 = float.Parse(cals[2], NumberStyles.Any, ci);
                    k4 = float.Parse(cals[3], NumberStyles.Any, ci);*/
                    RT = float.Parse(cals[1], NumberStyles.Any, ci);
                    AT = float.Parse(cals[2], NumberStyles.Any, ci);

                    if (RT < 0 || AT < 0)
                    {
                        Properties.Settings.Default["loadedFilePath"] = "";
                        Properties.Settings.Default["loadedFileName"] = "";
                        Properties.Settings.Default.Save();
                        Dialog importErrorDialog = new Dialog("The loaded calbiration file contains some out of range calibration values, calibration import was aborted.", "Calibration Import Error", false);
                        importErrorDialog.ShowDialog();
                        return;
                    }
                    _viewModel._k1_strain = k1;
                    /*_viewModel._k2_strain = k2;
                    _viewModel._k3_strain = k3;
                    _viewModel._k4_strain = k4;*/
                    ChangeRateThreshold(RT);
                    _viewModel.Amplitude_Threshold = AT;
                }
                catch (Exception e)
                {
                    Dialog errorDialog = new Dialog("Attempted to load a file not\nin the correct format", "Error", false);
                    errorDialog.ShowDialog();
                    return;
                }
                if (showdialog)
                {

                    Dialog calibInfoDialog = new Dialog(String.Format("The calibration values have been loaded:\n Sample sensitivity (% strain / Ω) = \t{0}, \n Rate threshold = \t{1}, \n Amplitude threshold = \t {2}.",
                        RSD(_viewModel._k1_strain,2), RSD(_viewModel.Rate_Threshold,2), RSD(_viewModel.Amplitude_Threshold,2)), "Calibration Loaded", false);
                    calibInfoDialog.ShowDialog();
                }



                //used to be a line here to update temp calibrations
                //Properties.Settings.Default["k"] = (float)_viewModel._k_strain;
                _viewModel._floor = -88;
                _viewModel.Clear();
            }

            Properties.Settings.Default["loadedFilePath"] = path;
            Properties.Settings.Default["loadedFileName"] = filename;
            Properties.Settings.Default.Save();

        }

       

    }
}
