namespace p2_Database
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            checkBox1 = new CheckBox();
            button3 = new Button();
            txt_description = new TextBox();
            txt_albumImageURL = new TextBox();
            txt_albumYear = new TextBox();
            txt_albumArtist = new TextBox();
            txt_album = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            checkBox2 = new CheckBox();
            button7 = new Button();
            txt_trackLyrics = new TextBox();
            txt_trackVideo = new TextBox();
            txt_trackNumber = new TextBox();
            txt_trackTitle = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(323, 13);
            button1.Name = "button1";
            button1.Size = new Size(126, 29);
            button1.TabIndex = 0;
            button1.Text = "Load Albums";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(323, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(804, 198);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(851, 13);
            button2.Name = "button2";
            button2.Size = new Size(94, 27);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(489, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(352, 27);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1133, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(txt_albumImageURL);
            groupBox1.Controls.Add(txt_albumYear);
            groupBox1.Controls.Add(txt_albumArtist);
            groupBox1.Controls.Add(txt_album);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 329);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(201, 278);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 12;
            label7.Text = "AlbumId";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(133, 277);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(57, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "edit";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(18, 274);
            button3.Name = "button3";
            button3.Size = new Size(102, 29);
            button3.TabIndex = 10;
            button3.Text = "Add/Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_description
            // 
            txt_description.Enabled = false;
            txt_description.Location = new Point(142, 228);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(125, 27);
            txt_description.TabIndex = 9;
            // 
            // txt_albumImageURL
            // 
            txt_albumImageURL.Enabled = false;
            txt_albumImageURL.Location = new Point(142, 181);
            txt_albumImageURL.Name = "txt_albumImageURL";
            txt_albumImageURL.Size = new Size(125, 27);
            txt_albumImageURL.TabIndex = 8;
            // 
            // txt_albumYear
            // 
            txt_albumYear.Enabled = false;
            txt_albumYear.Location = new Point(142, 134);
            txt_albumYear.Name = "txt_albumYear";
            txt_albumYear.Size = new Size(125, 27);
            txt_albumYear.TabIndex = 7;
            // 
            // txt_albumArtist
            // 
            txt_albumArtist.Enabled = false;
            txt_albumArtist.Location = new Point(142, 88);
            txt_albumArtist.Name = "txt_albumArtist";
            txt_albumArtist.Size = new Size(125, 27);
            txt_albumArtist.TabIndex = 6;
            // 
            // txt_album
            // 
            txt_album.Enabled = false;
            txt_album.Location = new Point(142, 52);
            txt_album.Name = "txt_album";
            txt_album.Size = new Size(125, 27);
            txt_album.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 228);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 181);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "ImageURL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 134);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 88);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 55);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Album Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(323, 289);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 6;
            label6.Text = "Tracks:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(323, 322);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(804, 188);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(381, 287);
            button4.Name = "button4";
            button4.Size = new Size(199, 29);
            button4.TabIndex = 8;
            button4.Text = "Deleted_Selected_Track";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(965, 11);
            button5.Name = "button5";
            button5.Size = new Size(162, 29);
            button5.TabIndex = 9;
            button5.Text = "Edit Selected Album";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(595, 290);
            button6.Name = "button6";
            button6.Size = new Size(162, 26);
            button6.TabIndex = 10;
            button6.Text = "Edit Selected Track";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(txt_trackLyrics);
            groupBox2.Controls.Add(txt_trackVideo);
            groupBox2.Controls.Add(txt_trackNumber);
            groupBox2.Controls.Add(txt_trackTitle);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(12, 366);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 329);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Tracks";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(116, 220);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 28);
            comboBox1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(201, 278);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 12;
            label8.Text = "TrackID";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Enabled = false;
            checkBox2.Location = new Point(133, 277);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(57, 24);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "edit";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Location = new Point(18, 274);
            button7.Name = "button7";
            button7.Size = new Size(102, 29);
            button7.TabIndex = 10;
            button7.Text = "Add/Update";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // txt_trackLyrics
            // 
            txt_trackLyrics.Enabled = false;
            txt_trackLyrics.Location = new Point(142, 181);
            txt_trackLyrics.Name = "txt_trackLyrics";
            txt_trackLyrics.Size = new Size(139, 27);
            txt_trackLyrics.TabIndex = 8;
            // 
            // txt_trackVideo
            // 
            txt_trackVideo.Enabled = false;
            txt_trackVideo.Location = new Point(142, 134);
            txt_trackVideo.Name = "txt_trackVideo";
            txt_trackVideo.Size = new Size(139, 27);
            txt_trackVideo.TabIndex = 7;
            // 
            // txt_trackNumber
            // 
            txt_trackNumber.Enabled = false;
            txt_trackNumber.Location = new Point(142, 88);
            txt_trackNumber.Name = "txt_trackNumber";
            txt_trackNumber.Size = new Size(139, 27);
            txt_trackNumber.TabIndex = 6;
            // 
            // txt_trackTitle
            // 
            txt_trackTitle.Enabled = false;
            txt_trackTitle.Location = new Point(142, 52);
            txt_trackTitle.Name = "txt_trackTitle";
            txt_trackTitle.Size = new Size(139, 27);
            txt_trackTitle.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 228);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 4;
            label9.Text = "Album Id";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 181);
            label10.Name = "label10";
            label10.Size = new Size(44, 20);
            label10.TabIndex = 3;
            label10.Text = "Lyrics";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 134);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 2;
            label11.Text = "Video URL";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 88);
            label12.Name = "label12";
            label12.Size = new Size(63, 20);
            label12.TabIndex = 1;
            label12.Text = "Number";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 55);
            label13.Name = "label13";
            label13.Size = new Size(76, 20);
            label13.TabIndex = 0;
            label13.Text = "Track Title";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 693);
            Controls.Add(groupBox2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Database_demo";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox txt_album;
        private TextBox txt_description;
        private TextBox txt_albumImageURL;
        private TextBox txt_albumYear;
        private TextBox txt_albumArtist;
        private Button button3;
        private Label label6;
        private DataGridView dataGridView2;
        private Button button4;
        private Button button5;
        private CheckBox checkBox1;
        private Label label7;
        private Button button6;
        private GroupBox groupBox2;
        private Label label8;
        private CheckBox checkBox2;
        private Button button7;
        private TextBox txt_trackLyrics;
        private TextBox txt_trackVideo;
        private TextBox txt_trackNumber;
        private TextBox txt_trackTitle;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox comboBox1;
    }
}