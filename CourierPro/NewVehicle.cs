using CourierPro.Common;
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
using static CourierPro.Data.Vehicle;

namespace CourierPro
{
    public partial class NewVehicle : Form
    {
        readonly Entity.Db _vehicleEntity;
        public NewVehicle()
        {
            InitializeComponent();
            BindVehicle();
            _vehicleEntity = new CourierPro.Entity.Db(Entity.DbEnum.Vehicles);

        }

        void BindVehicle()
        {
            cb_vehicle_type.DataSource = Enum.GetNames(typeof(Vehicle.vehicleType)).ToList();
            cb_vehicle_category.DataSource = Enum.GetNames(typeof(Vehicle.vehicleCategory)).ToList();


        }

        private void txtPurchase_Click(object sender, EventArgs e)
        {
            vehiclePurchaseCal.Visible = true;
        }

        private void vehiclePurchaseCal_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtPurchase.Text = vehiclePurchaseCal.SelectionStart.ToString("dd-MM-yyyy");
        }

        bool IsEmpty(string text) => string.IsNullOrEmpty(text);

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime _dpurchaseDate = DateTime.MinValue;
            var _purchaseDate = txtPurchase.Text;

            var _vehicleType = cb_vehicle_type.Text;
            var _vehicleCategory = cb_vehicle_category.Text;
            var _regoDate = txtRego.Text;

            var _message = string.Empty;

            if (IsEmpty(_purchaseDate) || IsEmpty(_regoDate) || IsEmpty(_vehicleType) || IsEmpty(_vehicleCategory))
                _message = "All fields should be filled";

            else if (!DateTime.TryParseExact(_purchaseDate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out _dpurchaseDate))
                _message = "Not valid date format";

            else
            {
                _vehicleEntity.InsertVehicle(new Vehicle()
                {
                    rego = _regoDate,
                    dateOfPurchas = _dpurchaseDate,
                    category = (vehicleCategory)Enum.Parse(typeof(vehicleCategory), _vehicleCategory),
                    type = (vehicleType)Enum.Parse(typeof(vehicleType), _vehicleType)
                });
                _message = "Inserted successfully";

                Instance._vehicle.Refresh();

            }
            // update the data base
            MessageBox.Show(_message);
        }

        private void cb_vehicle_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_vehicle_type.SelectedIndex != -1)
            {
                Console.WriteLine("changed value");
            }
        }

        private void cb_vehicle_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_vehicle_type.SelectedIndex != -1)
            {
                Console.WriteLine("changed value");
            }
        }
    }
}
