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
    public partial class New_Account : Form
    {
        public New_Account()
        {
            InitializeComponent();
        }

        private void cb_account_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_account_type.SelectedIndex != -1)
            {
                Console.WriteLine("changed value");
            }
        }
    }
}
