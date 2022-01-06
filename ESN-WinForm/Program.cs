using ESN_WinForm.Forms;
using ESN_WinForm.Helpers;
using ESN_WinForm.Services;
using System;
using System.Windows.Forms;

namespace ESN_WinForm
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
            Application.Run(new UsersForm());
        }
    }
}
