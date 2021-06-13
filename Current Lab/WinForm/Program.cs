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
            Painting.LoadPaintingForm = PaintingForm.Run;
            Photograph.LoadPhotographForm = PhotographForm.Run;
            Sculpture.LoadSculptureForm = SculptureForm.Run;
            Application.Run(MainForm.Instance);
        }
    }
}
