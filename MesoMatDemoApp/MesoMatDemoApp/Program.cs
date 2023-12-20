using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesoMatDemoApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Console.WriteLine("hello?");

            WelcomeWindow welcomeWindow = new WelcomeWindow();
            welcomeWindow.ShowDialog();

            if (welcomeWindow.GetStatus())
            {
                int LIAin = welcomeWindow.GetLIAin();
                int LIAout =welcomeWindow.GetLIAout();
                int Keith = welcomeWindow.GetKeith();


                Application.Run(new MainWindow("COM5",LIAin,LIAout,Keith));

            }

            //Application.Run(new SpeedTest());
        }
    }
}
