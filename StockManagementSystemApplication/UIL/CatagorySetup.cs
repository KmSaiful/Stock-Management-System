using System;
using System.Windows.Forms;
using StockManagementSystemApplication.BLL;
using StockManagementSystemApplication.DAL;
using StockManagementSystemApplication.Modals;

namespace StockManagementSystemApplication.UIL
{
    public partial class CatagorySetup : Form
    { 
        
        public CatagorySetup()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Catagory catagory = new Catagory();
            catagory.Name = CatagoryNameTextBox.Text;
            if (catagory.Name != null && catagory.Name.Length < 3)
            {
                MessageBox.Show("Saved");
                return;
            }
            CatagoryManager catagoryManager = new CatagoryManager();

            bool isAdded = catagoryManager.Add(catagory);

            if (isAdded)
            {
                MessageBox.Show("Saved.");
            }
            else
            {
                MessageBox.Show("Failed");
            }

        }

    }
}
