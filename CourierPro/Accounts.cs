using CourierPro.Data;
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
        List<Account> _accounts;
        public Accounts()
        {
            _accounts = new List<Account>();
            InitializeComponent();
            LoadContent();


            DataDisplay();


        }

        void LoadContent()
        {
            var _account = new Account() { AccountNo = 1, Person = new Persons { PersonID = 1, Name = "Test", Email = "Test@xyz.com" } };
            _accounts.Add(_account);
        }



        void DataDisplay()
        {
            dgAccounts.DataSource = _accounts.Select(x => new { Account = x.AccountNo, Type = x.AccountType, AccountHolder = x.Person.Name }).ToList(); 

        }
    }
}
