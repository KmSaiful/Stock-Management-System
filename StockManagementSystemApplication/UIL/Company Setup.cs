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
            CompanyDataGridView.DataSource = companyManager.GetCompany(company);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
           
            company.CompanyName = CompanyNameTextBox.Text;
            if(company.CompanyName != null && company.CompanyName.Length < 3)
            {
                MessageBox.Show("Seved");
                return;
            }
            

            bool isAdded = companyManager.Add(company);

            if (isAdded)
            {
                CompanyDataGridView.DataSource = companyManager.GetCompany(company);
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
