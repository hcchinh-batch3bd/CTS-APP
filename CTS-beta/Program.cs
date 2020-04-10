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
            if (Properties.Settings.Default.apiKey != "")
                if (Properties.Settings.Default.level)
                    Application.Run(new frmAdmin());
                else
                    Application.Run(new frmUser());
            else
                Application.Run(new frmLogin());
        }
    }
}