using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemApplication.Modals
{
    public class Items
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CatagoryId { get; set; }
        public int CompanyId { get; set; }
        public int RecordLevel { get; set; }
    }
}
