namespace InstrumentShop.WinForm
{
    public sealed partial class WoodwindForm : InstrumentForm
    {
        private static readonly WoodwindForm _instance = new WoodwindForm();

        static WoodwindForm()
        {
        }

        private WoodwindForm()
        {
            InitializeComponent();
        }

        public static void Run(Woodwind woodwind)
        {
            _instance.SetDetails(woodwind);
        }

        protected override void UpdateForm()
        {
            base.UpdateForm();
            Woodwind instrument = (Woodwind)_instrument;
            reedText.Text = instrument.Reed.ToString();
        }

        protected override void PushData()
        {
            base.PushData();
            Woodwind instrument = (Woodwind)_instrument;
            instrument.Reed = reedText.Text;
        }

        public static WoodwindForm Instance => _instance;
    }
}

