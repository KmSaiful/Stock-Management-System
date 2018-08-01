namespace StockManagementSystemApplication.UIL
{
    partial class CatagorySetup
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
            this.CatagoryNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.catagorydataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.catagoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catagoryRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.catagorydataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // CatagoryNameTextBox
            // 
            this.CatagoryNameTextBox.Location = new System.Drawing.Point(108, 30);
            this.CatagoryNameTextBox.Name = "CatagoryNameTextBox";
            this.CatagoryNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.CatagoryNameTextBox.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(226, 70);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 31);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // catagorydataGridView
            // 
            this.catagorydataGridView.AllowUserToAddRows = false;
            this.catagorydataGridView.AutoGenerateColumns = false;
            this.catagorydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catagorydataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn});
            this.catagorydataGridView.DataSource = this.catagoryBindingSource1;
            this.catagorydataGridView.Location = new System.Drawing.Point(56, 107);
            this.catagorydataGridView.Name = "catagorydataGridView";
            this.catagorydataGridView.Size = new System.Drawing.Size(245, 278);
            this.catagorydataGridView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // catagoryBindingSource1
            // 
            this.catagoryBindingSource1.DataSource = typeof(StockManagementSystemApplication.Modals.Catagory);
            // 
            // catagoryBindingSource
            // 
            this.catagoryBindingSource.DataSource = typeof(StockManagementSystemApplication.Modals.Catagory);
            // 
            // catagoryRepositoryBindingSource
            // 
            this.catagoryRepositoryBindingSource.DataSource = typeof(StockManagementSystemApplication.DAL.CatagoryRepository);
            // 
            // CatagorySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 431);
            this.Controls.Add(this.catagorydataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CatagoryNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CatagorySetup";
            this.Text = "CategorySetup";
            ((System.ComponentModel.ISupportInitialize)(this.catagorydataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CatagoryNameTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView catagorydataGridView;
        private System.Windows.Forms.BindingSource catagoryRepositoryBindingSource;
        private System.Windows.Forms.BindingSource catagoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource catagoryBindingSource1;
    }
}