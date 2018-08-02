using StockManagementSystemApplication.DAL;
using StockManagementSystemApplication.Modals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StockManagementSystemApplication.BLL
{
    public class CompanyManager
    {
        CompanyRepository companyRepository = new CompanyRepository();
        public static Regex regex = new Regex(@"[A-Za-z]");
        public bool Add(Company company)
        {
            bool isAdded = false;
            if (regex.IsMatch(company.CompanyName))
            {
               
                isAdded = companyRepository.Add(company);
            }
            return isAdded;
        }

        public DataTable Show()
        {
            DataTable dt = companyRepository.Show();
            return dt;
        }
    }
}
