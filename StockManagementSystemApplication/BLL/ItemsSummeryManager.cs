using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApplication.DAL;
using StockManagementSystemApplication.Modals;


namespace StockManagementSystemApplication.BLL
{
    class ItemsSummeryManager
    {
        ItemsSummeryRepository itemsSummeryRepository=new ItemsSummeryRepository();
        public DataTable GetCategoryTable(Category category)
        {
            DataTable dt = itemsSummeryRepository.GetCategoryTable(category);
            return dt;
        }
        public DataTable GetCompanyTable(Company company)
        {
            DataTable dt = itemsSummeryRepository.GetCompanyTable(company);
            return dt;
        }
        public DataTable SetCategoryTable(string selectedCategoryName)
        {
            DataTable dt = new DataTable();
            dt = itemsSummeryRepository.SetCategoryTable(selectedCategoryName);
            return dt;
        }
        public DataTable SetCompanyTable(string selectedCompanyName)
        {
            DataTable dt = new DataTable();
            dt = itemsSummeryRepository.SetCompanyTable(selectedCompanyName);

            return dt;
        }

        public DataTable GetDataTable(ItemsSummeryClass itemsSummeryClass)
        {
            DataTable dt = new DataTable();
            dt = itemsSummeryRepository.GetDataTable(itemsSummeryClass);

            return dt;
        }
    }
}
