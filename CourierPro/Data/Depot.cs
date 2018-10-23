using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierPro.Data
{
    class Depot
    {
        string _location;
        Driver[] couriers;
        Vehicle[] vehicles;


        public Depot(string location)
        {
            _location = location;
        }

        public void AssignDrivers()
        {
            foreach (Vehicle car in vehicles)
            {
                if (!car.hasDriver())
                {
                    foreach (Driver courier in couriers)
                    {
                        if (courier.car != null && courier.license == car.licence)
                        {
                            car.SetDriver(courier);
                            courier.car = car;
                        }

                    }
                }
            }
        }
    }
}
