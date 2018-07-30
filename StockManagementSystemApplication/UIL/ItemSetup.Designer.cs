namespace StockManagementSystemApplication
{
    partial class ItemSetup
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
            this.catagorycomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReordertextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CompanycomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catagorycomboBox
            // 
            this.catagorycomboBox.FormattingEnabled = true;
            this.catagorycomboBox.Location = new System.Drawing.Point(229, 69);
            this.catagorycomboBox.Name = "catagorycomboBox";
            this.catagorycomboBox.Size = new System.Drawing.Size(210, 21);
            this.catagorycomboBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Catagory";
            // 
            // ReordertextBox
            // 
            this.ReordertextBox.Location = new System.Drawing.Point(228, 150);
            this.ReordertextBox.Name = "ReordertextBox";
            this.ReordertextBox.Size = new System.Drawing.Size(211, 20);
            this.ReordertextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Reorder Level";
            // 
            // CompanycomboBox
            // 
            this.CompanycomboBox.FormattingEnabled = true;
            this.CompanycomboBox.Location = new System.Drawing.Point(229, 96);
            this.CompanycomboBox.Name = "CompanycomboBox";
            this.CompanycomboBox.Size = new System.Drawing.Size(211, 21);
            this.CompanycomboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Item";
            // 
            // ItemcomboBox
            // 
            this.ItemcomboBox.FormattingEnabled = true;
            this.ItemcomboBox.Location = new System.Drawing.Point(229, 123);
            this.ItemcomboBox.Name = "ItemcomboBox";
            this.ItemcomboBox.Size = new System.Drawing.Size(211, 21);
            this.ItemcomboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Company";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(363, 203);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ItemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 309);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.catagorycomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReordertextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CompanycomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemcomboBox);
            this.Controls.Add(this.label1);
            this.Name = "ItemSetup";
            this.Text = "ItemSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox catagorycomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ReordertextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CompanycomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ItemcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
    }
}