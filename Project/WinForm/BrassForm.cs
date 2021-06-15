namespace InstrumentShop.WinForm
{
    public sealed partial class BrassForm : InstrumentForm
    {
        private static readonly BrassForm _instance = new BrassForm();

        static BrassForm()
        {
        }

        private BrassForm()
        {
            InitializeComponent();
        }

        public static void Run(Brass brass)
        {
            _instance.SetDetails(brass);
        }

        protected override void UpdateForm()
        {
            base.UpdateForm();
            Brass instrument = (Brass)_instrument;
            manufacturerText.Text = instrument.Manufacturer.ToString();
        }

        protected override void PushData()
        {
            base.PushData();
            Brass instrument = (Brass)_instrument;
            instrument.Manufacturer = manufacturerText.Text;
        }
        public static BrassForm Instance => _instance;
    }
}

