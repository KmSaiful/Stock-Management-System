using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApplication.Modals;

namespace StockManagementSystemApplication.DAL
{
    public class CatagoryRepository
    {

        public bool Add(Catagory catagory)
        {
           
            SqlConnection con = new SqlConnection(@"server=TANVIR; database=Stock Management System current;integrated security=true");

            string query = @"INSERT INTO Category([Category Name]) VALUES ('" + catagory.Name + "')";
            SqlCommand commend = new SqlCommand(query, con);
            con.Open();
            bool isValid = commend.ExecuteNonQuery() > 0;
            con.Close();
            return isValid;
        }
        
    }
}
