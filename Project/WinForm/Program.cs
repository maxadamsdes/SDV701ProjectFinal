using System;
using System.Windows.Forms;

namespace InstrumentShop.WinForm
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
            Brass.LoadBrassForm = BrassForm.Run;
            Strings.LoadStringsForm = StringsForm.Run;
            Woodwind.LoadWoodwindForm = WoodwindForm.Run;
            Application.Run(MainForm.Instance);
        }
    }
}
