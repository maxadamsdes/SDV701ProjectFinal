using ArtGallery.Models;
using ArtGallery.RestApiClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ArtGallery.WinForm
{
    public partial class ArtistForm : Form
    {
        public ArtistForm()
        {
            InitializeComponent();
        }

        private ArtistModel _artist;
        private WorkList _workList;
        private static Dictionary<int?, ArtistForm> _artistFormList = new Dictionary<int?, ArtistForm>();

        private void UpdateTitle(string galleryName)
        {
            if (!string.IsNullOrEmpty(galleryName))
                Text = "Artist Detials - " + galleryName;
        }

        private void UpdateDisplay()
        {
            if (_workList.SortOrder == 0)
            {
                _workList.SortByName();
                byName.Checked = true;
            }
            else
            {
                _workList.SortByDate();
                byDate.Checked = true;
            }

            workList.DataSource = _artist.Works;
            workList.DataSource = _workList;
            totalLabel.Text = Convert.ToString(_workList.GetTotalValue());
            MainForm.Instance.UpdateDisplay();
        }

        public void SetDetails(ArtistModel artist)
        {
            _artist = artist;
            name.Enabled = string.IsNullOrEmpty(_artist.Name);
            UpdateForm();
            UpdateDisplay();
            MainForm.Instance.GalleryNameChanged += new MainForm.Notify(UpdateTitle);
            //UpdateTitle(_artist.ArtistList.GalleryName);
            Show();
            
        }

        private void UpdateForm()
        {
            name.Text = _artist.Name;
            speciality.Text = _artist.Speciality;
            phone.Text = _artist.Phone;
            //_workList = _artist.WorkList;
        }

        private void PushData()
        {
            _artist.Name = name.Text;
            _artist.Speciality = speciality.Text;
            _artist.Phone = phone.Text;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = workList.SelectedIndex;

            if (index >= 0 && MessageBox.Show("Are you sure?", "Deleting work", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _workList.RemoveAt(index);
                UpdateDisplay();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string reply = new InputBox(Work.FACTORY_PROMPT).Answer;
            if (!string.IsNullOrEmpty(reply))
            {
                _workList.AddWork(reply[0]);
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
                        await RestClient.AddArtistAsync(_artist);
                        MessageBox.Show("Artist Added!", "Success");
                        MainForm.Instance.UpdateDisplay();
                        name.Enabled = false;
                    }
                    else
                    {
                        await RestClient.UpdateArtistAsync(_artist);
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

        private void workList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                _workList.EditWork(workList.SelectedIndex);
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void byDate_CheckedChanged(object sender, EventArgs e)
        {
            _workList.SortOrder = Convert.ToByte(byDate.Checked);
            UpdateDisplay();
        }

        public static void Run(int? artistID)
        {
            ArtistForm artistForm;
            if(!artistID.HasValue) //adds artist
            {
                artistForm = new ArtistForm();
                artistForm.SetDetails(new ArtistModel());
            }
            if (!_artistFormList.ContainsKey(artistID.Value)) //artist is cached
            {
                artistForm = _artistFormList[artistID.Value];
                
            }
            else
            {
                artistForm = new ArtistForm();
                _artistFormList.Add(artistID.Value, artistForm);
                artistForm.GetArtist(artistID.Value);
            }
            artistForm.Show();
            artistForm.Activate();
        }

        private async void GetArtist(int artistID)
        {
            SetDetails(await RestClient.GetArtistAsync(artistID));
        }
    }
}