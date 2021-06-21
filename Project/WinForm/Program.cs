using InstrumentShop.Models;
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
            //InstrumentModel.LoadBrassForm = BrassForm.Run;
            //InstrumentModel.Strings.LoadStringsForm = StringsForm.Run;
            //InstrumentModel.Woodwind.LoadWoodwindForm = WoodwindForm.Run;
            Application.Run(MainForm.Instance);
        }
    }
}
