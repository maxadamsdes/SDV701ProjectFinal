using System;

namespace ArtGallery.WinForm
{
    [Serializable()]
    public class Strings : Instrument
    {
        public delegate void LoadPhotographFormDelegate(Strings prPhotograph);
        public static LoadPhotographFormDelegate LoadPhotographForm;

        private float _Width;
        private float _Height;
        private string _Type;


        public override void EditDetails()
        {
            LoadPhotographForm(this);
        }

        public Single Width
        {
            get { return _Width; }
            set { _Width = value; }
        }

        public Single Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
    }
}
