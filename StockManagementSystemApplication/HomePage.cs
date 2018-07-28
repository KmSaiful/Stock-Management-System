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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void companySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company_Setup company = new Company_Setup();
            company.Show();
            //HomePage home = new HomePage();
            //home.Close();
        }

        private void categorySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategorySetup catagory = new CategorySetup();
            catagory.Show();
        }

        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemSetup items = new ItemSetup();
            items.Show();
        }

        private void stokInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_In stockin = new Stock_In();
            stockin.Show();
        }

        private void stockOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Stock_Out stockout = new Stock_Out();
            stockout.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesDates sales = new SalesDates();
            sales.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemsSummary search = new ItemsSummary();
            search.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInPage logout = new LogInPage();
            logout.Show();
        }

        private void setupCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategorySetup catagory = new CategorySetup();
            catagory.Show();
        }

        private void setupCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company_Setup company = new Company_Setup();
            company.Show();
        }

        private void setupItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemSetup items = new ItemSetup();
            items.Show();
        }

        private void stockInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Stock_In stockin = new Stock_In();
            stockin.Show();

        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Out stockout = new Stock_Out();
            stockout.Show();
        }

        private void searchAndViewItemsSummaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ItemsSummary summary = new ItemsSummary();
            summary.Show();
        }
    }
}
