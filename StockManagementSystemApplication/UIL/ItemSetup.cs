using StockManagementSystemApplication.BLL;
using StockManagementSystemApplication.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemApplication
{
    public partial class ItemSetup : Form
    {
        public ItemSetup()
        {
            InitializeComponent();
        }
        

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Items item = new Items();
            
            
            if (ItemNameTextBox.Text != null && ItemNameTextBox.Text.Length > 3)
            {
                
                item.Name = ItemNameTextBox.Text;
                
                
            }
            else
            {
                MessageBox.Show("Invalied Name");
                return;
            }
            if (Convert.ToInt32(catagoryComboBox.SelectedValue) != null && Convert.ToInt32(catagoryComboBox.SelectedValue) > 0)
            {
                item.CatagoryId = Convert.ToInt32(catagoryComboBox.SelectedValue);
                
            }
            else
            {
                MessageBox.Show("Select A catagory");
                return;
            }
            if (Convert.ToInt32(companyComboBox.SelectedValue) != null && Convert.ToInt32(companyComboBox.SelectedValue) > 0)
            {
                item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
                
            }
            else
            {
                MessageBox.Show("Select A Company");
                return;
            }
            if (Convert.ToInt32(ReordertextBox.Text) != null)
            {
                item.RecordLevel = Convert.ToInt32(ReordertextBox.Text);
                
            }
            else
            {
                MessageBox.Show("Invalied Reorder lebel");
                return;
            }
            ItemsManager itemManager = new ItemsManager();

            bool isAdded = itemManager.Add(item); 
                if (isAdded)
            {
                MessageBox.Show("Item Added .");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
        private void ItemSetup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_Management_System_currentDataSet1.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.stock_Management_System_currentDataSet1.Company);
            // TODO: This line of code loads data into the 'stock_Management_System_currentDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.stock_Management_System_currentDataSet.Category);

        }
    }
}
