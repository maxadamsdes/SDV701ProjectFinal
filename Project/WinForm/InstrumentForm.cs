using System;
using System.Windows.Forms;

namespace InstrumentShop.WinForm
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

        private void editButton_Click(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
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
            nameText.Text = _instrument.Name;
            descriptionText.Text = _instrument.Description;
            lastModifiedText.Text = _instrument.Date.ToShortDateString();
            valueText.Text = _instrument.Value.ToString();
        }

        protected virtual void PushData()
        {
            _instrument.Name = nameText.Text;
            _instrument.Date = DateTime.Parse(lastModifiedText.Text);
            _instrument.Value = decimal.Parse(valueText.Text);
        }

        
    }
}