using System.Collections.Generic;

namespace ArtGallery.WinForm
{
    public class NameComparer : IComparer<Instrument>
    {
        private static readonly NameComparer _instance = new NameComparer();
        public int Compare(Instrument x, Instrument y)
        {
            string nameX = x.Name;
            string nameY = y.Name;

            return nameX.CompareTo(nameY);
        }
        public static NameComparer Instance => _instance;
    }
}
