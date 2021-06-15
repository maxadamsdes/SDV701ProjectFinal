using System;
using System.Windows.Forms;

namespace ArtGallery.WinForm
{
    public partial class InstrumentForm : Form
    {
        protected Instrument _instrument;

        public InstrumentForm()
        {
            InitializeComponent();
        }

        public void SetDetails(Instrument instrument)
        {
            _instrument = instrument;
            UpdateForm();
            ShowDialog();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                PushData();
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public virtual bool isValid()
        {
            return true;
        }

        protected virtual void UpdateForm()
        {
            name.Text = _instrument.Name;
            creation.Text = _instrument.Date.ToShortDateString();
            value.Text = _instrument.Value.ToString();
        }

        protected virtual void PushData()
        {
            _instrument.Name = name.Text;
            _instrument.Date = DateTime.Parse(creation.Text);
            _instrument.Value = decimal.Parse(value.Text);
        }
    }
}