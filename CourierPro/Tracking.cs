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
            if(!string.IsNullOrEmpty(textBox_enter_package_no.Text))
            {
                new Track_Package().Show();
            }
            else
            {
                MessageBox.Show("Please enter your package no");
            }     
        }
    }
}
