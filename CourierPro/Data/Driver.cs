using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierPro.Data
{
    public class Driver : Persons
    {
        public enum LicenceType {Restricted, Car, Medium, Heavy, Motorcycle, Forklift};
        LicenceType[] licences { get; set; }
        public Vehicle car { get; set; }
        public string license { get; set; }
    }
}
