namespace MesoMatDemoApp
{
    partial class Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleText = new System.Windows.Forms.Label();
            this.buttonTabelLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.contentText = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.titleText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonTabelLayoutPanel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.contentText, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 160);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(62, 0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(269, 32);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "label1";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTabelLayoutPanel
            // 
            this.buttonTabelLayoutPanel.AutoSize = true;
            this.buttonTabelLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.buttonTabelLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTabelLayoutPanel.Location = new System.Drawing.Point(62, 111);
            this.buttonTabelLayoutPanel.Name = "buttonTabelLayoutPanel";
            this.buttonTabelLayoutPanel.RowCount = 1;
            this.buttonTabelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTabelLayoutPanel.Size = new System.Drawing.Size(269, 46);
            this.buttonTabelLayoutPanel.TabIndex = 2;
            // 
            // contentText
            // 
            this.contentText.AutoSize = true;
            this.contentText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentText.Location = new System.Drawing.Point(62, 32);
            this.contentText.Name = "contentText";
            this.contentText.Size = new System.Drawing.Size(269, 64);
            this.contentText.TabIndex = 1;
            this.contentText.Text = "label2";
            this.contentText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(61, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(70, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(137, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(394, 160);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog";
            this.Text = "MesoMat Database";
            this.Load += new System.EventHandler(this.Dialog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label contentText;
        private System.Windows.Forms.TableLayoutPanel buttonTabelLayoutPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}