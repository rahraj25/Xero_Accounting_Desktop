using CourierPro.Data;
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
    public partial class vehicles : Form
    {
        readonly Db _dbInstance;
        public vehicles()
        {
            InitializeComponent();
            _dbInstance = new Db(DbEnum.Vehicles);

            LoadContent();
        }



        public void LoadContent()
        {
            dgVehicles.DataSource = _dbInstance.GetAllVehicles()
                                                    .Select(x => new
                                                    {
                                                        x.rego,
                                                        x.type,
                                                        x.category

                                                    }).ToList();

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
