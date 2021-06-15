using System;

namespace InstrumentShop.WinForm
{
    [Serializable()]
    public class Strings : Instrument
    {
        public delegate void LoadStringsFormDelegate(Strings prStrings);
        public static LoadStringsFormDelegate LoadStringsForm;

        private int _NumberOfStrings;

        public override void EditDetails()
        {
            LoadStringsForm(this);
        }

        public int NumberOfStrings
        {
            get { return _NumberOfStrings; }
            set { _NumberOfStrings = value; }
        }
    }
}
