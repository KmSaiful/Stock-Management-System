namespace StockManagementSystemApplication
{
    partial class ItemsSummary
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
            this.label1 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.itemsSummeryClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.itemsSummeryClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SearchButton = new System.Windows.Forms.Button();
            this.itemSummaryDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.itemsSummeryClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsSummeryClassBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSummaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.itemsSummeryClassBindingSource;
            this.companyComboBox.DisplayMember = "CompanyName";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(263, 43);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(259, 21);
            this.companyComboBox.TabIndex = 1;
            this.companyComboBox.ValueMember = "CompanyId";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // itemsSummeryClassBindingSource
            // 
            this.itemsSummeryClassBindingSource.DataSource = typeof(StockManagementSystemApplication.Modals.ItemsSummeryClass);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.itemsSummeryClassBindingSource1;
            this.categoryComboBox.DisplayMember = "CategoryName";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(263, 70);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(259, 21);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.ValueMember = "CaegoryId";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // itemsSummeryClassBindingSource1
            // 
            this.itemsSummeryClassBindingSource1.DataSource = typeof(StockManagementSystemApplication.Modals.ItemsSummeryClass);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(441, 112);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // itemSummaryDataGridView
            // 
            this.itemSummaryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemSummaryDataGridView.Location = new System.Drawing.Point(12, 159);
            this.itemSummaryDataGridView.Name = "itemSummaryDataGridView";
            this.itemSummaryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.itemSummaryDataGridView.RowHeadersVisible = false;
            this.itemSummaryDataGridView.ShowRowErrors = false;
            this.itemSummaryDataGridView.Size = new System.Drawing.Size(744, 311);
            this.itemSummaryDataGridView.TabIndex = 3;
            // 
            // ItemsSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 482);
            this.Controls.Add(this.itemSummaryDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ItemsSummary";
            this.Text = "Scarch & View Item\'s Summary";
            ((System.ComponentModel.ISupportInitialize)(this.itemsSummeryClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsSummeryClassBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSummaryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView itemSummaryDataGridView;
        private System.Windows.Forms.BindingSource itemsSummeryClassBindingSource;
        private System.Windows.Forms.BindingSource itemsSummeryClassBindingSource1;
    }
}