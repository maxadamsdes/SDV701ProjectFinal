using System.Collections.Generic;

namespace ArtGallery.WinForm
{
    public class DateComparer : IComparer<Work>
    {
        private static readonly DateComparer _instance = new DateComparer();
        public int Compare(Work x, Work y)
        {
            return x.Date.CompareTo(y.Date);
        }
        public static DateComparer Instance => _instance;
    }

    
}
