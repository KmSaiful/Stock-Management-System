using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using StockManagementSystemApplication.DAL;
using StockManagementSystemApplication.Modals;


namespace StockManagementSystemApplication.BLL
{
    class StockOutManager
    {
        public static Regex regex = new Regex("[0-9]");
        StockOutRepository stockOutRepository = new StockOutRepository();
        public DataTable GetCategoryTable(Category category)
        {
            DataTable dt = stockOutRepository.GetCategoryTable(category);
            return dt;
        }
        public DataTable GetCompanyTable(Company company)
        {
            DataTable dt = stockOutRepository.GetCompanyTable(company);
            return dt;
        }
        public DataTable GetItemTable(Item item)
        {
            DataTable dt = stockOutRepository.GetItemTable(item);
            return dt;
        }
        public DataTable SetCategoryTable(string selectedCategoryName)
        {
            DataTable dt = new DataTable();
            dt = stockOutRepository.SetCategoryTable(selectedCategoryName);
            return dt;
        }
        public DataTable SetCompanyTable(string selectedCompanyName)
        {
            DataTable dt = new DataTable();
            dt = stockOutRepository.SetCompanyTable(selectedCompanyName);

            return dt;
        }
        public DataTable SetItemTable(string selectedItemName)
        {
            DataTable dt = new DataTable();
            dt = stockOutRepository.SetItemTable(selectedItemName);
            return dt;
        }

        public bool AddStockOut(List<string>gridViewData)
        {
           bool  isAdded= stockOutRepository.AddStockOut(gridViewData);
            return isAdded;
        }


        //public bool StockOutDataAdded(StockOutClass stockOut)
        //{
        //    bool isAdded = stockOutRepository.StockOutDataUpdated(stockOut);
        //    return isAdded;
        //}








      public bool UpdateTable(List<string> gridViewData)
      {
          bool  isUpdated= stockOutRepository.UpdateTable(gridViewData);
          return isUpdated;
      }

       public int GetItemId(string ItemName)
       {
            int itemId = stockOutRepository.GetItemId(ItemName);
            return itemId;
        }
      

        public bool Validation(string stockOutQuantity)
        {
            bool isTrue = false;
            if (regex.IsMatch(stockOutQuantity))
            {
                isTrue = true;
            }
            return isTrue;
        }
    }
}
