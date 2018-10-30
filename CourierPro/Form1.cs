﻿using CourierPro.Common;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //test
        }

        private void DepotLocationSelected(object sender, EventArgs e)
        {
            if (DepotLocations.SelectedIndex != -1)
            {
                Instance.Location = ((ComboBox)sender).Text;
                Console.WriteLine("changed value");
                ToggleBtns(true);
            }
        }

        private void ToggleBtns(bool allEnabled)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = allEnabled;
                }
            }
        }

        private bool checkBtnsAreOkay()
        {
            if (btnAccounts.Enabled == false)
            {
                MessageBox.Show("Error", "Please select a Depot first", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void btnDepotMngemnt_Click(object sender, EventArgs e)
        {
            Instance._depot = new Depot();
            Instance._depot.Show();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            Accounts accountsForm = new Accounts();
            accountsForm.Show();
        }

        private void btnTracking_Click(object sender, EventArgs e)
        {
            Tracking trackingForm = new Tracking();
            trackingForm.Show();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            vehicles vehicleForm = new vehicles();
            vehicleForm.Show();
        }

        private void btnIM_Click(object sender, EventArgs e)
        {
            new Inventory_Management().Show();
        }
    }
}
