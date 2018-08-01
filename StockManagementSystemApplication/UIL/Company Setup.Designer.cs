namespace StockManagementSystemApplication
{
    partial class CompanySetup
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
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CompanyDataGridView = new System.Windows.Forms.DataGridView();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(129, 32);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.CompanyNameTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(239, 64);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(85, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CompanyDataGridView
            // 
            this.CompanyDataGridView.AutoGenerateColumns = false;
            this.CompanyDataGridView.ColumnHeadersHeight = 21;
            this.CompanyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyNameDataGridViewTextBoxColumn});
            this.CompanyDataGridView.DataSource = this.companyBindingSource;
            this.CompanyDataGridView.Location = new System.Drawing.Point(65, 144);
            this.CompanyDataGridView.Name = "CompanyDataGridView";
            this.CompanyDataGridView.Size = new System.Drawing.Size(257, 244);
            this.CompanyDataGridView.TabIndex = 3;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementSystemApplication.Modals.Company);
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // CompanySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 420);
            this.Controls.Add(this.CompanyDataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CompanySetup";
            this.Text = "Company_Setup";
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView CompanyDataGridView;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
    }
}