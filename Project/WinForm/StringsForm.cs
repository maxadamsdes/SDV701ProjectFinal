using InstrumentShop.Models;

namespace InstrumentShop.WinForm
{
    public sealed partial class StringsForm : InstrumentForm
    {
        private static readonly StringsForm _instance = new StringsForm();

        static StringsForm()
        {
        }

        public StringsForm()
        {
            InitializeComponent();
        }

        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            stringsText.Text = _instrument.NumberOfStrings.ToString();
        }

        protected override void PushData()
        {
            base.PushData();            
            _instrument.NumberOfStrings = int.Parse(stringsText.Text);
        }

        public static StringsForm Instance => _instance;
    }
}

