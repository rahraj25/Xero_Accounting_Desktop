using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierPro
{
    class Vehicle
    {
        enum vehicleType { car, cycle, moped, motorcycle, van, truck, forklift}
        string _rego;
        DateTime _dateOfPurchase;
        DateTime _regoDue;
        double _capacity;
        Driver driver;
        int mileage;

        public Vehicle()
        {

        }

        public bool hasDriver() {
            return true;
        }

        public string licence { get; set; }

        public void SetDriver(Driver driver) {

        }

    }
}
