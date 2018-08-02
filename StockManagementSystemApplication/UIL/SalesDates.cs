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
    public partial class SalesDates : Form
    {
        SalesDatesManager salesDatesManager=new SalesDatesManager();
        public SalesDates()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SalesDatesClass salesDatesClass=new SalesDatesClass();
            salesDatesClass.FromDateTime = Convert.ToDateTime(fromDateTimePicker.Text);
            salesDatesClass.ToDateTime = Convert.ToDateTime(toDateTimePicker.Text);
            if (salesDatesClass.FromDateTime > salesDatesClass.ToDateTime)
            {
                MessageBox.Show("Enter valid range of date to search!");
                return;
            }
            DataTable dt=new DataTable();
            dt=salesDatesManager.GetSalesReport(salesDatesClass);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No Transanction taken place between" + salesDatesClass.FromDateTime + " to " +
                                salesDatesClass.ToDateTime + "!");
                return;
            }
            saleReportDataGridView.DataSource = dt;

        }
    }
}
