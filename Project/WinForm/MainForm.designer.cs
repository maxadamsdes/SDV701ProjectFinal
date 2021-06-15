namespace InstrumentShop.WinForm
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
            this.continueButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ordersButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // vlaueLabel
            // 
            this.vlaueLabel.Location = new System.Drawing.Point(201, 353);
            this.vlaueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vlaueLabel.Name = "vlaueLabel";
            this.vlaueLabel.Size = new System.Drawing.Size(102, 25);
            this.vlaueLabel.TabIndex = 13;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(108, 353);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 25);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Total Value";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(454, 288);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(120, 50);
            this.quitButton.TabIndex = 11;
            this.quitButton.Text = "Quit";
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(454, 45);
            this.continueButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(120, 50);
            this.continueButton.TabIndex = 9;
            this.continueButton.Text = "Continue";
            this.continueButton.Click += new System.EventHandler(this.addButton_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.categoryList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(26, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 293);
            this.panel1.TabIndex = 15;
            // 
            // categoryList
            // 
            this.categoryList.AllowUserToAddRows = false;
            this.categoryList.AllowUserToDeleteRows = false;
            this.categoryList.AllowUserToResizeColumns = false;
            this.categoryList.AllowUserToResizeRows = false;
            this.categoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryList.Location = new System.Drawing.Point(3, 32);
            this.categoryList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoryList.MultiSelect = false;
            this.categoryList.Name = "categoryList";
            this.categoryList.ReadOnly = true;
            this.categoryList.RowHeadersWidth = 51;
            this.categoryList.RowTemplate.Height = 24;
            this.categoryList.Size = new System.Drawing.Size(397, 255);
            this.categoryList.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(454, 114);
            this.ordersButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(120, 50);
            this.ordersButton.TabIndex = 16;
            this.ordersButton.Text = "Orders";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(454, 378);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(120, 34);
            this.submitButton.TabIndex = 18;
            this.submitButton.Text = "SetUp";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 453);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vlaueLabel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Instrument Shop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label vlaueLabel;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button quitButton;
        internal System.Windows.Forms.Button continueButton;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView categoryList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button ordersButton;
        internal System.Windows.Forms.Button submitButton;
    }
}

