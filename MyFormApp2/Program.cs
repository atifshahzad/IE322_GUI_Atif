using System;
using System.Windows.Forms;



namespace IE322_App_KAU
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
            frmMain a = new frmMain();
            Application.Run(a);
            // a.Show();
            // Application.Run(new GUIApp_EA());
        }
    }
}
