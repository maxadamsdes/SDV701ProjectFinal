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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
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


        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryID = categoryList.SelectedIndex + 1;
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.GetOrders();
            Console.WriteLine(categoryID.Value);
            orderForm.Show();
            orderForm.Activate();
        }
    }
}