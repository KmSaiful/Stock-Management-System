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
    public partial class ItemsSummary : Form
    {
        ItemsSummeryManager  itemsSummeryManager=new ItemsSummeryManager();
        Category category = new Category();
        Company company = new Company();
        ItemsSummeryClass itemsSummeryClass=new ItemsSummeryClass();
        public ItemsSummary()
        {
            InitializeComponent();
            companyComboBox.DataSource = itemsSummeryManager.GetCompanyTable(company);
            categoryComboBox.DataSource = itemsSummeryManager.GetCategoryTable(category);
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            itemsSummeryClass.CategoryName = categoryComboBox.Text;
            itemsSummeryClass.CompanyName = companyComboBox.Text;

            DataTable dt=new DataTable();
            dt=itemsSummeryManager.GetDataTable(itemsSummeryClass);

            
            foreach (DataRow check in dt.Rows)
            {
                if (check["AvailableQuantity"].ToString() == String.Empty)
                {
                    check["AvailableQuantity"] = 0;
                }
            }
            
            itemSummaryDataGridView.DataSource = dt;



        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCompanyName = companyComboBox.Text;
            DataTable dt = new DataTable();
            dt = itemsSummeryManager.SetCompanyTable(selectedCompanyName);

           

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Category Found!");
            }
            else
            {
                categoryComboBox.DataSource = dt;
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategoryName = categoryComboBox.Text;
            DataTable dt = new DataTable();
            dt = itemsSummeryManager.SetCategoryTable(selectedCategoryName);


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Company Found!");
            }
            else
            {
               categoryComboBox.DataSource = dt;
            }
        }
    }
}
