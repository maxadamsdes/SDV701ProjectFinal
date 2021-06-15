using System;

namespace InstrumentShop.WinForm
{
    [Serializable()]
    public abstract class Instrument
    {
        private string _name;
        private string _description;
        private string _condition;
        private int _quantity;
        private DateTime _date = DateTime.Now;
        private decimal _value;

        public Instrument()
        {
            EditDetails();
        }

        public static readonly string FACTORY_PROMPT = "Enter P for Painting, S for Sculpture and H for Photograph";

        public static Instrument NewInstrument(char choice)
        {
            switch (char.ToUpper(choice))
            {
                case 'P': return new Brass();
                case 'S': return new Woodwind();
                case 'H': return new Strings();
                default: return null;
            }
        }

        public abstract void EditDetails();

        public override string ToString()
        {
            return _name + "\t" + _date.ToShortDateString();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public decimal Value
        {
            get { return _value; }
            set { _value = value; }
        }


    }
}
