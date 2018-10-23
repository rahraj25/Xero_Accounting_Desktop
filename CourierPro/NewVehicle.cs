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
    public partial class NewVehicle : Form
    {
        public NewVehicle()
        {
            InitializeComponent();
            BindVehicle();
        }

        void BindVehicle()
        {
            cbVehicleType.DataSource = Enum.GetNames(typeof(Vehicle.vehicleType)).ToList();
        }

    }
}
