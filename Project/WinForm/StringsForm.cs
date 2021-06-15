namespace InstrumentShop.WinForm
{
    public sealed partial class StringsForm : InstrumentForm
    {
        private static readonly StringsForm _instance = new StringsForm();

        static StringsForm()
        {
        }

        private StringsForm()
        {
            InitializeComponent();
        }

        public static void Run(Strings photograph)
        {
            _instance.SetDetails(photograph);
        }

        protected override void UpdateForm()
        {
            base.UpdateForm();
            Strings instrument = (Strings)_instrument;
            stringsText.Text = instrument.NumberOfStrings.ToString();
        }

        protected override void PushData()
        {
            base.PushData();
            Strings instrument = (Strings)_instrument;
            instrument.NumberOfStrings = int.Parse(stringsText.Text);
        }

        public static StringsForm Instance => _instance;
    }
}

