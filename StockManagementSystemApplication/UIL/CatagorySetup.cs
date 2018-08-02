using System;
using System.Data;
using System.Windows.Forms;
using StockManagementSystemApplication.BLL;
using StockManagementSystemApplication.DAL;
using StockManagementSystemApplication.Modals;

namespace StockManagementSystemApplication.UIL
{
    public partial class CatagorySetup : Form
    {
        Category catagory = new Category();
        CatagoryManager catagoryManager = new CatagoryManager();
        public CatagorySetup()
        {
            InitializeComponent();
         //   catagorydataGridView.DataSource = catagoryManager.GetCatagory(catagory);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

          
            catagory.CategoryName = CatagoryNameTextBox.Text;
           

            bool isAdded = catagoryManager.Add(catagory);

            if (isAdded)
            {
                DataTable dt = catagoryManager.Show();
               catagorydataGridView.DataSource = dt;
                // categorySetupDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                return;
            }
            MessageBox.Show("Failed!");

        }

    }
}
