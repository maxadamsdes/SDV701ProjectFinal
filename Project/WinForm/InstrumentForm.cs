using InstrumentShop.Models;
using InstrumentShop.RestApiClient;
using System;
using System.Windows.Forms;

namespace InstrumentShop.WinForm
{
    public partial class InstrumentForm : Form
    {
        protected InstrumentModel _instrument;
        protected InstrumentForm _instrumentForm;
        private bool NewInstrument;
        //protected Instrument _instrument;

        public InstrumentForm()
        {
            InitializeComponent();
        }
       
        public static void Run(int? instrumentID)
        {
            InstrumentForm instrumentForm;
            if (instrumentID.HasValue)
            {
                instrumentForm = new InstrumentForm();
                instrumentForm.GetInstrument(instrumentID);
                instrumentForm.NewInstrument = false;
            }
            else
            {
                instrumentForm = new InstrumentForm();
                switch (CategoryForm.Category.ID)
                {
                    case 1: instrumentForm = new BrassForm(); break;
                    case 2: instrumentForm = new StringsForm(); break;
                    case 3: instrumentForm = new WoodwindForm(); break;
                }
                instrumentForm.NewInstrument = true;
                instrumentForm._instrument = new InstrumentModel();
                instrumentForm._instrument.CategoryID = CategoryForm.Category.ID;
                instrumentForm._instrument.ID = 500;
                instrumentForm.Show();
                instrumentForm.Activate();
            }

        }
        protected virtual void UpdateDisplay()
        {
            descriptionText.Text = _instrument.Description;
            conditionText.Text = _instrument.Condition;
            quantityText.Text = _instrument.QuantityLeft.ToString();
            valueText.Text = _instrument.PricePerItem.ToString();
            lastModified.Value = _instrument.LastModified;
        }

        protected virtual void PushData()
        {
            try
            {
                _instrument.Description = descriptionText.Text;
                _instrument.Condition = conditionText.Text;
                _instrument.QuantityLeft = int.Parse(quantityText.Text);
                _instrument.LastModified = DateTime.Now;
                _instrument.PricePerItem = decimal.Parse(valueText.Text);
            }
            catch
            {
                MessageBox.Show("Some of the data you have entered is incorrect. Please try again", "Alert");
            }
        }
        private async void GetInstrument(int? instrumentID)
        {
            if (instrumentID.HasValue)
            {
                _instrument = await RestClient.GetInstrumentAsync(instrumentID);
                switch (_instrument.CategoryID)
                {
                    case 1: _instrumentForm = new BrassForm(); break;
                    case 2: _instrumentForm = new StringsForm(); break;
                    case 3: _instrumentForm = new WoodwindForm(); break;
                }
                _instrumentForm._instrument = _instrument;
                _instrumentForm.UpdateDisplay();
                _instrumentForm.Show();
                _instrumentForm.Activate();
            }
            else
            {
                MessageBox.Show("Select an instrument from the list", "Alert");
            }


        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                PushData();
                try
                {

                    if (NewInstrument)
                    {
                        await RestClient.AddInstrumentAsync(_instrument);
                        MessageBox.Show("Artist Added!", "Success");
                        MainForm.Instance.UpdateDisplay();
                        NewInstrument = false;
                    }
                    else
                    {
                        await RestClient.UpdateInstrumentAsync(_instrument);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

        

        

        public void AddInstrument(int choice)
        {
            _instrumentForm = new InstrumentForm();
            switch (choice)
            {
                case 1: _instrumentForm = new BrassForm(); break;
                case 2: _instrumentForm = new StringsForm(); break;
                case 3: _instrumentForm = new WoodwindForm(); break;
            }

        }

        

    }
}