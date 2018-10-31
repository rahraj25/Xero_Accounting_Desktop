
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
            InitializeGrid();


            _depotEntity = new CourierPro.Entity.Db(DbEnum.Depots);

            LoadDepots();

            dgDepots.Columns[0].Visible = false;


        }

        void InitializeGrid() {

            var colId = new DataGridViewTextBoxColumn { HeaderText = "Id" };
            var colDepot = new DataGridViewTextBoxColumn { HeaderText = "Depot" };
            var colAddress = new DataGridViewTextBoxColumn { HeaderText = "Address" };
            var colContact = new DataGridViewTextBoxColumn { HeaderText = "Contact" };

            var colSave = new DataGridViewButtonColumn { };
            var colDelete = new DataGridViewButtonColumn { };

           // colDepot.ReadOnly = colAddress.ReadOnly = colContact.ReadOnly = true;

            dgDepots.Columns.AddRange(colId, colDepot, colAddress, colContact, colSave, colDelete);

        }

        private void AddButton(string Btn)
        {
            var _btn = new DataGridViewButtonColumn();
            _btn.Text = Btn;
            _btn.Width = 8;
            _btn.UseColumnTextForButtonValue = true;
            dgDepots.Columns.Add(_btn);
        }

        private void AddRows(IEnumerable<Data.Depot> collection)
        {
            dgDepots.Rows.Clear();

            var _refined = collection.Select(x => new
            {
                ID = x.Id,
                Name = x.Name,
                Address = x.Address,
                Contact = x.Contact

            }).ToList();

            foreach (var item in _refined)
                dgDepots.Rows.Add(item.ID, item.Name, item.Address, item.Contact, "Edit", "Delete");

        }

        public void LoadDepots()
        {
            var _collection = _depotEntity.GetAllDepots();
            AddRows(_collection);

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
            //textboxes maybe
            if (e.ColumnIndex == 4)
            {
                var _drowCollection = dgDepots.Rows[e.RowIndex];
                _drowCollection.ReadOnly = false;
                
                dgDepots.EditMode = DataGridViewEditMode.EditOnEnter;
                dgDepots.CurrentRow.ReadOnly = false;
                dgDepots.BeginEdit(true);
            }
            //Delete
            else if (e.ColumnIndex == 5)
            {
                var _value = (Guid)dgDepots.Rows[e.RowIndex].Cells[0].Value;
                _depotEntity.DeleteDepot(_value);
                LoadDepots();
            }


        }

        private void dgDepots_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void dgDepots_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDepots.CurrentRow != null) {

                var test = dgDepots.CurrentRow;
            }
        }
    }
}
