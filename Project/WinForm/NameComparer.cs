using InstrumentShop.Models;
using System.Collections.Generic;

namespace InstrumentShop.WinForm
{
    public class NameComparer : IComparer<InstrumentModel>
    {
        private static readonly NameComparer _instance = new NameComparer();
        public int Compare(InstrumentModel x, InstrumentModel y)
        {
            string nameX = x.Description;
            string nameY = y.Description;

            return nameX.CompareTo(nameY);
        }
        public static NameComparer Instance => _instance;
    }
}
