using System.ComponentModel;
using System.Windows.Forms;

namespace MesoMatDemoApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ChannelSelectLabel = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.RecordDataLabel = new System.Windows.Forms.Label();
            this.dataFileNameLabel = new System.Windows.Forms.Label();
            this.FileNameHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.startRecordingButton = new System.Windows.Forms.Button();
            this.recordingLabel = new System.Windows.Forms.Label();
            this.channelUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SampleHours = new System.Windows.Forms.TextBox();
            this.SampleMinutes = new System.Windows.Forms.TextBox();
            this.SampleSeconds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.VFPhaseBox = new System.Windows.Forms.TextBox();
            this.VFmagbox = new System.Windows.Forms.TextBox();
            this.VFbutton = new System.Windows.Forms.Button();
            this.viewContainerPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart2 = new LiveCharts.Wpf.CartesianChart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.out521Box = new System.Windows.Forms.ComboBox();
            this.out10sBox = new System.Windows.Forms.ComboBox();
            this.outUnitsBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.outVoltageBox = new System.Windows.Forms.NumericUpDown();
            this.outFreqBox = new System.Windows.Forms.NumericUpDown();
            this.OutputSens = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inVoltageBox = new System.Windows.Forms.NumericUpDown();
            this.inFreqBox = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.in521Box = new System.Windows.Forms.ComboBox();
            this.in10sBox = new System.Windows.Forms.ComboBox();
            this.inUnitsBox = new System.Windows.Forms.ComboBox();
            this.InputSens = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.KcompUpDown = new System.Windows.Forms.NumericUpDown();
            this.KcurrentUpDown = new System.Windows.Forms.NumericUpDown();
            this.OnOffButton = new System.Windows.Forms.Button();
            this.ModeChange = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.KrBox = new System.Windows.Forms.TextBox();
            this.KcurrentBox = new System.Windows.Forms.TextBox();
            this.outLIAthetaBox = new System.Windows.Forms.TextBox();
            this.outLIArBox = new System.Windows.Forms.TextBox();
            this.inLIAthetaBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.inLIArBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CCEbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.PlotReset = new System.Windows.Forms.Button();
            this.calibrationLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channelUpDown)).BeginInit();
            this.viewContainerPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outVoltageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outFreqBox)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inVoltageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inFreqBox)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KcompUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KcurrentUpDown)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1338, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.viewContainerPanel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.017919F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.15617F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.825897F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1338, 689);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ChannelSelectLabel, 1, 19);
            this.tableLayoutPanel2.Controls.Add(this.splitter2, 1, 17);
            this.tableLayoutPanel2.Controls.Add(this.splitter1, 1, 23);
            this.tableLayoutPanel2.Controls.Add(this.splitter3, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.RecordDataLabel, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.dataFileNameLabel, 1, 12);
            this.tableLayoutPanel2.Controls.Add(this.FileNameHeader, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 14);
            this.tableLayoutPanel2.Controls.Add(this.recordingLabel, 1, 15);
            this.tableLayoutPanel2.Controls.Add(this.channelUpDown, 1, 21);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.SampleHours, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.SampleMinutes, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.SampleSeconds, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label24, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.VFPhaseBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.VFmagbox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.VFbutton, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1128, 36);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 25;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(208, 624);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // ChannelSelectLabel
            // 
            this.ChannelSelectLabel.AutoSize = true;
            this.ChannelSelectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChannelSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelSelectLabel.Location = new System.Drawing.Point(36, 544);
            this.ChannelSelectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChannelSelectLabel.Name = "ChannelSelectLabel";
            this.ChannelSelectLabel.Size = new System.Drawing.Size(136, 16);
            this.ChannelSelectLabel.TabIndex = 20;
            this.ChannelSelectLabel.Text = "Channel Selection:";
            this.ChannelSelectLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(36, 526);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(136, 3);
            this.splitter2.TabIndex = 17;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(36, 610);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(136, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(36, 338);
            this.splitter3.Margin = new System.Windows.Forms.Padding(2);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(136, 3);
            this.splitter3.TabIndex = 10;
            this.splitter3.TabStop = false;
            // 
            // RecordDataLabel
            // 
            this.RecordDataLabel.AutoSize = true;
            this.RecordDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordDataLabel.Location = new System.Drawing.Point(36, 357);
            this.RecordDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RecordDataLabel.Name = "RecordDataLabel";
            this.RecordDataLabel.Size = new System.Drawing.Size(136, 16);
            this.RecordDataLabel.TabIndex = 11;
            this.RecordDataLabel.Text = "Record Data";
            this.RecordDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataFileNameLabel
            // 
            this.dataFileNameLabel.AutoSize = true;
            this.dataFileNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFileNameLabel.Location = new System.Drawing.Point(36, 400);
            this.dataFileNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataFileNameLabel.Name = "dataFileNameLabel";
            this.dataFileNameLabel.Size = new System.Drawing.Size(136, 48);
            this.dataFileNameLabel.TabIndex = 13;
            this.dataFileNameLabel.Text = "(Click Start to Choose File Name and Location)";
            this.dataFileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dataFileNameLabel.Click += new System.EventHandler(this.dataFileNameLabel_Click);
            // 
            // FileNameHeader
            // 
            this.FileNameHeader.AutoSize = true;
            this.FileNameHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileNameHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameHeader.Location = new System.Drawing.Point(36, 384);
            this.FileNameHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileNameHeader.Name = "FileNameHeader";
            this.FileNameHeader.Size = new System.Drawing.Size(136, 16);
            this.FileNameHeader.TabIndex = 12;
            this.FileNameHeader.Text = "File Name:";
            this.FileNameHeader.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FileNameHeader.Click += new System.EventHandler(this.label5_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.startRecordingButton, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(36, 462);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(136, 34);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // startRecordingButton
            // 
            this.startRecordingButton.AutoSize = true;
            this.startRecordingButton.Location = new System.Drawing.Point(25, 2);
            this.startRecordingButton.Margin = new System.Windows.Forms.Padding(2);
            this.startRecordingButton.Name = "startRecordingButton";
            this.startRecordingButton.Size = new System.Drawing.Size(86, 30);
            this.startRecordingButton.TabIndex = 6;
            this.startRecordingButton.Text = "Start Recording";
            this.startRecordingButton.UseVisualStyleBackColor = true;
            this.startRecordingButton.Click += new System.EventHandler(this.startRecordingButton_Click);
            // 
            // recordingLabel
            // 
            this.recordingLabel.AutoSize = true;
            this.recordingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordingLabel.Location = new System.Drawing.Point(36, 498);
            this.recordingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recordingLabel.Name = "recordingLabel";
            this.recordingLabel.Size = new System.Drawing.Size(136, 16);
            this.recordingLabel.TabIndex = 15;
            this.recordingLabel.Text = "00:00:00";
            this.recordingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.recordingLabel.Visible = false;
            // 
            // channelUpDown
            // 
            this.channelUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.channelUpDown.CausesValidation = false;
            this.channelUpDown.Location = new System.Drawing.Point(44, 573);
            this.channelUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.channelUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.channelUpDown.Name = "channelUpDown";
            this.channelUpDown.Size = new System.Drawing.Size(120, 22);
            this.channelUpDown.TabIndex = 24;
            this.channelUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.channelUpDown.ValueChanged += new System.EventHandler(this.channelUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 81);
            this.label1.TabIndex = 25;
            this.label1.Text = "Desired Sampling Period";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SampleHours
            // 
            this.SampleHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SampleHours.Location = new System.Drawing.Point(54, 225);
            this.SampleHours.Name = "SampleHours";
            this.SampleHours.Size = new System.Drawing.Size(100, 22);
            this.SampleHours.TabIndex = 26;
            this.SampleHours.Text = "0";
            this.SampleHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SampleHours.TextChanged += new System.EventHandler(this.SampleHours_TextChanged);
            // 
            // SampleMinutes
            // 
            this.SampleMinutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SampleMinutes.Location = new System.Drawing.Point(54, 265);
            this.SampleMinutes.Name = "SampleMinutes";
            this.SampleMinutes.Size = new System.Drawing.Size(100, 22);
            this.SampleMinutes.TabIndex = 27;
            this.SampleMinutes.Text = "0";
            this.SampleMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SampleMinutes.TextChanged += new System.EventHandler(this.SampleMinutes_TextChanged);
            // 
            // SampleSeconds
            // 
            this.SampleSeconds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SampleSeconds.Location = new System.Drawing.Point(54, 305);
            this.SampleSeconds.Name = "SampleSeconds";
            this.SampleSeconds.Size = new System.Drawing.Size(100, 22);
            this.SampleSeconds.TabIndex = 28;
            this.SampleSeconds.Text = "25";
            this.SampleSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SampleSeconds.TextChanged += new System.EventHandler(this.SampleSeconds_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "h:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "m:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 308);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 16);
            this.label24.TabIndex = 31;
            this.label24.Text = "s:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VFPhaseBox
            // 
            this.VFPhaseBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VFPhaseBox.Location = new System.Drawing.Point(54, 49);
            this.VFPhaseBox.Name = "VFPhaseBox";
            this.VFPhaseBox.Size = new System.Drawing.Size(100, 22);
            this.VFPhaseBox.TabIndex = 32;
            // 
            // VFmagbox
            // 
            this.VFmagbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VFmagbox.Location = new System.Drawing.Point(54, 9);
            this.VFmagbox.Name = "VFmagbox";
            this.VFmagbox.Size = new System.Drawing.Size(100, 22);
            this.VFmagbox.TabIndex = 33;
            // 
            // VFbutton
            // 
            this.VFbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VFbutton.Location = new System.Drawing.Point(66, 88);
            this.VFbutton.Name = "VFbutton";
            this.VFbutton.Size = new System.Drawing.Size(75, 23);
            this.VFbutton.TabIndex = 34;
            this.VFbutton.Text = "Estimate Vf";
            this.VFbutton.UseVisualStyleBackColor = true;
            this.VFbutton.Click += new System.EventHandler(this.VFbutton_Click);
            // 
            // viewContainerPanel
            // 
            this.viewContainerPanel.AutoSize = true;
            this.viewContainerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewContainerPanel.Controls.Add(this.tableLayoutPanel5);
            this.viewContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewContainerPanel.Location = new System.Drawing.Point(30, 36);
            this.viewContainerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.viewContainerPanel.Name = "viewContainerPanel";
            this.viewContainerPanel.Size = new System.Drawing.Size(1094, 624);
            this.viewContainerPanel.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.tableLayoutPanel5.Controls.Add(this.elementHost3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel10, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel12, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1094, 624);
            this.tableLayoutPanel5.TabIndex = 1;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // elementHost3
            // 
            this.elementHost3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost3.Location = new System.Drawing.Point(2, 2);
            this.elementHost3.Margin = new System.Windows.Forms.Padding(2);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(832, 413);
            this.elementHost3.TabIndex = 0;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost3_ChildChanged);
            this.elementHost3.Child = this.cartesianChart2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel11, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 420);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(830, 201);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.outVoltageBox, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.outFreqBox, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.OutputSens, 0, 2);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(279, 43);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(270, 150);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Controls.Add(this.out521Box, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.out10sBox, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.outUnitsBox, 2, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(111, 101);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(156, 44);
            this.tableLayoutPanel9.TabIndex = 6;
            // 
            // out521Box
            // 
            this.out521Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out521Box.FormattingEnabled = true;
            this.out521Box.Location = new System.Drawing.Point(3, 11);
            this.out521Box.Name = "out521Box";
            this.out521Box.Size = new System.Drawing.Size(46, 21);
            this.out521Box.TabIndex = 0;
            this.out521Box.Text = "0";
            this.out521Box.Click += new System.EventHandler(this.out521Box_Click);
            // 
            // out10sBox
            // 
            this.out10sBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.out10sBox.FormattingEnabled = true;
            this.out10sBox.Location = new System.Drawing.Point(55, 11);
            this.out10sBox.Name = "out10sBox";
            this.out10sBox.Size = new System.Drawing.Size(46, 21);
            this.out10sBox.TabIndex = 1;
            this.out10sBox.Text = "0";
            this.out10sBox.Click += new System.EventHandler(this.out10sBox_Click);
            // 
            // outUnitsBox
            // 
            this.outUnitsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outUnitsBox.FormattingEnabled = true;
            this.outUnitsBox.Location = new System.Drawing.Point(107, 11);
            this.outUnitsBox.Name = "outUnitsBox";
            this.outUnitsBox.Size = new System.Drawing.Size(46, 21);
            this.outUnitsBox.TabIndex = 2;
            this.outUnitsBox.Text = "0";
            this.outUnitsBox.Click += new System.EventHandler(this.outUnitsBox_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Voltage (V)";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Frequency (Hz)";
            // 
            // outVoltageBox
            // 
            this.outVoltageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outVoltageBox.DecimalPlaces = 3;
            this.outVoltageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outVoltageBox.Increment = new decimal(new int[] {
            2,
            0,
            0,
            196608});
            this.outVoltageBox.Location = new System.Drawing.Point(129, 13);
            this.outVoltageBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.outVoltageBox.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            196608});
            this.outVoltageBox.Name = "outVoltageBox";
            this.outVoltageBox.Size = new System.Drawing.Size(120, 22);
            this.outVoltageBox.TabIndex = 3;
            this.outVoltageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.outVoltageBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            196608});
            this.outVoltageBox.ValueChanged += new System.EventHandler(this.outVoltageBox_ValueChanged);
            // 
            // outFreqBox
            // 
            this.outFreqBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outFreqBox.DecimalPlaces = 3;
            this.outFreqBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outFreqBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.outFreqBox.Location = new System.Drawing.Point(129, 62);
            this.outFreqBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.outFreqBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.outFreqBox.Name = "outFreqBox";
            this.outFreqBox.Size = new System.Drawing.Size(120, 22);
            this.outFreqBox.TabIndex = 4;
            this.outFreqBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.outFreqBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.outFreqBox.ValueChanged += new System.EventHandler(this.outFreqBox_ValueChanged);
            // 
            // OutputSens
            // 
            this.OutputSens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutputSens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputSens.Location = new System.Drawing.Point(13, 102);
            this.OutputSens.Name = "OutputSens";
            this.OutputSens.Size = new System.Drawing.Size(81, 44);
            this.OutputSens.TabIndex = 7;
            this.OutputSens.Text = "Change Sensitivity";
            this.OutputSens.UseVisualStyleBackColor = true;
            this.OutputSens.Click += new System.EventHandler(this.OutputSens_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Input Lock-In Control";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Output Lock-In Control";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(627, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Keithley Control";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.inVoltageBox, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.inFreqBox, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.InputSens, 0, 2);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(270, 150);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Voltage (V)";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Frequency (Hz)";
            // 
            // inVoltageBox
            // 
            this.inVoltageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inVoltageBox.DecimalPlaces = 3;
            this.inVoltageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inVoltageBox.Increment = new decimal(new int[] {
            2,
            0,
            0,
            196608});
            this.inVoltageBox.Location = new System.Drawing.Point(129, 13);
            this.inVoltageBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.inVoltageBox.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            196608});
            this.inVoltageBox.Name = "inVoltageBox";
            this.inVoltageBox.Size = new System.Drawing.Size(120, 22);
            this.inVoltageBox.TabIndex = 3;
            this.inVoltageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inVoltageBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            196608});
            this.inVoltageBox.ValueChanged += new System.EventHandler(this.inVoltageBox_ValueChanged);
            // 
            // inFreqBox
            // 
            this.inFreqBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inFreqBox.DecimalPlaces = 3;
            this.inFreqBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inFreqBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.inFreqBox.Location = new System.Drawing.Point(129, 62);
            this.inFreqBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inFreqBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.inFreqBox.Name = "inFreqBox";
            this.inFreqBox.Size = new System.Drawing.Size(120, 22);
            this.inFreqBox.TabIndex = 4;
            this.inFreqBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inFreqBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.inFreqBox.ValueChanged += new System.EventHandler(this.inFreqBox_ValueChanged);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Controls.Add(this.in521Box, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.in10sBox, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.inUnitsBox, 2, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(111, 101);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(156, 44);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // in521Box
            // 
            this.in521Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.in521Box.FormattingEnabled = true;
            this.in521Box.Location = new System.Drawing.Point(3, 11);
            this.in521Box.Name = "in521Box";
            this.in521Box.Size = new System.Drawing.Size(46, 21);
            this.in521Box.TabIndex = 0;
            this.in521Box.Text = "0";
            this.in521Box.Click += new System.EventHandler(this.in521Box_Click);
            // 
            // in10sBox
            // 
            this.in10sBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.in10sBox.FormattingEnabled = true;
            this.in10sBox.Location = new System.Drawing.Point(55, 11);
            this.in10sBox.Name = "in10sBox";
            this.in10sBox.Size = new System.Drawing.Size(46, 21);
            this.in10sBox.TabIndex = 1;
            this.in10sBox.Text = "0";
            this.in10sBox.Click += new System.EventHandler(this.in10sBox_Click);
            // 
            // inUnitsBox
            // 
            this.inUnitsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inUnitsBox.FormattingEnabled = true;
            this.inUnitsBox.Location = new System.Drawing.Point(107, 11);
            this.inUnitsBox.Name = "inUnitsBox";
            this.inUnitsBox.Size = new System.Drawing.Size(46, 21);
            this.inUnitsBox.TabIndex = 2;
            this.inUnitsBox.Text = "0";
            this.inUnitsBox.Click += new System.EventHandler(this.inUnitsBox_Click);
            // 
            // InputSens
            // 
            this.InputSens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputSens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSens.Location = new System.Drawing.Point(13, 102);
            this.InputSens.Name = "InputSens";
            this.InputSens.Size = new System.Drawing.Size(81, 44);
            this.InputSens.TabIndex = 6;
            this.InputSens.Text = "Change Sensitivity";
            this.InputSens.UseVisualStyleBackColor = true;
            this.InputSens.Click += new System.EventHandler(this.InputSens_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.16177F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.83823F));
            this.tableLayoutPanel11.Controls.Add(this.KcompUpDown, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.KcurrentUpDown, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.OnOffButton, 1, 2);
            this.tableLayoutPanel11.Controls.Add(this.ModeChange, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.label19, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(555, 43);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(272, 155);
            this.tableLayoutPanel11.TabIndex = 5;
            this.tableLayoutPanel11.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel11_Paint);
            // 
            // KcompUpDown
            // 
            this.KcompUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KcompUpDown.DecimalPlaces = 2;
            this.KcompUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KcompUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.KcompUpDown.Location = new System.Drawing.Point(150, 65);
            this.KcompUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.KcompUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.KcompUpDown.Name = "KcompUpDown";
            this.KcompUpDown.Size = new System.Drawing.Size(103, 22);
            this.KcompUpDown.TabIndex = 6;
            this.KcompUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.KcompUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.KcompUpDown.ValueChanged += new System.EventHandler(this.KcompUpDown_ValueChanged);
            // 
            // KcurrentUpDown
            // 
            this.KcurrentUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KcurrentUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KcurrentUpDown.Location = new System.Drawing.Point(150, 14);
            this.KcurrentUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.KcurrentUpDown.Name = "KcurrentUpDown";
            this.KcurrentUpDown.Size = new System.Drawing.Size(103, 22);
            this.KcurrentUpDown.TabIndex = 2;
            this.KcurrentUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.KcurrentUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.KcurrentUpDown.ValueChanged += new System.EventHandler(this.KcurrentUpDown_ValueChanged);
            // 
            // OnOffButton
            // 
            this.OnOffButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OnOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnOffButton.Location = new System.Drawing.Point(158, 108);
            this.OnOffButton.Name = "OnOffButton";
            this.OnOffButton.Size = new System.Drawing.Size(87, 41);
            this.OnOffButton.TabIndex = 4;
            this.OnOffButton.Text = "Output Off";
            this.OnOffButton.UseVisualStyleBackColor = true;
            this.OnOffButton.Click += new System.EventHandler(this.OnOffButton_Click);
            // 
            // ModeChange
            // 
            this.ModeChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModeChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeChange.Location = new System.Drawing.Point(13, 107);
            this.ModeChange.Name = "ModeChange";
            this.ModeChange.Size = new System.Drawing.Size(104, 42);
            this.ModeChange.TabIndex = 3;
            this.ModeChange.Text = "Switch to 4-Wire";
            this.ModeChange.UseVisualStyleBackColor = true;
            this.ModeChange.Click += new System.EventHandler(this.ModeChange_Click);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(11, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "Output Current (uA)";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 32);
            this.label9.TabIndex = 5;
            this.label9.Text = "Compliance Voltage (V)";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.KrBox, 1, 5);
            this.tableLayoutPanel10.Controls.Add(this.KcurrentBox, 1, 4);
            this.tableLayoutPanel10.Controls.Add(this.outLIAthetaBox, 1, 3);
            this.tableLayoutPanel10.Controls.Add(this.outLIArBox, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.inLIAthetaBox, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.label16, 0, 4);
            this.tableLayoutPanel10.Controls.Add(this.label18, 0, 5);
            this.tableLayoutPanel10.Controls.Add(this.inLIArBox, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.label12, 0, 6);
            this.tableLayoutPanel10.Controls.Add(this.CCEbox, 1, 6);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(839, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 7;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(252, 411);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // KrBox
            // 
            this.KrBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KrBox.Enabled = false;
            this.KrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KrBox.Location = new System.Drawing.Point(139, 308);
            this.KrBox.Name = "KrBox";
            this.KrBox.Size = new System.Drawing.Size(100, 22);
            this.KrBox.TabIndex = 11;
            this.KrBox.Text = "0.00";
            this.KrBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KcurrentBox
            // 
            this.KcurrentBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KcurrentBox.Enabled = false;
            this.KcurrentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KcurrentBox.Location = new System.Drawing.Point(139, 250);
            this.KcurrentBox.Name = "KcurrentBox";
            this.KcurrentBox.Size = new System.Drawing.Size(100, 22);
            this.KcurrentBox.TabIndex = 10;
            this.KcurrentBox.Text = "0.00";
            this.KcurrentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outLIAthetaBox
            // 
            this.outLIAthetaBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outLIAthetaBox.Enabled = false;
            this.outLIAthetaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outLIAthetaBox.Location = new System.Drawing.Point(139, 192);
            this.outLIAthetaBox.Name = "outLIAthetaBox";
            this.outLIAthetaBox.Size = new System.Drawing.Size(100, 22);
            this.outLIAthetaBox.TabIndex = 9;
            this.outLIAthetaBox.Text = "0.00";
            this.outLIAthetaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outLIArBox
            // 
            this.outLIArBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outLIArBox.Enabled = false;
            this.outLIArBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outLIArBox.Location = new System.Drawing.Point(139, 134);
            this.outLIArBox.Name = "outLIArBox";
            this.outLIArBox.Size = new System.Drawing.Size(100, 22);
            this.outLIArBox.TabIndex = 8;
            this.outLIArBox.Text = "0.00";
            this.outLIArBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inLIAthetaBox
            // 
            this.inLIAthetaBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inLIAthetaBox.Enabled = false;
            this.inLIAthetaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inLIAthetaBox.Location = new System.Drawing.Point(139, 76);
            this.inLIAthetaBox.Name = "inLIAthetaBox";
            this.inLIAthetaBox.Size = new System.Drawing.Size(100, 22);
            this.inLIAthetaBox.TabIndex = 7;
            this.inLIAthetaBox.Text = "0.00";
            this.inLIAthetaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 32);
            this.label17.TabIndex = 4;
            this.label17.Text = "Output Lock-In Amplitude (Ch 1)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Input Lock-In Amplitude (Ch 3)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 32);
            this.label14.TabIndex = 1;
            this.label14.Text = "Input Lock-In Phase (Ch 4)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 32);
            this.label15.TabIndex = 2;
            this.label15.Text = "Output Lock-In Phase (Ch 2)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 32);
            this.label16.TabIndex = 3;
            this.label16.Text = "Keithley Applied Current (Ch 5) ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 303);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(118, 32);
            this.label18.TabIndex = 5;
            this.label18.Text = "Keithley Measured Voltage (Ch 6)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inLIArBox
            // 
            this.inLIArBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inLIArBox.Enabled = false;
            this.inLIArBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inLIArBox.Location = new System.Drawing.Point(139, 18);
            this.inLIArBox.Name = "inLIArBox";
            this.inLIArBox.Size = new System.Drawing.Size(100, 22);
            this.inLIArBox.TabIndex = 6;
            this.inLIArBox.Text = "0.00";
            this.inLIArBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 48);
            this.label12.TabIndex = 12;
            this.label12.Text = "Carrier Concentration Estimate";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CCEbox
            // 
            this.CCEbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CCEbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCEbox.Location = new System.Drawing.Point(139, 368);
            this.CCEbox.Name = "CCEbox";
            this.CCEbox.Size = new System.Drawing.Size(100, 22);
            this.CCEbox.TabIndex = 13;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 3;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.PlotReset, 0, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(839, 420);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 3;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(252, 198);
            this.tableLayoutPanel12.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(87, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlotReset
            // 
            this.PlotReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlotReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotReset.Location = new System.Drawing.Point(4, 9);
            this.PlotReset.Name = "PlotReset";
            this.PlotReset.Size = new System.Drawing.Size(75, 47);
            this.PlotReset.TabIndex = 4;
            this.PlotReset.Text = "Reset Plot";
            this.PlotReset.UseVisualStyleBackColor = true;
            this.PlotReset.Click += new System.EventHandler(this.PlotReset_Click);
            // 
            // calibrationLabel
            // 
            this.calibrationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calibrationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calibrationLabel.Location = new System.Drawing.Point(21, 0);
            this.calibrationLabel.Name = "calibrationLabel";
            this.calibrationLabel.Size = new System.Drawing.Size(61, 15);
            this.calibrationLabel.TabIndex = 2;
            this.calibrationLabel.Text = "Calibrating";
            this.calibrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1338, 713);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "MainWindow";
            this.Text = "MesoMat Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channelUpDown)).EndInit();
            this.viewContainerPanel.ResumeLayout(false);
            this.viewContainerPanel.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outVoltageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outFreqBox)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inVoltageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inFreqBox)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KcompUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KcurrentUpDown)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label calibrationLabel;
        private Panel viewContainerPanel;
        private TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private LiveCharts.Wpf.CartesianChart cartesianChart2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label ChannelSelectLabel;
        private Splitter splitter2;
        private Splitter splitter1;
        private Splitter splitter3;
        private Label RecordDataLabel;
        private Label dataFileNameLabel;
        private Label FileNameHeader;
        private Label recordingLabel;
        private TableLayoutPanel tableLayoutPanel4;
        private Button startRecordingButton;
        private NumericUpDown channelUpDown;
        private Label label1;
        private TextBox SampleHours;
        private TextBox SampleMinutes;
        private TextBox SampleSeconds;
        private Label label2;
        private Label label5;
        private Label label24;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Label label4;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label10;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label7;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel9;
        private NumericUpDown outVoltageBox;
        private NumericUpDown outFreqBox;
        private NumericUpDown inVoltageBox;
        private NumericUpDown inFreqBox;
        private TableLayoutPanel tableLayoutPanel8;
        private ComboBox out521Box;
        private ComboBox out10sBox;
        private ComboBox outUnitsBox;
        private ComboBox in521Box;
        private ComboBox in10sBox;
        private ComboBox inUnitsBox;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label17;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label18;
        private TextBox KrBox;
        private TextBox KcurrentBox;
        private TextBox outLIAthetaBox;
        private TextBox outLIArBox;
        private TextBox inLIAthetaBox;
        private TextBox inLIArBox;
        private TableLayoutPanel tableLayoutPanel11;
        private Label label19;
        private NumericUpDown KcurrentUpDown;
        private Button ModeChange;
        private Button OnOffButton;
        private Button OutputSens;
        private Button InputSens;
        private Button button1;
        private NumericUpDown KcompUpDown;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel12;
        private Button PlotReset;
        private Label label12;
        private TextBox VFPhaseBox;
        private TextBox VFmagbox;
        private Button VFbutton;
        private TextBox CCEbox;
    }
}

