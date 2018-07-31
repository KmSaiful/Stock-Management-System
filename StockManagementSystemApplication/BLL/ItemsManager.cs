using StockManagementSystemApplication.DAL;
using StockManagementSystemApplication.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApplication.BLL
{
    public class ItemsManager
    {
        ItemsRepository itemsRepository = new ItemsRepository();
        public bool Add(Items item)
        {
            if(item==null && item.Name.Length > 3 )
            {
                throw new Exception("Invalied Item name");
            }
            if(item.CatagoryId==null && item.CatagoryId<1)
            {
                 throw new Exception("Select a Catagory");
            }
            if(item.CompanyId==null && item.CompanyId<1)
            {
                 throw new Exception("Select a Company");
            }
            if (item.RecordLevel==null)
            {
                throw new Exception("Enter Reorder Lebel");
            }
            bool isAdded = itemsRepository.Add(item);
            return isAdded;

        }


        
    }
}
