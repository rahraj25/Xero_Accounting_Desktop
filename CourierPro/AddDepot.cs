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
            lblError.Visible = false;

            var _depotEntity = new CourierPro.Entity.Db(Entity.DbEnum.Depots);

            var _name = txtdepotName.Text;
            var _contact = txtdepotContact.Text;
            var _address = txtdepotAddress.Text;

            //Validation maybe
            var _errormsg = string.Empty;

            if (!int.TryParse(_contact, out int num))
                _errormsg = "*Please enter a valid contact";
            if(string.IsNullOrEmpty(_name))
                _errormsg = "*Please enter a valid name";
            if (string.IsNullOrEmpty(_address))
                _errormsg = "*Please enter a valid address";


            if (string.IsNullOrEmpty(_errormsg))
            {
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

                }
            }

            else
            {
                lblError.Text = _errormsg;
                lblError.Visible = true;
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
