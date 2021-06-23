namespace InstrumentShop.WinForm
{
    partial class OrderForm
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
            this.orderList = new System.Windows.Forms.DataGridView();
            this.approveButton = new System.Windows.Forms.Button();
            this.declineButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.completedList = new System.Windows.Forms.DataGridView();
            this.typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedList)).BeginInit();
            this.SuspendLayout();
            // 
            // orderList
            // 
            this.orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderList.Location = new System.Drawing.Point(34, 100);
            this.orderList.Margin = new System.Windows.Forms.Padding(4);
            this.orderList.Name = "orderList";
            this.orderList.RowHeadersWidth = 62;
            this.orderList.RowTemplate.Height = 28;
            this.orderList.Size = new System.Drawing.Size(1114, 810);
            this.orderList.TabIndex = 0;
            this.orderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderList_CellClick);
            // 
            // approveButton
            // 
            this.approveButton.Location = new System.Drawing.Point(1288, 136);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(140, 68);
            this.approveButton.TabIndex = 1;
            this.approveButton.Text = "Approve";
            this.approveButton.UseVisualStyleBackColor = true;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(1288, 241);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(140, 68);
            this.declineButton.TabIndex = 2;
            this.declineButton.Text = "Decline";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(1288, 745);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(140, 68);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(1288, 346);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(140, 68);
            this.viewButton.TabIndex = 4;
            this.viewButton.Text = "View Completed";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // completedList
            // 
            this.completedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.completedList.Location = new System.Drawing.Point(34, 100);
            this.completedList.Margin = new System.Windows.Forms.Padding(4);
            this.completedList.Name = "completedList";
            this.completedList.RowHeadersWidth = 62;
            this.completedList.RowTemplate.Height = 28;
            this.completedList.Size = new System.Drawing.Size(1114, 810);
            this.completedList.TabIndex = 5;
            this.completedList.Visible = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(34, 34);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(298, 37);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "Outstanding Orders";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1496, 923);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.completedList);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.orderList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderList;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.DataGridView completedList;
        private System.Windows.Forms.Label typeLabel;
    }
}