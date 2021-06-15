namespace InstrumentShop.WinForm
{
    partial class StringsForm
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
            this.stringsText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stringsText
            // 
            this.stringsText.Location = new System.Drawing.Point(22, 308);
            this.stringsText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stringsText.Name = "stringsText";
            this.stringsText.Size = new System.Drawing.Size(463, 26);
            this.stringsText.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 278);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "Number Of Strings:";
            // 
            // StringsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(544, 543);
            this.Controls.Add(this.stringsText);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "StringsForm";
            this.Text = "Strings";
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.stringsText, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox stringsText;
        internal System.Windows.Forms.Label label8;
    }
}
