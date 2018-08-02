using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemApplication.BLL;
using StockManagementSystemApplication.Modals;

namespace StockManagementSystemApplication
{
    public partial class Stock_In : Form
    {
        Category category=new Category();
        Company company=new Company();
        Items item=new Items();
        StockInManager stockInManager = new StockInManager();
        public Stock_In()
        {
            InitializeComponent();
           
           
            categoryComboBox.DataSource = stockInManager.GetCategoryTable(category);
            companyComboBox.DataSource = stockInManager.GetCompanyTable(company);
            itemComboBox.DataSource = stockInManager.GetItemTable(item);

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StockInClass stockIn = new StockInClass();
            stockIn.ItemName = itemComboBox.Text;

            stockIn.ItemId = stockInManager.GetItemId(stockIn);
         
           
            stockIn.AvailableQuantity = Convert.ToInt32(availableQuantityLabel.Text);
            bool isTrue=stockInManager.Validation(quantityTextBox.Text);
            if (!isTrue)
            {
                MessageBox.Show("Please Enter a Valid Number!");
                return;
            }
            stockIn.StockInQuantity = Convert.ToInt32(quantityTextBox.Text);
            stockIn.AvailableQuantity += stockIn.StockInQuantity;
            bool isAdded = stockInManager.Update(stockIn);
            if (isAdded)
            {
                MessageBox.Show("Stock In Succesful!");
                quantityTextBox.Text=String.Empty;
                return;
            }
            else
            {
                MessageBox.Show("Stock In Failed!");
                return;
            }

         }
        
        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemName = itemComboBox.Text;
            DataTable dt = new DataTable();
            dt = stockInManager.SetItemTable(selectedItemName);
           
             itemComboBox.DataSource = dt;

             if (dt.Rows.Count == 0)
             {

                 long number = 0;
                 availableQuantityLabel.Text = number.ToString();
                 MessageBox.Show("No Item Found!");
             }
             else
             {
             
                 itemComboBox.DataSource = dt;
                 reorderLevelLabel.Text = dt.Rows[0]["ReorderLevel"].ToString();

                 if (dt.Rows[0]["AvailableQuantity"].ToString() == "")
                 {
                     availableQuantityLabel.Text = (0).ToString();
                 }
                 else
                 {
                     availableQuantityLabel.Text = dt.Rows[0]["AvailableQuantity"].ToString();
                 }

              }
           }

            private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {

                string selectedCompanyName = companyComboBox.Text;
                DataTable dt = new DataTable();
                dt = stockInManager.SetCompanyTable(selectedCompanyName);
         
                itemComboBox.DataSource = dt;
          
                if (dt.Rows.Count == 0)
                {

                    long number = 0;
                    availableQuantityLabel.Text = number.ToString();
                    MessageBox.Show("No Item Found!");
                }
                else
                {
            
                    companyComboBox.DataSource = dt;
                    itemComboBox.DataSource = dt;
                    reorderLevelLabel.Text = dt.Rows[0]["ReorderLevel"].ToString();

                    if (dt.Rows[0]["AvailableQuantity"].ToString() == "")
                    {
                        availableQuantityLabel.Text = (0).ToString();
                    }
                    else
                        availableQuantityLabel.Text = dt.Rows[0]["AvailableQuantity"].ToString();
              
                }
            }

            private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                string selectedCategoryName = categoryComboBox.Text;
                DataTable dt = new DataTable();
                dt = stockInManager.SetCategoryTable(selectedCategoryName);




                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Item Found!");
                }
                else
                {

                    companyComboBox.DataSource = dt;
                    itemComboBox.DataSource = dt;
                    reorderLevelLabel.Text = dt.Rows[0]["ReorderLevel"].ToString();
                    if (dt.Rows[0]["AvailableQuantity"].ToString() == "")
                    {
                        availableQuantityLabel.Text = (0).ToString();
                    }
                    else
                    {
                        availableQuantityLabel.Text = dt.Rows[0]["AvailableQuantity"].ToString();
                    }
                 }
              }

        
       
    }
}
