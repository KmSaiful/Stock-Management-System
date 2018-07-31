using StockManagementSystemApplication.Modals;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApplication.DAL
{
    public class ItemsRepository
    {
        public bool Add(Items item)
        {
            SqlConnection con = new SqlConnection(@"server=TANVIR; database=Stock Management System current;integrated security=true");

            string query = @"INSERT INTO Item VALUES ('" + item.Name + "','" + item.CatagoryId + "','" + item.CompanyId + "','" + item.RecordLevel + "')";
            SqlCommand commend = new SqlCommand(query, con);
            con.Open();
            bool isAdded = commend.ExecuteNonQuery() > 0;
            con.Close();
            return isAdded;



        }

        
    }
}
