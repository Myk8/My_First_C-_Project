using Org.BouncyCastle.Asn1.X509;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace p2_Database
{
    public partial class Form1 : Form
    {


        BindingSource albumBindingSource = new BindingSource(); //abillity to conect all items
        BindingSource tracksBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;// Stops texting inside
      

        }

        //PART 1 LOAD DATABASE
        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //connect the list to the grid wiew control

            albums = albumsDAO.getAllAbums();

            albumBindingSource.DataSource = albums;

            dataGridView1.DataSource = albumBindingSource;


            
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            txt_album.Text = "";
            txt_albumArtist.Text = "";
            txt_albumImageURL.Text = "";
            txt_albumYear.Text = "";
            txt_description.Text = "";
            label7.Text = "AlbumId";

            txt_trackTitle.Text = "";
            txt_trackNumber.Text = "";
            txt_trackVideo.Text = "";
            txt_trackLyrics.Text = "";
            label8.Text = "TrackID";


            textBox1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;

            txt_album.Enabled = true;
            txt_albumArtist.Enabled = true;
            txt_albumYear.Enabled = true;
            txt_albumImageURL.Enabled = true;
            txt_description.Enabled = true;
        }

        //PART 2 SEARCH the "album names" what im looking for
        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //connect the list to the grid wiew control
            albumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);

            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //part 3
            DataGridView dataGridView = (DataGridView)sender;

            Album selectedAlbum = (Album)albumBindingSource.Current; //fixed
            //get the row number clicked
            int rowClicked = dataGridView.CurrentRow.Index;
            // MessageBox.Show("You clicked row " + rowClicked);//folyt

            var imageURL = selectedAlbum.ImageURL;

            //   MessageBox.Show("URL=" + imageURL);

            pictureBox1.Load(imageURL);




            tracksBindingSource.DataSource = albums[rowClicked].Tracks;

            dataGridView2.DataSource = tracksBindingSource;


            button4.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;

            txt_trackTitle.Enabled = true;
            txt_trackNumber.Enabled = true;
            txt_trackVideo.Enabled = true;
            txt_trackLyrics.Enabled = true;



            int rowClickedId = dataGridView1.CurrentRow.Index;
            Album editME = albums[rowClickedId];
            label7.Text = editME.ID.ToString();
            PopulateAlbumComboBox();
            txt_trackLyrics.Multiline = true;
        }



        private void button3_Click(object sender, EventArgs e)
        {


            //4 add new item to the database
            Album album = new Album
            {
                AlbumName = txt_album.Text,
                ArtistName = txt_albumArtist.Text,
                Year = Int32.Parse(txt_albumYear.Text),
                ImageURL = txt_albumImageURL.Text,
                Description = txt_description.Text
            };


            AlbumsDAO albumsDAO = new AlbumsDAO();
            //UPDATE THE ITEM
            if (checkBox1.Checked)
            {
                int albumID = Int32.Parse(label7.Text);
                int result = albumsDAO.updateAlbum(album, albumID);
                MessageBox.Show(result + " row(s) updated");

            }
            //ADD NEW ITEM
            else
            {
                int result = albumsDAO.addOneAlbum(album);
                MessageBox.Show(result + "new row(s) inserted");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView2.CurrentRow.Index;
            MessageBox.Show("You clicked row " + rowClicked);
            int TrackID = (int)dataGridView2.Rows[rowClicked].Cells[0].Value;
            MessageBox.Show("ID of track " + TrackID);

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.deleteTrack(TrackID);

            MessageBox.Show("Result" + result);

            dataGridView2.DataSource = null;
            albums = albumsDAO.getAllAbums();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            // Get the index of the selected row
            int rowClicked = dataGridView1.CurrentRow.Index;

            Album editME = albums[rowClicked];
            txt_album.Text = editME.AlbumName;
            txt_albumArtist.Text = editME.ArtistName;
            txt_albumYear.Text = editME.Year.ToString();
            txt_albumImageURL.Text = editME.ImageURL;
            txt_description.Text = editME.Description;


            checkBox1.Checked = true;
            label7.Text = editME.ID.ToString();
            //  Chossen_ID = Convert.ToInt32(selectedRow.Cells[0].Value);




        }

        private void button6_Click(object sender, EventArgs e)
        {
            int albumSelectedIndex = dataGridView1.CurrentRow.Index;
            int trackSelectedIndex = dataGridView2.CurrentRow.Index;

            Track selectedTrack = albums[albumSelectedIndex].Tracks[trackSelectedIndex];

            // Set track details in textboxes
            txt_trackTitle.Text = selectedTrack.Name;
            txt_trackNumber.Text = selectedTrack.Number.ToString();
            txt_trackVideo.Text = selectedTrack.videoURL;
            txt_trackLyrics.Text = selectedTrack.Lyrics;


            // Set track ID in label
            label8.Text = selectedTrack.Id.ToString();

            checkBox2.Checked = true;

            txt_trackLyrics.Multiline = true;
            PopulateAlbumComboBox();
        }

        private void PopulateAlbumComboBox()
        {
            HashSet<string> uniqueCombinations = new HashSet<string>();
            comboBox1.Items.Clear();

            foreach (Album album in albums)
            {
                string displayText = $"{album.ID} {album.AlbumName}";

                if (uniqueCombinations.Add(displayText))
                {
                    comboBox1.Items.Add(displayText);
                }
            }

            // Select the current album in the combo box
            int currentAlbumID = Convert.ToInt32(label7.Text);
            comboBox1.SelectedItem = $"{currentAlbumID} {albums.FirstOrDefault(a => a.ID == currentAlbumID)?.AlbumName}";
        }


        private void button7_Click(object sender, EventArgs e)
        {
            // Read input values
            string trackTitle = txt_trackTitle.Text;
            int trackNumber = Int32.Parse(txt_trackNumber.Text);
            string videoURL = txt_trackVideo.Text;
            string lyrics = txt_trackLyrics.Text;

            // Read selected album from ComboBox
            string? selectedAlbumText = comboBox1.SelectedItem?.ToString();

            if (selectedAlbumText != null)
            {
                int albumID = Int32.Parse(selectedAlbumText.Split(' ')[0]);

                Track newTrack = new Track
                {
                    Name = trackTitle,
                    Number = trackNumber,
                    videoURL = videoURL,
                    Lyrics = lyrics,
                    album_ID = albumID
                };

                AlbumsDAO albumsDAO = new AlbumsDAO();

                // Update or add the track based on the checkbox
                if (checkBox2.Checked)
                {
                    int trackID = Int32.Parse(label8.Text);
                    int result = albumsDAO.UpdateTrack(newTrack, trackID);
                    MessageBox.Show(result + " row(s) updated");
                }
                else
                {
                    int result = albumsDAO.AddTrack(newTrack, albumID);
                    MessageBox.Show(result + " new row(s) inserted");
                }
            }
            else
            {
                // Handle the case where no item is selected in the combo box
                MessageBox.Show("Please select an album from the combo box.");
            }


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Testing
            int rowClicked = dataGridView2.CurrentRow.Index;

            if (rowClicked >= 0)
            {
                string videoURL = dataGridView2.Rows[rowClicked].Cells["videoURL"].Value.ToString();

                // Now, you have the video URL. You can play the video using your preferred video player.
                PlayVideo(videoURL);

            }
           
        }

        //Testing
        private void PlayVideo(string videoURL)
        {

            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = videoURL,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Handle the exception (log it, display an error message, etc.)
                Console.WriteLine("Error opening video: " + ex.Message);
            }
        }
    }
}