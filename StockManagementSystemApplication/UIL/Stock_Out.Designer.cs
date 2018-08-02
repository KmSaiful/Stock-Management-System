namespace StockManagementSystemApplication
{
    partial class Stock_Out
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stockOutQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.stockOutDataGridView = new System.Windows.Forms.DataGridView();
            this.stockOutClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SellButton = new System.Windows.Forms.Button();
            this.DamageButton = new System.Windows.Forms.Button();
            this.LostButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reorderLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.reorderMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stock Out Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Available Quantity";
            // 
            // stockOutQuantityTextBox
            // 
            this.stockOutQuantityTextBox.Location = new System.Drawing.Point(205, 163);
            this.stockOutQuantityTextBox.Name = "stockOutQuantityTextBox";
            this.stockOutQuantityTextBox.Size = new System.Drawing.Size(211, 20);
            this.stockOutQuantityTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Reorder Level";
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companyBindingSource;
            this.companyComboBox.DisplayMember = "CompanyName";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(205, 36);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(211, 21);
            this.companyComboBox.TabIndex = 6;
            this.companyComboBox.ValueMember = "CompanyId";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementSystemApplication.Modals.Company);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item";
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemBindingSource;
            this.itemComboBox.DisplayMember = "ItemName";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(205, 73);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(211, 21);
            this.itemComboBox.TabIndex = 7;
            this.itemComboBox.ValueMember = "ItemId";
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(StockManagementSystemApplication.Modals.Items);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Company";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(341, 205);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 32);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // stockOutDataGridView
            // 
            this.stockOutDataGridView.AllowUserToAddRows = false;
            this.stockOutDataGridView.AllowUserToDeleteRows = false;
            this.stockOutDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockOutDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockOutDataGridView.Location = new System.Drawing.Point(22, 253);
            this.stockOutDataGridView.Name = "stockOutDataGridView";
            this.stockOutDataGridView.ReadOnly = true;
            this.stockOutDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.stockOutDataGridView.RowHeadersVisible = false;
            this.stockOutDataGridView.Size = new System.Drawing.Size(394, 236);
            this.stockOutDataGridView.TabIndex = 15;
            // 
            // stockOutClassBindingSource
            // 
            this.stockOutClassBindingSource.DataSource = typeof(StockManagementSystemApplication.Modals.StockOutClass);
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(139, 514);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(75, 34);
            this.SellButton.TabIndex = 16;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // DamageButton
            // 
            this.DamageButton.Location = new System.Drawing.Point(243, 514);
            this.DamageButton.Name = "DamageButton";
            this.DamageButton.Size = new System.Drawing.Size(80, 34);
            this.DamageButton.TabIndex = 17;
            this.DamageButton.Text = "Damage";
            this.DamageButton.UseVisualStyleBackColor = true;
            this.DamageButton.Click += new System.EventHandler(this.DamageButton_Click);
            // 
            // LostButton
            // 
            this.LostButton.Location = new System.Drawing.Point(341, 514);
            this.LostButton.Name = "LostButton";
            this.LostButton.Size = new System.Drawing.Size(75, 34);
            this.LostButton.TabIndex = 18;
            this.LostButton.Text = "Lost";
            this.LostButton.UseVisualStyleBackColor = true;
            this.LostButton.Click += new System.EventHandler(this.LostButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Catagory";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "CategoryName";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(205, 9);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(210, 21);
            this.categoryComboBox.TabIndex = 20;
            this.categoryComboBox.ValueMember = "CategoryId";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystemApplication.Modals.Category);
            // 
            // reorderLabel
            // 
            this.reorderLabel.AutoSize = true;
            this.reorderLabel.Location = new System.Drawing.Point(202, 114);
            this.reorderLabel.Name = "reorderLabel";
            this.reorderLabel.Size = new System.Drawing.Size(0, 13);
            this.reorderLabel.TabIndex = 23;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(202, 140);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(0, 13);
            this.quantityLabel.TabIndex = 24;
            // 
            // reorderMessageLabel
            // 
            this.reorderMessageLabel.AutoSize = true;
            this.reorderMessageLabel.Location = new System.Drawing.Point(258, 114);
            this.reorderMessageLabel.Name = "reorderMessageLabel";
            this.reorderMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.reorderMessageLabel.TabIndex = 23;
            // 
            // Stock_Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 576);
            this.Controls.Add(this.reorderMessageLabel);
            this.Controls.Add(this.reorderLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LostButton);
            this.Controls.Add(this.DamageButton);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.stockOutDataGridView);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stockOutQuantityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Stock_Out";
            this.Text = "Stock_Out";
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stockOutQuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView stockOutDataGridView;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Button DamageButton;
        private System.Windows.Forms.Button LostButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label reorderLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource stockOutClassBindingSource;
        private System.Windows.Forms.Label reorderMessageLabel;
    }
}