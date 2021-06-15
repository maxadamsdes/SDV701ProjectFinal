namespace ArtGallery.WinForm
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
            width.Text = instrument.Width.ToString();
            height.Text = instrument.Height.ToString();
            type.Text = instrument.Type;
        }

        protected override void PushData()
        {
            base.PushData();
            Brass instrument = (Brass)_instrument;
            instrument.Width = float.Parse(width.Text);
            instrument.Height = float.Parse(height.Text);
            instrument.Type = type.Text;
        }
        public static BrassForm Instance => _instance;
    }
}

