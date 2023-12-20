using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesoMatDemoApp
{
    public partial class Dialog : Form
    {
        private bool status = false;
        private readonly bool show_cancel;

        public Dialog(string text, string title, bool show_cancel)
        {
            InitializeComponent();

            Text = title;
            titleText.Text = title;
            contentText.Text = text;
            this.show_cancel = show_cancel;
        }

        public bool GetStatus()
        {
            return status;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            status = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dialog_Load(object sender, EventArgs e)
        {
            if (show_cancel)
            {
                buttonTabelLayoutPanel.ColumnCount = 4;
                buttonTabelLayoutPanel.ColumnStyles.Clear();
                buttonTabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                buttonTabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
                buttonTabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
                buttonTabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                buttonTabelLayoutPanel.Controls.Add(okButton, 1, 0);
                buttonTabelLayoutPanel.Controls.Add(cancelButton, 2, 0);

                cancelButton.TabIndex = 1;
                okButton.TabIndex = 2;
            }
            else
            {
                buttonTabelLayoutPanel.ColumnCount = 3;
                buttonTabelLayoutPanel.ColumnStyles.Clear();
                buttonTabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                buttonTabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
                buttonTabelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                buttonTabelLayoutPanel.Controls.Add(okButton, 1, 0);
            }
        }
    }
}
