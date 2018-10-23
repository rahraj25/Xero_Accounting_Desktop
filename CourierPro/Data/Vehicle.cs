using CourierPro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierPro
{
    class Vehicle
    {
        public enum vehicleType { car, cycle, moped, motorcycle, van, truck, forklift }

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

        public string licence { get; set; }
        public string rego { get; set; }
        public DateTime dateOfPurchas { get; set; }
        public DateTime regoDue { get; set; }
        public Driver driver { get; set; }
        public int mileage { get; set; }

        public vehicleType vtype { get; set; } = vehicleType.car;


        public void SetDriver(Driver driver)
        {

        }

    }
}
