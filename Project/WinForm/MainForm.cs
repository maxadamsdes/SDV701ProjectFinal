using InstrumentShop.RestApiClient;
using System;
using System.Windows.Forms;
namespace InstrumentShop.WinForm
{
    public sealed partial class MainForm : Form
    {
        private static readonly MainForm _instance = new MainForm();
        private int? categoryID;
        static MainForm()
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private MainForm()
        {
            InitializeComponent();
        }

        public static MainForm Instance
        {
            get { return _instance; }
        }
        
        public async void UpdateDisplay()
        {
            try
            {
                categoryList.DataSource = null;
                categoryList.DataSource = await RestClient.ListCategoryNamesAsync();
                GetTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        private async void GetTotal()
        {
            var _instruments = await RestClient.ListInstrumentsAsync();
            decimal value = 0;
            foreach (var instrument in _instruments)
            {
                value += instrument.PricePerItem * instrument.QuantityLeft;
            }
            valueLabel.Text = value.ToString();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryForm.Run(categoryID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error finding category");
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        

        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryID = categoryList.SelectedIndex + 1;
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.GetOrders();
            orderForm.Show();
            orderForm.Activate();
        }
    }
}