namespace InstrumentShop.WinForm
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
            this.Label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.instrumentList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.optSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(463, 892);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(144, 31);
            this.totalLabel.TabIndex = 27;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(303, 892);
            this.Label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(128, 31);
            this.Label5.TabIndex = 26;
            this.Label5.Text = "Total Value";
            // 
            // optSort
            // 
            this.optSort.Controls.Add(this.byDate);
            this.optSort.Controls.Add(this.byName);
            this.optSort.Location = new System.Drawing.Point(655, 50);
            this.optSort.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.optSort.Name = "optSort";
            this.optSort.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.optSort.Size = new System.Drawing.Size(281, 94);
            this.optSort.TabIndex = 25;
            this.optSort.TabStop = false;
            this.optSort.Text = "Sort By";
            // 
            // byDate
            // 
            this.byDate.Location = new System.Drawing.Point(160, 31);
            this.byDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.byDate.Name = "byDate";
            this.byDate.Size = new System.Drawing.Size(96, 46);
            this.byDate.TabIndex = 1;
            this.byDate.Text = "Date";
            this.byDate.CheckedChanged += new System.EventHandler(this.byDate_CheckedChanged);
            // 
            // byName
            // 
            this.byName.Location = new System.Drawing.Point(16, 31);
            this.byName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.byName.Name = "byName";
            this.byName.Size = new System.Drawing.Size(112, 46);
            this.byName.TabIndex = 0;
            this.byName.Text = "Name";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(1203, 575);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(128, 61);
            this.closeButton.TabIndex = 24;
            this.closeButton.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1203, 393);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(128, 61);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(21, 165);
            this.Label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(445, 31);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Select an instrument from the table below:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(27, 56);
            this.name.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(580, 39);
            this.name.TabIndex = 15;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(21, 19);
            this.Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(128, 31);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Description";
            // 
            // instrumentList
            // 
            this.instrumentList.AllowUserToAddRows = false;
            this.instrumentList.AllowUserToDeleteRows = false;
            this.instrumentList.AllowUserToResizeColumns = false;
            this.instrumentList.AllowUserToResizeRows = false;
            this.instrumentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instrumentList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.instrumentList.Location = new System.Drawing.Point(4, 5);
            this.instrumentList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.instrumentList.MultiSelect = false;
            this.instrumentList.Name = "instrumentList";
            this.instrumentList.RowHeadersWidth = 51;
            this.instrumentList.RowTemplate.Height = 24;
            this.instrumentList.Size = new System.Drawing.Size(1126, 660);
            this.instrumentList.TabIndex = 28;
            this.instrumentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.instrumentList_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.instrumentList);
            this.panel1.Location = new System.Drawing.Point(27, 211);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 676);
            this.panel1.TabIndex = 29;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1203, 319);
            this.addButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(128, 61);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(1203, 246);
            this.continueButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(128, 61);
            this.continueButton.TabIndex = 30;
            this.continueButton.Text = "Continue";
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 949);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.optSort);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteButton);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CategoryForm";
            this.Text = "Category Details";
            this.optSort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.instrumentList)).EndInit();
            this.panel1.ResumeLayout(false);
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
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox name;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView instrumentList;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button addButton;
        internal System.Windows.Forms.Button continueButton;
    }
}