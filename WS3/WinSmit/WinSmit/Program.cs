using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinSmit
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
            WSmainNew TheMainForm = new WSmainNew(); 
            //Application.Run(new WSMain());
            Application.Run(TheMainForm);
        }
    }
}