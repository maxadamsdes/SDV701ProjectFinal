using System;

namespace InstrumentShop.WinForm
{
    [Serializable()]
    public class Woodwind : Instrument
    {
        private string _reed;

        public delegate void LoadWoodwindFormDelegate(Woodwind prSculpture);
        public static LoadWoodwindFormDelegate LoadWoodwindForm;

        public override void EditDetails()
        {
            LoadWoodwindForm(this);
        }

        public string Reed
        {
            get { return _reed; }
            set { _reed = value; }
        }
    }
}
