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
            this.categoryList = new System.Windows.Forms.ListBox();
            this.galleryNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vlaueLabel
            // 
            this.vlaueLabel.Location = new System.Drawing.Point(119, 501);
            this.vlaueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vlaueLabel.Name = "vlaueLabel";
            this.vlaueLabel.Size = new System.Drawing.Size(102, 25);
            this.vlaueLabel.TabIndex = 13;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(26, 501);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 25);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Total Value";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(454, 486);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(120, 50);
            this.quitButton.TabIndex = 11;
            this.quitButton.Text = "Quit";
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(454, 121);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 50);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(454, 45);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 50);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(26, 20);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(204, 25);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Categories";
            // 
            // categoryList
            // 
            this.categoryList.ItemHeight = 20;
            this.categoryList.Location = new System.Drawing.Point(26, 45);
            this.categoryList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(372, 424);
            this.categoryList.TabIndex = 7;
            this.categoryList.DoubleClick += new System.EventHandler(this.categoryList_DoubleClick);
            // 
            // galleryNameButton
            // 
            this.galleryNameButton.Location = new System.Drawing.Point(454, 394);
            this.galleryNameButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.galleryNameButton.Name = "galleryNameButton";
            this.galleryNameButton.Size = new System.Drawing.Size(120, 70);
            this.galleryNameButton.TabIndex = 14;
            this.galleryNameButton.Text = "Update Shop Name";
            this.galleryNameButton.Click += new System.EventHandler(this.galleryNameButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 565);
            this.Controls.Add(this.galleryNameButton);
            this.Controls.Add(this.vlaueLabel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.categoryList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        internal System.Windows.Forms.ListBox categoryList;
        internal System.Windows.Forms.Button galleryNameButton;
    }
}

