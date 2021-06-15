using System;
using System.Windows.Forms;

namespace ArtGallery.WinForm
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
            Brass.LoadPaintingForm = BrassForm.Run;
            Strings.LoadPhotographForm = StringsForm.Run;
            Woodwind.LoadSculptureForm = WoodwindForm.Run;
            Application.Run(MainForm.Instance);
        }
    }
}
