namespace ArtGallery.WinForm
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
            width.Text = instrument.Width.ToString();
            height.Text = instrument.Height.ToString();
            type.Text = instrument.Type;
        }

        protected override void PushData()
        {
            base.PushData();
            Strings instrument = (Strings)_instrument;
            instrument.Width = float.Parse(width.Text);
            instrument.Height = float.Parse(height.Text);
            instrument.Type = type.Text;
        }

        public static StringsForm Instance => _instance;
    }
}

