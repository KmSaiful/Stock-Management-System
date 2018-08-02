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
        ItemsManager itemManager = new ItemsManager();
        Items item = new Items();
        public ItemSetup()
        {
            InitializeComponent();
            companyComboBox.DataSource = itemManager.GetCompany(item);
            catagoryComboBox.DataSource = itemManager.GetCatagory(item);


        }
        
        

        private void SaveButton_Click(object sender, EventArgs e)
        {
           
            item.Name = ItemNameTextBox.Text;
            item.CategoryName = catagoryComboBox.Text;
            item.CompanyName = companyComboBox.Text;
            item.RecordLevel = Convert.ToInt32(ReordertextBox.Text);
            item.CatagoryId = itemManager.GetCatagoryId(item);
            item.CompanyId = itemManager.GetCompanyId(item);

            bool isAdded = itemManager.Add(item);
            if (isAdded)
            {
                MessageBox.Show("Item Added Successfully!");
            }


        }

        private void catagoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategoryName = catagoryComboBox.Text;
            DataTable dt = new DataTable();
            dt = itemManager.SetCategoryTable(selectedCategoryName);




            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Item Found!");
            }
            else
            {

                companyComboBox.DataSource = dt;
                
            }
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCompanyName = companyComboBox.Text;
            DataTable dt = new DataTable();
            dt = itemManager.SetCompanyTable(selectedCompanyName);

            if (dt.Rows.Count == 0)
            {

                MessageBox.Show("No Item Found!");
            }
            else
            {

                companyComboBox.DataSource = dt;
               
            }
        }
       
    }
}
