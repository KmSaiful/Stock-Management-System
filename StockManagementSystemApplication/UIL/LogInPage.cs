using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemApplication
{
    public partial class LogInPage : Form
    {
        
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LogInPage login = new LogInPage();
            login.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
           
        }

       
    }
}
