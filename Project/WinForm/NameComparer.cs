using InstrumentShop.Models;
using System.Collections.Generic;

namespace InstrumentShop.WinForm
{
    public class NameComparer : IComparer<InstrumentListitemModel>
    {
        private static readonly NameComparer _instance = new NameComparer();
        public int Compare(InstrumentListitemModel x, InstrumentListitemModel y)
        {
            string nameX = x.Description;
            string nameY = y.Description;

            return nameX.CompareTo(nameY);
        }
        public static NameComparer Instance => _instance;
    }
}
