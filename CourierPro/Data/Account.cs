using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierPro.Data
{
    public class Account
    {
        public int AccountNo { get; set; }
        public string AccountType { get; set;}
        public Persons Person { get; set; }
        public string Location { get; set; }
    }
}
