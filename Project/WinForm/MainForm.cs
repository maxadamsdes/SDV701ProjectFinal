using InstrumentShop.RestApiClient;
using System;
using System.Windows.Forms;
namespace InstrumentShop.WinForm
{
    public sealed partial class MainForm : Form
    {
        private static readonly MainForm _instance = new MainForm();
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

            
            //string[] displayList = new string[_categoryList.Count];
            //_categoryList.Keys.CopyTo(displayList, 0);
            //categoryList.DataSource = displayList;
            //laueLabel.Text = Convert.ToString(_categoryList.GetTotalValue());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryForm.Run(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new category");
            }
        }

        private void categoryList_DoubleClick(object sender, EventArgs e)
        {
            var categoryID = (int?)categoryList.CurrentRow.Cells[0].Value;
            if (categoryID != null)
                try
                {
                    CategoryForm.Run(categoryID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //_categoryList.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Save Error");
            }
            Close();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            var categoryID = (int?)categoryList.CurrentRow.Cells[0].Value;
            if (categoryID != null && MessageBox.Show("Are you sure?", "Deleting category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id = (int)categoryID;
                    await RestClient.DeleteCategoryAsync(id);
                    //_categoryList.Remove(key);
                    categoryList.Rows.RemoveAt(id);
                    UpdateDisplay();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleing category");
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                //_categoryList = CategoryList.RetrieveCategoryList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File retrieve error");
            }
            UpdateDisplay();
            //ShopNameChanged += UpdateTitle;
            //GalleryNameChanged(_categoryList.GalleryName);
        }

        private void galleryNameButton_Click(object sender, EventArgs e)
        {
            //_categoryList.GalleryName = new InputBox("Enter Gallery Name").Answer;
            //GalleryNameChanged(_categoryList.GalleryName);
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            InstrumentShop.Models.CategoryModel NewModel = new InstrumentShop.Models.CategoryModel();
            NewModel.Description = "Brass";
            await InstrumentShop.RestApiClient.RestClient.AddCategoryAsync(NewModel);
            NewModel.Description = "Woodwind";
            await InstrumentShop.RestApiClient.RestClient.AddCategoryAsync(NewModel);
            NewModel.Description = "Strings";
            await InstrumentShop.RestApiClient.RestClient.AddCategoryAsync(NewModel);
        }
    }
}