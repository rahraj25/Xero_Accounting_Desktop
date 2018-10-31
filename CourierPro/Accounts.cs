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
    public partial class Accounts : Form
    {
        readonly Db _dbInstance;
        public Accounts()
        {
            InitializeComponent();
            _dbInstance = new Db(DbEnum.Accounts);

            LoadContent();
        }


        public void LoadContent()
        {
            dgAccounts.DataSource = _dbInstance.GetAllAccounts()
                                                    .Select(x => new
                                                    {
                                                        Account = x.AccountNo,
                                                        Type = x.AccountType,
                                                        AccountHolder = x.Person.FirstName + x.Person.LastName
                                                    }).ToList();

        }

        private void btn_new_account_Click(object sender, EventArgs e)
        {
            new New_Account().ShowDialog();
        }
    }
}
