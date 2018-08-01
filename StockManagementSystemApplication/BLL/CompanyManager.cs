using StockManagementSystemApplication.DAL;
using StockManagementSystemApplication.Modals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApplication.BLL
{
    public class CompanyManager
    {
        CompanyRepository companyRepository = new CompanyRepository();
        public bool Add(Company company)
        {
            if(company == null && company.CompanyName.Length < 3)
            {
                throw new Exception("Invalid Company Name");
            }

            bool isValid = companyRepository.Add(company);
            return isValid;
        }
        public DataTable GetCompany(Company company)
        {
            DataTable dt=new DataTable();
            dt = companyRepository.GetCompany(company);
            return dt;
        }
    }
}
