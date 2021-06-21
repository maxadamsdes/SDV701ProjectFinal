using InstrumentShop.Models;
using System;
using System.Collections.Generic;

namespace InstrumentShop.WinForm
{
    [Serializable()]
    public class InstrumentList : List<InstrumentModel>
    {
        private byte _sortOrder;

        public void AddInstrument(int choice)
        {
            InstrumentModel instrument = new InstrumentModel();

            if (instrument != null)
            {
                Add(instrument);
            }
        }

        public void EditInstrument(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                InstrumentModel instrument = this[index];
                //instrument.EditDetails();
            }
            else
            {
                throw new Exception("Sorry no instrument selected #" + Convert.ToString(index));
            }
        }

        public decimal GetTotalValue()
        {
            decimal total = 0;
            //foreach (InstrumentModel instrument in this)
            //{
            //    total += instrument.PricePerItem;
            //}
            return total;
        }

        //public void SortByName()
        //{
        //    Sort(NameComparer.Instance);
        //    _sortOrder = 0;
        //}

        //public void SortByDate()
        //{
        //    Sort(DateComparer.Instance);
        //    _sortOrder = 1;
        //}

        public byte SortOrder
        {
            get { return _sortOrder; }
            set { _sortOrder = value; }
        }

    }
}
