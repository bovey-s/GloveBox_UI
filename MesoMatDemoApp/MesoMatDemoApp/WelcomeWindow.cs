using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ivi.Visa;
using Ivi.Visa.FormattedIO;

namespace MesoMatDemoApp
{
    public partial class WelcomeWindow : Form
    {

        private string comPort = "";
        private bool status = false;
        private int LIAin = 0;
        private int LIAout = 1;
        private int Keith = 2;

        public WelcomeWindow()
        {
            InitializeComponent();
            /*IMessageBasedSession session;
            
            try
            {
                session = GlobalResourceManager.Open("GPIB0::3::INSTR") as IMessageBasedSession;
                Console.WriteLine("now we cookin");
                IMessageBasedFormattedIO formattedIO = new MessageBasedFormattedIO(session);

                session.TerminationCharacterEnabled = true;

                //formattedIO.WriteLine("FREQ 1.70");
                formattedIO.DiscardBuffers();
                formattedIO.WriteLine("*IDN?");
                Console.WriteLine(formattedIO.ReadLine());
                Console.WriteLine("^LIA2");
                //formattedIO.WriteLine("MEAS:CURR?"); //CURR for current, VOLT for voltage, RES for R (source must be on for R)
                
                //formattedIO.WriteLine("SOUR:FUNC VOLT");
                //formattedIO.WriteLine("SOUR:VOLT 0.1"); //idk if this works, get connections and see
                //formattedIO.WriteLine("OUTP ON"); //Toggle output on/off
                //formattedIO.WriteLine("SOUR:VOLT 0.2");
                //formattedIO.WriteLine("OUTP OFF"); //Toggle output on/off
                //Console.WriteLine(formattedIO.ReadLine());
                session.Dispose();
            }
            catch (NativeVisaException visaException)
            {
                Console.WriteLine("couldn't connect", visaException);
            }*/
            //comPortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            //comPortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            //comPortComboBox.Text = "Com Port";

        }




        private void connectButton_Click(object sender, EventArgs e)
        {
            IMessageBasedSession session;
            try
            {
                session = GlobalResourceManager.Open("GPIB0::8::INSTR") as IMessageBasedSession;
                Console.WriteLine("now we cookin");
                IMessageBasedFormattedIO formattedIO = new MessageBasedFormattedIO(session);
                
                session.TerminationCharacterEnabled = true;

                formattedIO.WriteLine("FREQ 1.70");
                formattedIO.WriteLine("*IDN?");
                Console.WriteLine(formattedIO.ReadLine());
                session.LockResource();
            }
            catch(NativeVisaException visaException)
            {
                Console.WriteLine("couldn't connect", visaException);
            }
            

           
        }

        public bool GetStatus()
        {
            return this.status;
        }

        public int GetLIAin()
        {
            return this.LIAin;
        }

        public int GetLIAout()
        {
            return this.LIAout;
        }

        public int GetKeith()
        {
            return this.Keith;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WelcomeWindow_Load(object sender, EventArgs e)
        {

        }

        private void Connect_Click(object sender, EventArgs e)
        {
            LIAin = Convert.ToInt32(LIAinUpDown.Value);
            LIAout = Convert.ToInt32(LIAoutUpDown.Value);
            Keith = Convert.ToInt32(KeithUpDown.Value);
            status = true;
            Close();
        }
    }
}
