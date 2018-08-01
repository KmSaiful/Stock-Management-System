using System;
using System.Windows.Forms;
using StockManagementSystemApplication.BLL;
using StockManagementSystemApplication.DAL;
using StockManagementSystemApplication.Modals;

namespace StockManagementSystemApplication.UIL
{
    public partial class CatagorySetup : Form
    {
        Catagory catagory = new Catagory();
        CatagoryManager catagoryManager = new CatagoryManager();
        public CatagorySetup()
        {
            InitializeComponent();
            catagorydataGridView.DataSource = catagoryManager.GetCatagory(catagory);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            catagory.CategoryName = CatagoryNameTextBox.Text;
            if (catagory.CategoryName != null && catagory.CategoryName.Length < 3)
            {
                MessageBox.Show("Saved");
                return;
            }
            

            bool isAdded = catagoryManager.Add(catagory);

            if (isAdded)
            {
                catagorydataGridView.DataSource = catagoryManager.GetCatagory(catagory);
            }
            else
            {
                MessageBox.Show("Failed");
            }

        }

    }
}
