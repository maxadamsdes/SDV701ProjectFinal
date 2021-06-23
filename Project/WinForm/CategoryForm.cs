using InstrumentShop.Models;
using InstrumentShop.RestApiClient;
using System;
using System.Windows.Forms;

namespace InstrumentShop.WinForm
{
    public partial class CategoryForm : Form
    {
        private static CategoryModel _category;
        private int? instrumentID;
        private string instrumentName;

        public static CategoryModel Category { get => _category; set => _category = value; }

        public CategoryForm()
        {
            InitializeComponent();
            if (Category != null)
            {
                UpdateDisplay();
            }
            
        }
        
        public async void UpdateDisplay()
        {
            Category = await RestClient.GetCategoryAsync(Category.ID);
            instrumentList.DataSource = Category.Instruments;
            if (Category.ID == 1)
            {
                instrumentList.Columns["NumberOfStrings"].Visible = false;
                instrumentList.Columns["Mouthpiece"].Visible = false;
            }
            else if (Category.ID == 2)
            {
                instrumentList.Columns["Tuning"].Visible = false;
                instrumentList.Columns["Mouthpiece"].Visible = false;
            }
            else if (Category.ID == 3)
            {
                instrumentList.Columns["NumberOfStrings"].Visible = false;
                instrumentList.Columns["Tuning"].Visible = false;
            }
            MainForm.Instance.UpdateDisplay();
        }

        public void SetDetails(CategoryModel category)
        {
            Category = category;
            name.Enabled = string.IsNullOrEmpty(Category.Description);
            totalLabel.Text = GetTotal(category).ToString();
            UpdateForm();
            UpdateDisplay();
            Show();
        }

        private void UpdateForm()
        {
            name.Text = Category.Description;
        }

        private decimal GetTotal(CategoryModel category)
        {
            decimal value = 0;
            foreach(InstrumentModel instrument in category.Instruments)
            {
                value += instrument.PricePerItem * instrument.QuantityLeft;
            }
            return value;
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Would you like to remove {instrumentName}", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int ID = Convert.ToInt32(instrumentID);
                await RestClient.DeleteInstrumentAsync(ID);
                UpdateDisplay();
            }
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                InstrumentForm.Run(null);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error finding category");
            }
        }
        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                InstrumentForm.Run(instrumentID);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error finding category");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.Update();
            MainForm.Instance.Show();
            Close();
        }

        private void byDate_CheckedChanged(object sender, EventArgs e)
        {
            //instrumentList.SortOrder = Convert.ToByte(byDate.Checked);
            UpdateDisplay();
        }

        public static void Run(int? categoryID)
        {
            CategoryForm categoryForm;
            categoryForm = new CategoryForm();
            categoryForm.GetCategory(categoryID.Value);
            Console.WriteLine(categoryID.Value);
            categoryForm.Show();
            categoryForm.Activate();
        }

        private async void GetCategory(int categoryID)
        {
            SetDetails(await RestClient.GetCategoryAsync(categoryID));
        }

        private void instrumentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                instrumentID = Convert.ToInt32(instrumentList.Rows[e.RowIndex].Cells["Id"].Value);
                instrumentName = instrumentList.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                Console.WriteLine(instrumentID);
            }
        }
    }
}