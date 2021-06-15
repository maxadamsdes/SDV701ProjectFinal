using System;
using System.Collections.Generic;

namespace InstrumentShop.WinForm
{
    [Serializable()]
    public class InstrumentList : List<Instrument>
    {
        private byte _sortOrder;

        public void AddInstrument(char choice)
        {
            Instrument instrument = Instrument.NewInstrument(choice);
            if (instrument != null)
            {
                Add(instrument);
            }
        }

        public void EditInstrument(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                Instrument instrument = this[index];
                instrument.EditDetails();
            }
            else
            {
                throw new Exception("Sorry no instrument selected #" + Convert.ToString(index));
            }
        }

        public decimal GetTotalValue()
        {
            decimal total = 0;
            foreach (Instrument instrument in this)
            {
                total += instrument.Value;
            }
            return total;
        }

        public void SortByName()
        {
            Sort(NameComparer.Instance);
            _sortOrder = 0;
        }

        public void SortByDate()
        {
            Sort(DateComparer.Instance);
            _sortOrder = 1;
        }

        public byte SortOrder
        {
            get { return _sortOrder; }
            set { _sortOrder = value; }
        }

    }
}
