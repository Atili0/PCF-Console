using System;
using System.Windows.Forms;

namespace PCF_CONSOLE
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


            //IActionMain actionMain = new ActionMain();
            frmMain _frmMain = new frmMain();
            IPCFModel mdl = new PCFModel();
            IPCFController crt = new PCFController(_frmMain, mdl);
            _frmMain.SetController(crt);
            Application.Run(_frmMain);
        }
    }
}
