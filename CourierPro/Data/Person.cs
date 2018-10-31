using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierPro.Data
{
    public class Persons
    {
        public Guid Id { get; set; }
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DriverID { get; set; }
        public int AccountID { get; set; }
        public string Email { get; set; }
    }
}
