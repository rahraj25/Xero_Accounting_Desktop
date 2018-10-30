using CourierPro.Common;
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
    public partial class AddDepot : Form
    {
        public AddDepot()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var _depotEntity = new CourierPro.Entity.Db();

            var _name = txtdepotName.Text;
            var _contact = txtdepotContact.Text;
            var _address = txtdepotAddress.Text;

            //Validation maybe

            if (!int.TryParse(_contact, out int num))
                return;
            


            _depotEntity.InsertDepot(new Data.Depot()
            {
                Name = _name,
                Contact = int.Parse(_contact),
                Address = _address
            });

            var _result = MessageBox.Show("Inserted successfully!", "Alert", MessageBoxButtons.OK);

            if (_result == DialogResult.OK)
            {
                ClearValues();
                this.Close();

                Instance._depot.LoadDepots();
                Instance._depot.Refresh();

                //var _parent = new Depot();
                //DataGridView dgv = (DataGridView)_parent.Controls/*.ite*/;
            }

        }

        private void ClearValues()
        {
            txtdepotName.Clear();
            txtdepotContact.Clear();
            txtdepotAddress.Clear();
        }
    }
}
