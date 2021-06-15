namespace ArtGallery.WinForm
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
            txtWeight.Text = instrument.Weight.ToString();
            txtMaterial.Text = instrument.Material;
        }

        protected override void PushData()
        {
            base.PushData();
            Woodwind instrument = (Woodwind)_instrument;
            instrument.Weight = float.Parse(txtWeight.Text);
            instrument.Material = txtMaterial.Text;
        }

        public static WoodwindForm Instance => _instance;
    }
}

