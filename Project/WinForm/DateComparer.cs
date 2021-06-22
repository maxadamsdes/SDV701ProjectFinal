using InstrumentShop.Models;
using System.Collections.Generic;

namespace InstrumentShop.WinForm
{
    public class DateComparer : IComparer<InstrumentListitemModel>
    {
        private static readonly DateComparer _instance = new DateComparer();
        public int Compare(InstrumentListitemModel x, InstrumentListitemModel y)
        {
            return x.LastModified.CompareTo(y.LastModified);
        }
        public static DateComparer Instance => _instance;
    }

    
}
