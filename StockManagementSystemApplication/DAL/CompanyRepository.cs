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
    public class CompanyRepository
    {
        SqlConnection con = new SqlConnection(@"server=TANVIR; database=Stock Management System current;integrated security=true");
        public bool Add(Company company)
        {

            string query = @"INSERT INTO Company(CompanyName) VALUES ('" + company.CompanyName + "')";
            SqlCommand commend = new SqlCommand(query, con);
            con.Open();
            bool isValid = commend.ExecuteNonQuery() > 0;
            con.Close();
            return isValid;

        }
        public DataTable GetCompany(Company company)
        {
            
            SqlCommand command = new SqlCommand(@"Select * FROM Company", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            con.Close();
            return dt;

        }
    }
}
