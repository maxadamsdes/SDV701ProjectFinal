using System.Collections.Generic;

namespace ArtGallery.WinForm
{
    public class NameComparer : IComparer<Work>
    {
        private static readonly NameComparer _instance = new NameComparer();
        public int Compare(Work x, Work y)
        {
            string nameX = x.Name;
            string nameY = y.Name;

            return nameX.CompareTo(nameY);
        }
        public static NameComparer Instance => _instance;
    }
}
