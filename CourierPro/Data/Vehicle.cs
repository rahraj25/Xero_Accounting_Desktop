using CourierPro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierPro.Data
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public enum vehicleType { none, car, cycle, moped, motorcycle, van, truck, forklift }
        public enum vehicleCategory { none, class1, class3, class5, class6}
        //public string licence { get; set; }
        public string rego { get; set; }
        public DateTime dateOfPurchas { get; set; }

        public vehicleType type { get; set; } = vehicleType.car;
        public vehicleCategory category { get; set; } = vehicleCategory.class1;
        //public DateTime regoDue { get; set; }
        //public Driver driver { get; set; }
        //public int mileage { get; set; }
        //string _rego;
        //DateTime _dateOfPurchase;
        //DateTime _regoDue;
        //double _capacity;
        //Driver _driver;
        //int _mileage;
        //string _licence;
        //vehicleType _vtype;

        public Vehicle()
        {

        }

        public bool hasDriver()
        {
            return true;
        }

        
        


        public void SetDriver(Driver driver)
        {

        }

    }
}
