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
    public partial class Stock_Out : Form
    {
        List<string> GridViewData = new List<string>();
        private int count = 1;
        Category category=new Category();
        Company company=new Company();
        Items item=new Items();
        StockOutClass stockOut = new StockOutClass();
        StockOutManager stockOutManager = new StockOutManager();
        public Stock_Out()
        {
            InitializeComponent();
           
           
            categoryComboBox.DataSource = stockOutManager.GetCategoryTable(category);
            companyComboBox.DataSource = stockOutManager.GetCompanyTable(company);
            itemComboBox.DataSource = stockOutManager.GetItemTable(item);

        }

        //private void Save_Click(object sender, EventArgs e)
        //{
        //    StockOutClass stockOut=new StockOutClass();
        //   stockOut.ItemName = itemComboBox.Text;

        //    stockIn.ItemId = stockOutManager.GetItemId(stockIn);
         
           
        //    stockIn.AvailableQuantity = Convert.ToInt32(quantityLabel.Text);
        //    bool isTrue=stockOutManager.Validation(stockOutQuantityTextBox.Text);
        //    if (!isTrue)
        //    {
        //        MessageBox.Show("Please Enter a Valid Number!");
        //        return;
        //    }
        //    stockIn.StockInQuantity = Convert.ToInt32(stockOutQuantityTextBox.Text);
        //    stockIn.AvailableQuantity += stockIn.StockInQuantity;
        //    bool isAdded = stockOutManager.Update(stockIn);
        //    if (isAdded)
        //    {
        //        MessageBox.Show("Stock In Succesful!");
        //        stockOutQuantityTextBox.Text = String.Empty;
        //        return;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Stock In Failed!");
        //        return;
        //    }

        // }
        
        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemName = itemComboBox.Text;
            DataTable dt = new DataTable();
            dt = stockOutManager.SetItemTable(selectedItemName);

            itemComboBox.DataSource = dt;

            if (dt.Rows.Count == 0)
            {

                long number = 0;
                quantityLabel.Text = number.ToString();
                MessageBox.Show("No Item Found!");
            }
            else
            {

                itemComboBox.DataSource = dt;
                reorderLabel.Text = dt.Rows[0]["ReorderLevel"].ToString();

                if (dt.Rows[0]["AvailableQuantity"].ToString() == "")
                {
                    quantityLabel.Text = (0).ToString();
                }
                else
                {
                    quantityLabel.Text = dt.Rows[0]["AvailableQuantity"].ToString();
                }

            }
           }

            private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {

                string selectedCompanyName = companyComboBox.Text;
                DataTable dt = new DataTable();
                dt = stockOutManager.SetCompanyTable(selectedCompanyName);
         
                itemComboBox.DataSource = dt;
          
                if (dt.Rows.Count == 0)
                {

                    long number = 0;
                    quantityLabel.Text = number.ToString();
                    MessageBox.Show("No Item Found!");
                }
                else
                {
            
                    companyComboBox.DataSource = dt;
                    itemComboBox.DataSource = dt;
                    reorderLabel.Text = dt.Rows[0]["ReorderLevel"].ToString();

                    if (dt.Rows[0]["AvailableQuantity"].ToString() == "")
                    {
                        quantityLabel.Text = (0).ToString();
                    }
                    else
                        quantityLabel.Text = dt.Rows[0]["AvailableQuantity"].ToString();
              
                }
            }

            private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                string selectedCategoryName = categoryComboBox.Text;
                DataTable dt = new DataTable();
                dt = stockOutManager.SetCategoryTable(selectedCategoryName);




                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No Item Found!");
                }
                else
                {

                    companyComboBox.DataSource = dt;
                    itemComboBox.DataSource = dt;
                    reorderLabel.Text = dt.Rows[0]["ReorderLevel"].ToString();
                    if (dt.Rows[0]["AvailableQuantity"].ToString() == "")
                    {
                       quantityLabel.Text = (0).ToString();
                    }
                    else
                    {
                       quantityLabel.Text = dt.Rows[0]["AvailableQuantity"].ToString();
                    }
                 }
            }

            private void AddButton_Click(object sender, EventArgs e)
            {
                 reorderMessageLabel.Text=String.Empty;
                stockOut.CategoryName = categoryComboBox.Text;
                stockOut.CompanyName = companyComboBox.Text;
                stockOut.ItemName = itemComboBox.Text;
                bool isTrue = stockOutManager.Validation(stockOutQuantityTextBox.Text);
                if (!isTrue)
                {
                    MessageBox.Show("Please Enter a Valid Number!");
                          return;
                }
                stockOut.Quantity = Convert.ToInt64(stockOutQuantityTextBox.Text);
                stockOut.ReorderLevel = Convert.ToInt64(reorderLabel.Text);
                long availableQuantity= Convert.ToInt64(quantityLabel.Text);
                if (availableQuantity - Convert.ToInt64(stockOutQuantityTextBox.Text) < 0)
                {
                    MessageBox.Show("Out  Of  Stock");
                    return;
                }
                if (availableQuantity - Convert.ToInt64(stockOutQuantityTextBox.Text) < stockOut.ReorderLevel)
                {
                    reorderMessageLabel.ForeColor=Color.Red;
                    reorderMessageLabel.Text = "Check the Stock of the Item!";
                }


                if (count == 1)
                {
                    stockOutDataGridView.Columns.Add("CategoryName", "CategoryName");
                    stockOutDataGridView.Columns.Add("CompanyName", "CompanyName");
                    stockOutDataGridView.Columns.Add("ItemName", "ItemName");
                    stockOutDataGridView.Columns.Add("Quantity", "Quantity");
                    count++;
                }
                stockOutDataGridView.Rows.Add(stockOut.CategoryName, stockOut.CompanyName, stockOut.ItemName, stockOut.Quantity);

                stockOutQuantityTextBox.Text = String.Empty;

                //  bool isAdded = stockOutManager.StockOutDataAdded(stockOut);
            }

            private void SellButton_Click(object sender, EventArgs e)
            {
                bool isSuccessfull = false;
                foreach (DataGridViewRow row in stockOutDataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        GridViewData.Add(cell.Value.ToString());
                    }
                    string ItemName = GridViewData[2];
                    string ItemId = stockOutManager.GetItemId(ItemName).ToString();
                    GridViewData.Add(ItemId);
                    GridViewData.Add("Sell");
                    bool  isAdded=stockOutManager.AddStockOut(GridViewData);
                    if (isAdded)
                    {
                        //long quantity = Convert.ToInt64(GridViewData[3]);
                        bool isUpdated=stockOutManager.UpdateTable(GridViewData);
                        if (isUpdated)
                        {
                          isSuccessfull = true;
                        }
                    }

                }
                if (isSuccessfull == true)
                {
                    MessageBox.Show("Stock Out Successfull!");
                }
                stockOutDataGridView.Rows.Clear();

            }

            private void DamageButton_Click(object sender, EventArgs e)
            {
                bool isSuccessfull = false;
                foreach (DataGridViewRow row in stockOutDataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        GridViewData.Add(cell.Value.ToString());
                    }
                    string ItemName = GridViewData[2];
                    string ItemId = stockOutManager.GetItemId(ItemName).ToString();
                    GridViewData.Add(ItemId);
                    GridViewData.Add("Damage");
                    bool isAdded = stockOutManager.AddStockOut(GridViewData);
                    if (isAdded)
                    {
                        //long quantity = Convert.ToInt64(GridViewData[3]);
                        bool isUpdated = stockOutManager.UpdateTable(GridViewData);
                        if (isUpdated)
                        {
                            isSuccessfull = true;
                        }
                    }

                }
                if (isSuccessfull == true)
                {
                    MessageBox.Show("StockInSuccessfull!");
                }
                stockOutDataGridView.Rows.Clear();

            }

            private void LostButton_Click(object sender, EventArgs e)
            {
                 bool isSuccessfull = false;
                foreach (DataGridViewRow row in stockOutDataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        GridViewData.Add(cell.Value.ToString());
                    }
                    string ItemName = GridViewData[2];
                    string ItemId = stockOutManager.GetItemId(ItemName).ToString();
                    GridViewData.Add(ItemId);
                    GridViewData.Add("Lost");
                    bool isAdded = stockOutManager.AddStockOut(GridViewData);
                    if (isAdded)
                    {
                        //long quantity = Convert.ToInt64(GridViewData[3]);
                        bool isUpdated = stockOutManager.UpdateTable(GridViewData);
                        if (isUpdated)
                        {
                            isSuccessfull = true;
                        }
                    }

                }
                if (isSuccessfull == true)
                {
                    MessageBox.Show("StockInSuccessfull!");
                }
                stockOutDataGridView.Rows.Clear();
            }
 
    }
}
