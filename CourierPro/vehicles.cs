using CourierPro.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourierPro
{
    public partial class vehicles : Form
    {
        public vehicles()
        {
            InitializeComponent();

        }


        void DataDisplay() {

            var _dummylist = new List<Vehicles>();
            _dummylist.Add(new Vehicles() {VehicleId=1,VehicleName="Random",VehicleType="SUV" });

            dgVehicles.DataSource=
        }

        private void UpdateVehicle(Vehicle vehicle)
        {

        }

    }
}
