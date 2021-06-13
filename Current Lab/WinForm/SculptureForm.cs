namespace ArtGallery.WinForm
{
    public sealed partial class SculptureForm : WorkForm
    {
        private static readonly SculptureForm _instance = new SculptureForm();

        static SculptureForm()
        {
        }

        private SculptureForm()
        {
            InitializeComponent();
        }

        public static void Run(Sculpture sculpture)
        {
            _instance.SetDetails(sculpture);
        }

        protected override void UpdateForm()
        {
            base.UpdateForm();
            Sculpture work = (Sculpture)_work;
            txtWeight.Text = work.Weight.ToString();
            txtMaterial.Text = work.Material;
        }

        protected override void PushData()
        {
            base.PushData();
            Sculpture work = (Sculpture)_work;
            work.Weight = float.Parse(txtWeight.Text);
            work.Material = txtMaterial.Text;
        }

        public static SculptureForm Instance => _instance;
    }
}

