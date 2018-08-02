using StockManagementSystemApplication.BLL;
using StockManagementSystemApplication.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemApplication
{
    public partial class CompanySetup : Form
    {
        CompanyManager companyManager = new CompanyManager();
        Company company = new Company();
        public CompanySetup()
        {
            InitializeComponent();
        //    CompanyDataGridView.DataSource = companyManager.GetCompany(company);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            Company company = new Company();
            company.CompanyName =CompanyNameTextBox.Text;
           

            bool isAdded = companyManager.Add(company);

            if (isAdded)
            {
                DataTable dt = companyManager.Show();
               CompanyDataGridView.DataSource = dt;
                // categorySetupDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                return;
            }
            MessageBox.Show("Failed!");

        }
    }
}
