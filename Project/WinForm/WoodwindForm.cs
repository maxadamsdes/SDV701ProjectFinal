using InstrumentShop.Models;

namespace InstrumentShop.WinForm
{
    public sealed partial class WoodwindForm : InstrumentForm
    {
        private static readonly WoodwindForm _instance = new WoodwindForm();

        static WoodwindForm()
        {
        }

        public WoodwindForm()
        {
            InitializeComponent();
        }

        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            mouthpieceText.Text = _instrument.Mouthpiece.ToString();
        }

        protected override void PushData()
        {
            base.PushData();
            _instrument.Mouthpiece = mouthpieceText.Text;
        }

        public static WoodwindForm Instance => _instance;
    }
}

