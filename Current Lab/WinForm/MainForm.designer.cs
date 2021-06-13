namespace ArtGallery.WinForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vlaueLabel = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.artistList = new System.Windows.Forms.ListBox();
            this.galleryNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vlaueLabel
            // 
            this.vlaueLabel.Location = new System.Drawing.Point(159, 626);
            this.vlaueLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.vlaueLabel.Name = "vlaueLabel";
            this.vlaueLabel.Size = new System.Drawing.Size(136, 31);
            this.vlaueLabel.TabIndex = 13;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(34, 626);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(128, 31);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Total Value";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(605, 607);
            this.quitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(160, 62);
            this.quitButton.TabIndex = 11;
            this.quitButton.Text = "Quit";
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(605, 151);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(160, 62);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(605, 56);
            this.addButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(160, 62);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(34, 25);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(272, 31);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Artists";
            // 
            // artistList
            // 
            this.artistList.ItemHeight = 25;
            this.artistList.Location = new System.Drawing.Point(34, 56);
            this.artistList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.artistList.Name = "artistList";
            this.artistList.Size = new System.Drawing.Size(494, 529);
            this.artistList.TabIndex = 7;
            this.artistList.DoubleClick += new System.EventHandler(this.artistList_DoubleClick);
            // 
            // galleryNameButton
            // 
            this.galleryNameButton.Location = new System.Drawing.Point(605, 493);
            this.galleryNameButton.Margin = new System.Windows.Forms.Padding(6);
            this.galleryNameButton.Name = "galleryNameButton";
            this.galleryNameButton.Size = new System.Drawing.Size(160, 87);
            this.galleryNameButton.TabIndex = 14;
            this.galleryNameButton.Text = "Update Gallery Name";
            this.galleryNameButton.Click += new System.EventHandler(this.galleryNameButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 706);
            this.Controls.Add(this.galleryNameButton);
            this.Controls.Add(this.vlaueLabel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.artistList);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Gallery (v2 C)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label vlaueLabel;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button quitButton;
        internal System.Windows.Forms.Button deleteButton;
        internal System.Windows.Forms.Button addButton;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox artistList;
        internal System.Windows.Forms.Button galleryNameButton;
    }
}

