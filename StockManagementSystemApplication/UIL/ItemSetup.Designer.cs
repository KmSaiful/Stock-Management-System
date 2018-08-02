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
            this.components = new System.ComponentModel.Container();
            this.catagoryComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReordertextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.catagoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // catagoryComboBox
            // 
            this.catagoryComboBox.DataSource = this.catagoryBindingSource;
            this.catagoryComboBox.DisplayMember = "CategoryName";
            this.catagoryComboBox.FormattingEnabled = true;
            this.catagoryComboBox.Location = new System.Drawing.Point(229, 69);
            this.catagoryComboBox.Name = "catagoryComboBox";
            this.catagoryComboBox.Size = new System.Drawing.Size(210, 21);
            this.catagoryComboBox.TabIndex = 0;
            this.catagoryComboBox.ValueMember = "CatagoryId";
            this.catagoryComboBox.SelectedIndexChanged += new System.EventHandler(this.catagoryComboBox_SelectedIndexChanged);
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
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companyBindingSource;
            this.companyComboBox.DisplayMember = "CompanyName";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(229, 96);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(211, 21);
            this.companyComboBox.TabIndex = 1;
            this.companyComboBox.ValueMember = "Id";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
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
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(229, 124);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(209, 20);
            this.ItemNameTextBox.TabIndex = 28;
            // 
            // catagoryBindingSource
            // 
            this.catagoryBindingSource.DataSource = typeof(StockManagementSystemApplication.Modals.Category);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementSystemApplication.Modals.Company);
            // 
            // ItemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 309);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.catagoryComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReordertextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ItemSetup";
            this.Text = "ItemSetup";
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox catagoryComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ReordertextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.BindingSource catagoryBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
    }
}