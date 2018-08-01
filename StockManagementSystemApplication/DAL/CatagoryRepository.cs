using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApplication.Modals;
using System.Data;

namespace StockManagementSystemApplication.DAL
{
    public class CatagoryRepository
    {
        SqlConnection con = new SqlConnection(@"server=TANVIR; database=Stock Management System current;integrated security=true");

        public bool Add(Catagory catagory)
        {



            string query = @"INSERT INTO Category([Category Name]) VALUES ('" + catagory.CategoryName + "')";
            SqlCommand commend = new SqlCommand(query, con);
            con.Open();
            bool isValid = commend.ExecuteNonQuery() > 0;
            con.Close();
            return isValid;
        }
        public DataTable GetCatagory(Catagory catagory)
        {

            SqlCommand command = new SqlCommand(@"Select * FROM Category", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            con.Close();
            return dt;

        }
        
    }
}
