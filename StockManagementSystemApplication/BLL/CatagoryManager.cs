using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemApplication.DAL;
using StockManagementSystemApplication.Modals;
using System.Data;
using System.Text.RegularExpressions;

namespace StockManagementSystemApplication.BLL
{

  
    public  class CatagoryManager
    {
        CatagoryRepository categorySetupRepository = new CatagoryRepository();
        public static Regex regex = new Regex(@"[A-Za-z]");
        public bool Add(Category category)
        {
            bool isAdded = false;
            if (regex.IsMatch(category.CategoryName))
            {
                isAdded = categorySetupRepository.Add(category);
            }
            return isAdded;
        }

        public DataTable Show()
        {
            DataTable dt = categorySetupRepository.Show();
            return dt;
        }
    }
}
