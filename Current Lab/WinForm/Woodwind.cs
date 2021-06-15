using System;

namespace ArtGallery.WinForm
{
    [Serializable()]
    public class Woodwind : Instrument
    {
        private float _weight;
        private string _material;

        public delegate void LoadSculptureFormDelegate(Woodwind prSculpture);
        public static LoadSculptureFormDelegate LoadSculptureForm;

        public override void EditDetails()
        {
           LoadSculptureForm(this);
        }

        public Single Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public string Material
        {
            get { return _material; }
            set { _material = value; }
        }
    }
}
