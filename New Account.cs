using CourierPro.Common;
using CourierPro.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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
            if (cbAccountType.SelectedIndex != -1)
            {
                Console.WriteLine("changed value");
            }
        }

        bool EmptyCheck(string value) => string.IsNullOrEmpty(value);

        private void btn_save_account_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            var _firstName = txtFirstName.Text;
            var _lastName = txtLastName.Text;
            var _accountID = txtAccountId.Text;
            var _accountType = cbAccountType.Text;
            var _city = txtCity.Text;
            var _email = txtEmail.Text;

            var _errormsg = string.Empty;

            if (EmptyCheck(_firstName) || EmptyCheck(_lastName) || EmptyCheck(_accountID) || EmptyCheck(_accountType) || EmptyCheck(_city) || EmptyCheck(_email))
                _errormsg = "*Please fill every field";
            else if (!int.TryParse(_accountID, out int a))
                _errormsg = "*Invalid account number";
            else if (!Regex.IsMatch(_email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                _errormsg = "*Invalid email";

            if (string.IsNullOrEmpty(_errormsg))
            {
                var _personObj = new Data.Persons
                {
                    FirstName = _firstName,
                    LastName = _lastName,
                    AccountID = int.Parse(_accountID),
                    Email = _email
                };

                var _accountObj = new Data.Account
                {
                    AccountType = _accountType,
                    Location = Instance.Location,
                    Person = _personObj,
                    AccountNo = int.Parse(_accountID)

                };

                var _obj = new Db(DbEnum.Accounts);

                if (_obj.InsertAccount(_accountObj))
                {
                    txtFirstName.Text = txtLastName.Text = txtAccountId.Text = cbAccountType.Text = txtCity.Text = txtEmail.Text = null;

                    Instance._account.LoadContent();
                    Instance._account.Refresh();
                    this.Close();
                }
            }
            else
            {
                lblError.Text = _errormsg;
                lblError.Visible = true;
            }
        }

        private void New_Account_Load(object sender, EventArgs e)
        {

        }
    }
}
