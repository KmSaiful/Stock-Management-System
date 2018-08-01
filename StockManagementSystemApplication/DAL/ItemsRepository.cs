using StockManagementSystemApplication.Modals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApplication.DAL
{
    public class ItemsRepository
    {
        SqlConnection con = new SqlConnection(@"server=TANVIR; database=Stock Management System current;integrated security=true");

        public bool Add(Items item)
        {
            
            string query = @"INSERT INTO Item VALUES ('" + item.Name + "','" + item.CatagoryId + "','" + item.CompanyId + "','" + item.RecordLevel + "')";
            SqlCommand commend = new SqlCommand(query, con);
            con.Open();
            bool isAdded = commend.ExecuteNonQuery() > 0;
            con.Close();
            return isAdded;



        }
        public DataTable GetCompany(Items item)
        {

            SqlCommand command = new SqlCommand(@"Select * FROM Company", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable GetCatagory(Items item)
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
