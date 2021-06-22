namespace InstrumentShop.WinForm
{
    public sealed partial class BrassForm : InstrumentForm
    {
        private static readonly BrassForm _instance = new BrassForm();

        static BrassForm()
        {
        }

        public BrassForm()
        {
            InitializeComponent();
        }


        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            tuningText.Text = _instrument.Tuning;
        }

        protected override void PushData()
        {
            base.PushData();
            _instrument.Tuning = tuningText.Text;
        }

        public static BrassForm Instance => _instance;
    }
}

