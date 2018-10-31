using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierPro.Common
{
    public class Instance
    {
        public static string Location { get; set; }
        public static Depot _depot{ get; set; }
        public static Accounts _account { get; set; }
        public static vehicles _vehicle { get; set; }
        public static Inventory_Management _inventory { get; set; }
    }
}
