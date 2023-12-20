namespace MesoMatDemoApp
{
    partial class WelcomeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LIAinUpDown = new System.Windows.Forms.NumericUpDown();
            this.LIAoutUpDown = new System.Windows.Forms.NumericUpDown();
            this.KeithUpDown = new System.Windows.Forms.NumericUpDown();
            this.Connect = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LIAinUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIAoutUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeithUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LIAinUpDown, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LIAoutUpDown, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.KeithUpDown, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Connect, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(377, 275);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Measure LIA GPIB";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source LIA GPIB";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Keithley GPIB";
            // 
            // LIAinUpDown
            // 
            this.LIAinUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LIAinUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIAinUpDown.Location = new System.Drawing.Point(194, 69);
            this.LIAinUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.LIAinUpDown.Name = "LIAinUpDown";
            this.LIAinUpDown.Size = new System.Drawing.Size(40, 22);
            this.LIAinUpDown.TabIndex = 3;
            this.LIAinUpDown.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // LIAoutUpDown
            // 
            this.LIAoutUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LIAoutUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIAoutUpDown.Location = new System.Drawing.Point(194, 121);
            this.LIAoutUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.LIAoutUpDown.Name = "LIAoutUpDown";
            this.LIAoutUpDown.Size = new System.Drawing.Size(40, 22);
            this.LIAoutUpDown.TabIndex = 4;
            this.LIAoutUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // KeithUpDown
            // 
            this.KeithUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KeithUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeithUpDown.Location = new System.Drawing.Point(194, 166);
            this.KeithUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.KeithUpDown.Name = "KeithUpDown";
            this.KeithUpDown.Size = new System.Drawing.Size(40, 22);
            this.KeithUpDown.TabIndex = 5;
            this.KeithUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Connect
            // 
            this.Connect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.Location = new System.Drawing.Point(269, 111);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(89, 42);
            this.Connect.TabIndex = 6;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // WelcomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 275);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WelcomeWindow";
            this.Text = "MesoMat Demo";
            this.Load += new System.EventHandler(this.WelcomeWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LIAinUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIAoutUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeithUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown LIAinUpDown;
        private System.Windows.Forms.NumericUpDown LIAoutUpDown;
        private System.Windows.Forms.NumericUpDown KeithUpDown;
        private System.Windows.Forms.Button Connect;
    }
}