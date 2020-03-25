using System;
using System.Linq;
using System.Windows.Forms;
namespace CTS_beta.Form_CTS
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
//<<<<<<< HEAD
            Application.Run(new frmLogin());
//=======
            if (Properties.Settings.Default.apiKey != "")
                Application.Run(new frmUser());
            else
                Application.Run(new frmLogin());
        }
    }
}