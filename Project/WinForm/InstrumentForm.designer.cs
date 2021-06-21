namespace InstrumentShop.WinForm
{
    partial class InstrumentForm
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
            this.valueText = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.conditionText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.lastModified = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // valueText
            // 
            this.valueText.Location = new System.Drawing.Point(397, 284);
            this.valueText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valueText.Name = "valueText";
            this.valueText.Size = new System.Drawing.Size(92, 26);
            this.valueText.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(320, 284);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(78, 25);
            this.Label2.TabIndex = 46;
            this.Label2.Text = "Value:  $";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(22, 20);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 25);
            this.Label1.TabIndex = 44;
            this.Label1.Text = "Description:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(341, 407);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(110, 35);
            this.closeButton.TabIndex = 21;
            this.closeButton.Text = "Cancel";
            this.closeButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(42, 358);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Last Modified:";
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(26, 50);
            this.descriptionText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(463, 85);
            this.descriptionText.TabIndex = 48;
            // 
            // conditionText
            // 
            this.conditionText.Location = new System.Drawing.Point(26, 170);
            this.conditionText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.conditionText.Name = "conditionText";
            this.conditionText.Size = new System.Drawing.Size(463, 26);
            this.conditionText.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(22, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Condition:";
            // 
            // quantityText
            // 
            this.quantityText.Location = new System.Drawing.Point(149, 284);
            this.quantityText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(92, 26);
            this.quantityText.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(72, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Quantity:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(76, 407);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 35);
            this.saveButton.TabIndex = 55;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // lastModified
            // 
            this.lastModified.Enabled = false;
            this.lastModified.Location = new System.Drawing.Point(169, 358);
            this.lastModified.Name = "lastModified";
            this.lastModified.Size = new System.Drawing.Size(320, 26);
            this.lastModified.TabIndex = 56;
            // 
            // InstrumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 464);
            this.Controls.Add(this.lastModified);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.conditionText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valueText);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.closeButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InstrumentForm";
            this.Text = "frmInstrument";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox valueText;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button closeButton;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox descriptionText;
        internal System.Windows.Forms.TextBox conditionText;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox quantityText;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker lastModified;
    }
}