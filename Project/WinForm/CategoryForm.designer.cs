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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.optSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(348, 548);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(108, 25);
            this.totalLabel.TabIndex = 27;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(228, 548);
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
            this.optSort.Location = new System.Drawing.Point(491, 40);
            this.optSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optSort.Name = "optSort";
            this.optSort.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optSort.Size = new System.Drawing.Size(211, 75);
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
            this.closeButton.Location = new System.Drawing.Point(735, 486);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 49);
            this.closeButton.TabIndex = 24;
            this.closeButton.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(735, 341);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 49);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(16, 132);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(334, 25);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Select an instrument from the table below:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(20, 45);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(436, 70);
            this.name.TabIndex = 15;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 15);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 25);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Description";
            // 
            // instrumentList
            // 
            this.instrumentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instrumentList.Location = new System.Drawing.Point(0, 34);
            this.instrumentList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.instrumentList.Name = "instrumentList";
            this.instrumentList.RowHeadersWidth = 51;
            this.instrumentList.RowTemplate.Height = 24;
            this.instrumentList.Size = new System.Drawing.Size(682, 331);
            this.instrumentList.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.instrumentList);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(20, 169);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 366);
            this.panel1.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Date Modified";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Items Left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price (NZD)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Condition";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Description";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(735, 282);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 49);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(735, 223);
            this.continueButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(96, 49);
            this.continueButton.TabIndex = 30;
            this.continueButton.Text = "Continue";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 615);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoryForm";
            this.Text = "Category Details";
            this.optSort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.instrumentList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button addButton;
        internal System.Windows.Forms.Button continueButton;
    }
}