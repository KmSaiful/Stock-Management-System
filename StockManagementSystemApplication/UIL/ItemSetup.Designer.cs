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
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catagoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stock_Management_System_currentDataSet = new StockManagementSystemApplication.Stock_Management_System_currentDataSet();
            this.catagoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.ReordertextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stock_Management_System_currentDataSet1 = new StockManagementSystemApplication.Stock_Management_System_currentDataSet1();
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryTableAdapter = new StockManagementSystemApplication.Stock_Management_System_currentDataSetTableAdapters.CategoryTableAdapter();
            this.companyTableAdapter = new StockManagementSystemApplication.Stock_Management_System_currentDataSet1TableAdapters.CompanyTableAdapter();
            this.catagoryRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catagorySetupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_Management_System_currentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_Management_System_currentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagorySetupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyTableAdapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // catagoryComboBox
            // 
            this.catagoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "CatagoryId", true));
            this.catagoryComboBox.DataSource = this.itemsBindingSource;
            this.catagoryComboBox.DisplayMember = "CategoryName";
            this.catagoryComboBox.FormattingEnabled = true;
            this.catagoryComboBox.Location = new System.Drawing.Point(336, 72);
            this.catagoryComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.catagoryComboBox.Name = "catagoryComboBox";
            this.catagoryComboBox.Size = new System.Drawing.Size(313, 27);
            this.catagoryComboBox.TabIndex = 0;
            this.catagoryComboBox.ValueMember = "CatagoryId";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(StockManagementSystemApplication.Modals.Items);
            // 
            // catagoryBindingSource1
            // 
            this.catagoryBindingSource1.DataSource = typeof(StockManagementSystemApplication.Modals.Catagory);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.stock_Management_System_currentDataSet;
            // 
            // stock_Management_System_currentDataSet
            // 
            this.stock_Management_System_currentDataSet.DataSetName = "Stock_Management_System_currentDataSet";
            this.stock_Management_System_currentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // catagoryBindingSource
            // 
            this.catagoryBindingSource.DataSource = typeof(StockManagementSystemApplication.Modals.Catagory);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Catagory";
            // 
            // ReordertextBox
            // 
            this.ReordertextBox.Location = new System.Drawing.Point(334, 190);
            this.ReordertextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReordertextBox.Name = "ReordertextBox";
            this.ReordertextBox.Size = new System.Drawing.Size(314, 26);
            this.ReordertextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Reorder Level";
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "CompanyId", true));
            this.companyComboBox.DataSource = this.itemsBindingSource;
            this.companyComboBox.DisplayMember = "CompanyName";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(336, 111);
            this.companyComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(314, 27);
            this.companyComboBox.TabIndex = 1;
            this.companyComboBox.ValueMember = "CompanyId";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.stock_Management_System_currentDataSet1;
            // 
            // stock_Management_System_currentDataSet1
            // 
            this.stock_Management_System_currentDataSet1.DataSetName = "Stock_Management_System_currentDataSet1";
            this.stock_Management_System_currentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataSource = typeof(StockManagementSystemApplication.Modals.Company);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Company";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(536, 268);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 34);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(336, 152);
            this.ItemNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(312, 26);
            this.ItemNameTextBox.TabIndex = 28;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // catagoryRepositoryBindingSource
            // 
            this.catagoryRepositoryBindingSource.DataSource = typeof(StockManagementSystemApplication.DAL.CatagoryRepository);
            // 
            // catagorySetupBindingSource
            // 
            this.catagorySetupBindingSource.DataSource = typeof(StockManagementSystemApplication.UIL.CatagorySetup);
            // 
            // companyTableAdapterBindingSource
            // 
            this.companyTableAdapterBindingSource.DataSource = typeof(StockManagementSystemApplication.Stock_Management_System_currentDataSet1TableAdapters.CompanyTableAdapter);
            // 
            // ItemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 367);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.catagoryComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReordertextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ItemSetup";
            this.Text = "ItemSetup";
            this.Load += new System.EventHandler(this.ItemSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_Management_System_currentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_Management_System_currentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagorySetupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyTableAdapterBindingSource)).EndInit();
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
        private Stock_Management_System_currentDataSet stock_Management_System_currentDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private Stock_Management_System_currentDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private Stock_Management_System_currentDataSet1 stock_Management_System_currentDataSet1;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private Stock_Management_System_currentDataSet1TableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.BindingSource catagoryRepositoryBindingSource;
        private System.Windows.Forms.BindingSource catagoryBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource1;
        private System.Windows.Forms.BindingSource catagorySetupBindingSource;
        private System.Windows.Forms.BindingSource catagoryBindingSource1;
        private System.Windows.Forms.BindingSource companyTableAdapterBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
    }
}