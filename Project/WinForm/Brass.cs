using System;

namespace InstrumentShop.WinForm
{
    [Serializable()]
    public class Brass : Instrument
    {
        private string _manufacturer;

        public delegate void LoadBrassFormDelegate(Brass prBrass);
        public static LoadBrassFormDelegate LoadBrassForm;

        public override void EditDetails()
        {
            LoadBrassForm(this);
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }
    }
}
