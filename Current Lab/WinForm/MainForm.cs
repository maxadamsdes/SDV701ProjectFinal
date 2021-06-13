using ArtGallery.RestApiClient;
using System;
using System.Windows.Forms;
namespace ArtGallery.WinForm
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

        //private ArtistList _artistList = new ArtistList();
        public delegate void Notify(string galleryName);
        public event Notify GalleryNameChanged;

        private void UpdateTitle(string galleryName)
        {
            if (!string.IsNullOrEmpty(galleryName))
                Text = "Gallery - " + galleryName;
        }
        
        public async void UpdateDisplay()
        {
            try
            {
                artistList.DataSource = null;
                artistList.ValueMember = "ID";
                artistList.DisplayMember = "Name";
                artistList.DataSource = await RestClient.ListArtistNamesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }

            
            //string[] displayList = new string[_artistList.Count];
            //_artistList.Keys.CopyTo(displayList, 0);
            //artistList.DataSource = displayList;
            //laueLabel.Text = Convert.ToString(_artistList.GetTotalValue());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                ArtistForm.Run(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new artist");
            }
        }

        private void artistList_DoubleClick(object sender, EventArgs e)
        {
            var artistID = (int?)artistList.SelectedItem;
            if (artistID != null)
                try
                {
                    ArtistForm.Run(artistID);
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
                //_artistList.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Save Error");
            }
            Close();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            var artistID = (int?)artistList.SelectedValue;
            if (artistID != null && MessageBox.Show("Are you sure?", "Deleting artist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id = (int)artistList.SelectedValue;
                    await RestClient.DeleteArtistAsync(id);
                    //_artistList.Remove(key);
                    artistList.ClearSelected();
                    UpdateDisplay();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleing artist");
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                //_artistList = ArtistList.RetrieveArtistList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File retrieve error");
            }
            UpdateDisplay();
            GalleryNameChanged += UpdateTitle;
            //GalleryNameChanged(_artistList.GalleryName);
        }

        private void galleryNameButton_Click(object sender, EventArgs e)
        {
            //_artistList.GalleryName = new InputBox("Enter Gallery Name").Answer;
            //GalleryNameChanged(_artistList.GalleryName);
        }


    }
}