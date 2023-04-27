using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAndroid
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            appli zz = new appli();
            Login lg = new Login();
            Application.Run(lg);
            if (lg.loginOK)
                {
                    zz.islogout = false;
                    Application.Run(zz);
                }
                if (zz.islogout)
                {
                    lg.loginOK = false;
                    Application.Run(lg);
                }
            
        }
    }
}
