
using CourierPro.Common;
using CourierPro.Entity;
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
    public partial class Depot : Form
    {
        Db _depotEntity;
        public Depot()
        {
            InitializeComponent();
            _depotEntity = new CourierPro.Entity.Db();

            LoadDepots();

            dgDepots.Columns[0].Visible = false;
            AddButton("Edit");
            AddButton("Delete");
        }

        private void AddButton(string Btn)
        {
            var _btn = new DataGridViewButtonColumn();
            _btn.Text = Btn;
            _btn.Width = 8;
            _btn.UseColumnTextForButtonValue = true;
            dgDepots.Columns.Add(_btn);
        }

        public void LoadDepots()
        {
            var _collection = _depotEntity.GetAllDepots().Select(x => new
            {
                ID = x.Id,
                Name = x.Name,
                Address = x.Address,
                Contact = x.Contact

            }).ToList();
            dgDepots.DataSource = _collection;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddDepot().ShowDialog();
        }

        private void dgDepots_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dgDepots_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update
            if (e.ColumnIndex == 0)
            {
                var _drowCollection = dgDepots.Rows[e.RowIndex];
                _drowCollection.ReadOnly = false;
               
                dgDepots.BeginEdit(true);
            }
            //Delete
            else if (e.ColumnIndex == 1)
            {
                var _value = (Guid)dgDepots.Rows[e.RowIndex].Cells["ID"].Value;
                _depotEntity.DeleteDepot(_value);
                LoadDepots();
            }


        }

        private void dgDepots_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
        }
    }
}
