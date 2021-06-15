using System.Collections.Generic;

namespace ArtGallery.WinForm
{
    public class DateComparer : IComparer<Instrument>
    {
        private static readonly DateComparer _instance = new DateComparer();
        public int Compare(Instrument x, Instrument y)
        {
            return x.Date.CompareTo(y.Date);
        }
        public static DateComparer Instance => _instance;
    }

    
}
