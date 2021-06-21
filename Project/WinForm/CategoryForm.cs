using InstrumentShop.Models;
using InstrumentShop.RestApiClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InstrumentShop.WinForm
{
    public partial class CategoryForm : Form
    {
        private static CategoryModel _category;
        private int? instrumentID;

        public static CategoryModel Category { get => _category; set => _category = value; }

        public CategoryForm()
        {
            InitializeComponent();
        }


        private void UpdateDisplay()
        {
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
            //instrumentList.DataSource = _instrumentList;
            //if (_instrumentList != null)
            //{
            //    totalLabel.Text = Convert.ToString(_instrumentList.GetTotalValue());
            //}
            MainForm.Instance.UpdateDisplay();
        }

        public void SetDetails(CategoryModel category)
        {
            Category = category;
            name.Enabled = string.IsNullOrEmpty(Category.Description);
            UpdateForm();
            UpdateDisplay();
            Show();
        }

        private void UpdateForm()
        {
            name.Text = Category.Description;
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = (int)instrumentList.CurrentRow.Cells[0].Value;

            if (index >= 0 && MessageBox.Show("Are you sure?", "Deleting instrument", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //_instrumentList.RemoveAt(index);
                UpdateDisplay();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                InstrumentForm.Run(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error finding category");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
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

        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                InstrumentForm.Run(instrumentID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error finding category");
            }
        }

        private void instrumentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                instrumentID = Convert.ToInt32(instrumentList.Rows[e.RowIndex].Cells["Id"].Value);
                Console.WriteLine(instrumentID);
            }
        }
    }
}