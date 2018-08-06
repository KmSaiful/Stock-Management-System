﻿namespace StockManagementSystemApplication
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAndViewItemsSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.itemsSummeryClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsSummeryClassBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSummaryDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.itemsSummeryClassBindingSource;
            this.companyComboBox.DisplayMember = "CompanyName";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(153, 44);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(374, 21);
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
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.itemsSummeryClassBindingSource1;
            this.categoryComboBox.DisplayMember = "CategoryName";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(153, 75);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(374, 21);
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
            this.SearchButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SearchButton.Location = new System.Drawing.Point(313, 119);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // itemSummaryDataGridView
            // 
            this.itemSummaryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemSummaryDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemSummaryDataGridView.Location = new System.Drawing.Point(12, 159);
            this.itemSummaryDataGridView.Name = "itemSummaryDataGridView";
            this.itemSummaryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.itemSummaryDataGridView.RowHeadersVisible = false;
            this.itemSummaryDataGridView.ShowRowErrors = false;
            this.itemSummaryDataGridView.Size = new System.Drawing.Size(607, 311);
            this.itemSummaryDataGridView.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.searchAndViewItemsSummaryToolStripMenuItem,
            this.salesToolStripMenuItem1,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorySetupToolStripMenuItem,
            this.companySetupToolStripMenuItem,
            this.itemSetupToolStripMenuItem,
            this.stockInToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.homeToolStripMenuItem.Text = "&Home";
            // 
            // categorySetupToolStripMenuItem
            // 
            this.categorySetupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.categorySetupToolStripMenuItem.Name = "categorySetupToolStripMenuItem";
            this.categorySetupToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.categorySetupToolStripMenuItem.Text = "&Category Setup";
            this.categorySetupToolStripMenuItem.Click += new System.EventHandler(this.categorySetupToolStripMenuItem_Click);
            // 
            // companySetupToolStripMenuItem
            // 
            this.companySetupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.companySetupToolStripMenuItem.Name = "companySetupToolStripMenuItem";
            this.companySetupToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.companySetupToolStripMenuItem.Text = "C&ompany Setup";
            this.companySetupToolStripMenuItem.Click += new System.EventHandler(this.companySetupToolStripMenuItem_Click);
            // 
            // itemSetupToolStripMenuItem
            // 
            this.itemSetupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.itemSetupToolStripMenuItem.Name = "itemSetupToolStripMenuItem";
            this.itemSetupToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.itemSetupToolStripMenuItem.Text = "&Item Setup";
            this.itemSetupToolStripMenuItem.Click += new System.EventHandler(this.itemSetupToolStripMenuItem_Click);
            // 
            // stockInToolStripMenuItem
            // 
            this.stockInToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.stockInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokInToolStripMenuItem,
            this.stockOutToolStripMenuItem1});
            this.stockInToolStripMenuItem.Name = "stockInToolStripMenuItem";
            this.stockInToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.stockInToolStripMenuItem.Text = "&Stock";
            // 
            // stokInToolStripMenuItem
            // 
            this.stokInToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.stokInToolStripMenuItem.Name = "stokInToolStripMenuItem";
            this.stokInToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.stokInToolStripMenuItem.Text = "Stock &In";
            this.stokInToolStripMenuItem.Click += new System.EventHandler(this.stokInToolStripMenuItem_Click);
            // 
            // stockOutToolStripMenuItem1
            // 
            this.stockOutToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.stockOutToolStripMenuItem1.Name = "stockOutToolStripMenuItem1";
            this.stockOutToolStripMenuItem1.Size = new System.Drawing.Size(145, 24);
            this.stockOutToolStripMenuItem1.Text = "Stock &Out";
            this.stockOutToolStripMenuItem1.Click += new System.EventHandler(this.stockOutToolStripMenuItem1_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.searchToolStripMenuItem.Text = "S&earch And View Items Summary";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchAndViewItemsSummaryToolStripMenuItem1_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.salesToolStripMenuItem.Text = "Sa&les";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(299, 24);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupCategoryToolStripMenuItem,
            this.setupCompanyToolStripMenuItem,
            this.setupItemToolStripMenuItem});
            this.setupToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.setupToolStripMenuItem.Text = "&Setup";
            // 
            // setupCategoryToolStripMenuItem
            // 
            this.setupCategoryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.setupCategoryToolStripMenuItem.Name = "setupCategoryToolStripMenuItem";
            this.setupCategoryToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.setupCategoryToolStripMenuItem.Text = "&Setup Category";
            this.setupCategoryToolStripMenuItem.Click += new System.EventHandler(this.setupCategoryToolStripMenuItem_Click);
            // 
            // setupCompanyToolStripMenuItem
            // 
            this.setupCompanyToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.setupCompanyToolStripMenuItem.Name = "setupCompanyToolStripMenuItem";
            this.setupCompanyToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.setupCompanyToolStripMenuItem.Text = "Setup &Company";
            this.setupCompanyToolStripMenuItem.Click += new System.EventHandler(this.setupCompanyToolStripMenuItem_Click);
            // 
            // setupItemToolStripMenuItem
            // 
            this.setupItemToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.setupItemToolStripMenuItem.Name = "setupItemToolStripMenuItem";
            this.setupItemToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.setupItemToolStripMenuItem.Text = "Setup &Item";
            this.setupItemToolStripMenuItem.Click += new System.EventHandler(this.setupItemToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockInToolStripMenuItem1,
            this.stockOutToolStripMenuItem});
            this.stockToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.stockToolStripMenuItem.Text = "S&tock";
            // 
            // stockInToolStripMenuItem1
            // 
            this.stockInToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.stockInToolStripMenuItem1.Name = "stockInToolStripMenuItem1";
            this.stockInToolStripMenuItem1.Size = new System.Drawing.Size(145, 24);
            this.stockInToolStripMenuItem1.Text = "Stock &In";
            this.stockInToolStripMenuItem1.Click += new System.EventHandler(this.stockInToolStripMenuItem1_Click);
            // 
            // stockOutToolStripMenuItem
            // 
            this.stockOutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
            this.stockOutToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.stockOutToolStripMenuItem.Text = "Stock &Out";
            this.stockOutToolStripMenuItem.Click += new System.EventHandler(this.stockOutToolStripMenuItem_Click);
            // 
            // searchAndViewItemsSummaryToolStripMenuItem
            // 
            this.searchAndViewItemsSummaryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchAndViewItemsSummaryToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAndViewItemsSummaryToolStripMenuItem.Name = "searchAndViewItemsSummaryToolStripMenuItem";
            this.searchAndViewItemsSummaryToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.searchAndViewItemsSummaryToolStripMenuItem.Text = "S&ummary";
            // 
            // salesToolStripMenuItem1
            // 
            this.salesToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.salesToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesToolStripMenuItem1.Name = "salesToolStripMenuItem1";
            this.salesToolStripMenuItem1.Size = new System.Drawing.Size(56, 23);
            this.salesToolStripMenuItem1.Text = "S&ales";
            this.salesToolStripMenuItem1.Click += new System.EventHandler(this.salesToolStripMenuItem1_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.logOutToolStripMenuItem.Text = "&Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(50, 23);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // ItemsSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 483);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.itemSummaryDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ItemsSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scarch & View Item\'s Summary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemsSummary_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.itemsSummeryClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsSummeryClassBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSummaryDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAndViewItemsSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}