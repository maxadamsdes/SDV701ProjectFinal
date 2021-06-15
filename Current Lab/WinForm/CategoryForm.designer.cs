namespace ArtGallery.WinForm
{
    partial class CategoryForm
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.optSort = new System.Windows.Forms.GroupBox();
            this.byDate = new System.Windows.Forms.RadioButton();
            this.byName = new System.Windows.Forms.RadioButton();
            this.closeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.instrumentList = new System.Windows.Forms.ListBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.speciality = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.optSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(232, 358);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(108, 25);
            this.totalLabel.TabIndex = 27;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(112, 358);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(96, 25);
            this.Label5.TabIndex = 26;
            this.Label5.Text = "Total Value";
            // 
            // optSort
            // 
            this.optSort.Controls.Add(this.byDate);
            this.optSort.Controls.Add(this.byName);
            this.optSort.Location = new System.Drawing.Point(148, 125);
            this.optSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optSort.Name = "optSort";
            this.optSort.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optSort.Size = new System.Drawing.Size(204, 74);
            this.optSort.TabIndex = 25;
            this.optSort.TabStop = false;
            this.optSort.Text = "Sort By";
            // 
            // byDate
            // 
            this.byDate.Location = new System.Drawing.Point(120, 25);
            this.byDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.byDate.Name = "byDate";
            this.byDate.Size = new System.Drawing.Size(72, 37);
            this.byDate.TabIndex = 1;
            this.byDate.Text = "Date";
            this.byDate.CheckedChanged += new System.EventHandler(this.byDate_CheckedChanged);
            // 
            // byName
            // 
            this.byName.Location = new System.Drawing.Point(12, 25);
            this.byName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.byName.Name = "byName";
            this.byName.Size = new System.Drawing.Size(84, 37);
            this.byName.TabIndex = 0;
            this.byName.Text = "Name";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(256, 395);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 49);
            this.closeButton.TabIndex = 24;
            this.closeButton.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(136, 395);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 49);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(16, 395);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 49);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(16, 186);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(120, 25);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Instruments";
            // 
            // instrumentList
            // 
            this.instrumentList.ItemHeight = 20;
            this.instrumentList.Location = new System.Drawing.Point(16, 211);
            this.instrumentList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.instrumentList.Name = "instrumentList";
            this.instrumentList.Size = new System.Drawing.Size(334, 124);
            this.instrumentList.TabIndex = 20;
            this.instrumentList.DoubleClick += new System.EventHandler(this.instrumentList_DoubleClick);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(112, 88);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(238, 26);
            this.phone.TabIndex = 19;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 88);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(96, 25);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Contact Ph";
            // 
            // speciality
            // 
            this.speciality.Location = new System.Drawing.Point(112, 51);
            this.speciality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.speciality.Name = "speciality";
            this.speciality.Size = new System.Drawing.Size(238, 26);
            this.speciality.TabIndex = 17;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 51);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 25);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Speciality";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(112, 14);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(238, 26);
            this.name.TabIndex = 15;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 14);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 25);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Name";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 460);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.optSort);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.instrumentList);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.speciality);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoryForm";
            this.Text = "Category Details";
            this.optSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label totalLabel;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox optSort;
        internal System.Windows.Forms.RadioButton byDate;
        internal System.Windows.Forms.RadioButton byName;
        internal System.Windows.Forms.Button closeButton;
        internal System.Windows.Forms.Button deleteButton;
        internal System.Windows.Forms.Button addButton;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ListBox instrumentList;
        internal System.Windows.Forms.TextBox phone;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox speciality;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox name;
        internal System.Windows.Forms.Label Label1;
    }
}