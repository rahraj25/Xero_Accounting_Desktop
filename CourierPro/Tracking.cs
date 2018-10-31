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
    public partial class Tracking : Form
    {
        public Tracking()
        {
            InitializeComponent();
        }

        private void button_trace_package_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            string _errormsg = null;

            if (string.IsNullOrEmpty(txtPackageNo.Text))
                _errormsg = "*Please enter your package no";
            else if (!int.TryParse(txtPackageNo.Text, out int a))
                _errormsg = "*Invalid package number";



            if (string.IsNullOrEmpty(_errormsg))
            {
                new Track_Package().ShowDialog();
                txtPackageNo.Text = string.Empty;
            }
            else
            {
                lblError.Text = _errormsg;
                lblError.Visible = true;
            }


        }
    }
}
