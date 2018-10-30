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
            cb_vehicle_type.DataSource = Enum.GetNames(typeof(Vehicle.vehicleType)).ToList();


            cb_vehicle_type.DataSource = Enum.GetNames(typeof(Vehicle.vehicleType)).ToList();
            // update the class as vehicle type is selected
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPurchase.Text) || string.IsNullOrEmpty(txtRego.Text))
            {
                MessageBox.Show("All fields should be filled");
            }

            // update the data base

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
