﻿using CourierPro.Data;
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
            DataDisplay();
        }


        void DataDisplay()
        {

            var _dummylist = new List<Vehicle>();
            _dummylist.Add(new Vehicle() {rego = "CFR101", type = Vehicle.vehicleType.car, category = Vehicle.vehicleCategory.class1});

            dgVehicles.DataSource = _dummylist;
        }

        private void UpdateVehicle(Vehicle vehicle)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NewVehicle().Show();
        }
    }
}
