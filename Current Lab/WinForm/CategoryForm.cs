using ArtGallery.Models;
using ArtGallery.RestApiClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ArtGallery.WinForm
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private CategoryModel _category;
        private InstrumentList _instrumentList;
        private static Dictionary<int?, CategoryForm> _categoryFormList = new Dictionary<int?, CategoryForm>();

        private void UpdateTitle(string galleryName)
        {
            if (!string.IsNullOrEmpty(galleryName))
                Text = "Category Detials - " + galleryName;
        }

        private void UpdateDisplay()
        {
            if (_instrumentList.SortOrder == 0)
            {
                _instrumentList.SortByName();
                byName.Checked = true;
            }
            else
            {
                _instrumentList.SortByDate();
                byDate.Checked = true;
            }

            instrumentList.DataSource = _category.Instruments;
            instrumentList.DataSource = _instrumentList;
            totalLabel.Text = Convert.ToString(_instrumentList.GetTotalValue());
            MainForm.Instance.UpdateDisplay();
        }

        public void SetDetails(CategoryModel category)
        {
            _category = category;
            name.Enabled = string.IsNullOrEmpty(_category.Name);
            UpdateForm();
            UpdateDisplay();
            MainForm.Instance.GalleryNameChanged += new MainForm.Notify(UpdateTitle);
            //UpdateTitle(_category.CategoryList.GalleryName);
            Show();
            
        }

        private void UpdateForm()
        {
            name.Text = _category.Name;
            speciality.Text = _category.Speciality;
            phone.Text = _category.Phone;
            //_instrumentList = _category.InstrumentList;
        }

        private void PushData()
        {
            _category.Name = name.Text;
            _category.Speciality = speciality.Text;
            _category.Phone = phone.Text;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = instrumentList.SelectedIndex;

            if (index >= 0 && MessageBox.Show("Are you sure?", "Deleting instrument", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _instrumentList.RemoveAt(index);
                UpdateDisplay();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string reply = new InputBox(Instrument.FACTORY_PROMPT).Answer;
            if (!string.IsNullOrEmpty(reply))
            {
                _instrumentList.AddInstrument(reply[0]);
                UpdateDisplay();
            }
        }

        private async void closeButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                PushData();
                try
                {

                    if (name.Enabled)
                    {
                        await RestClient.AddCategoryAsync(_category);
                        MessageBox.Show("Category Added!", "Success");
                        MainForm.Instance.UpdateDisplay();
                        name.Enabled = false;
                    }
                    else
                    {
                        await RestClient.UpdateCategoryAsync(_category);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Hide();
            }
        }

        private Boolean IsValid()
        {
            if (name.Enabled && name.Text != "")
            {
                return true;
            }
            else if (name.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void instrumentList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                _instrumentList.EditInstrument(instrumentList.SelectedIndex);
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void byDate_CheckedChanged(object sender, EventArgs e)
        {
            _instrumentList.SortOrder = Convert.ToByte(byDate.Checked);
            UpdateDisplay();
        }

        public static void Run(int? categoryID)
        {
            CategoryForm categoryForm;
            if(!categoryID.HasValue) //adds category
            {
                categoryForm = new CategoryForm();
                categoryForm.SetDetails(new CategoryModel());
            }
            if (!_categoryFormList.ContainsKey(categoryID.Value)) //category is cached
            {
                categoryForm = _categoryFormList[categoryID.Value];
                
            }
            else
            {
                categoryForm = new CategoryForm();
                _categoryFormList.Add(categoryID.Value, categoryForm);
                categoryForm.GetCategory(categoryID.Value);
            }
            categoryForm.Show();
            categoryForm.Activate();
        }

        private async void GetCategory(int categoryID)
        {
            SetDetails(await RestClient.GetCategoryAsync(categoryID));
        }
    }
}