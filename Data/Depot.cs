using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierPro.Data
{
    public class Depot
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Contact { get; set; }
        public string Location { get; set; }
        public Driver[] Couriers { get; set; }
        public Vehicle[] Vehicles { get; set; }

        public Depot()
        {

        }

        public Depot(string location)
        {
            this.Location = location;
        }

        public void AssignDrivers()
        {
            foreach (var car in Vehicles)
            {
                if (!car.hasDriver())
                {
                    foreach (var courier in Couriers)
                    {
                        if (courier.car != null && courier.license == Enum.GetNames(typeof(Vehicle.vehicleCategory)).ToString())
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
