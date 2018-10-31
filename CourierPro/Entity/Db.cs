﻿using CourierPro.Common;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierPro.Entity
{
    public class Db
    {
        readonly LiteDatabase _db;
        string table;
        public Db(DbEnum value)
        {
            _db = new LiteDatabase(@"CourierPro.db");
            table = value.ToString();
        }


        #region Depots
        public IEnumerable<Data.Depot> GetAllDepots()
        {
            return _db.GetCollection<Data.Depot>(table)
                                .Find(a => a.Location == Instance.Location);
        }
        public void InsertDepot(Data.Depot depot)
        {
            depot.Location = Instance.Location;
            _db.GetCollection<Data.Depot>(table).Insert(depot);
        }
        public void DeleteDepot(Guid value)
        {
            _db.GetCollection<Data.Depot>(table).Delete(value);
        }
        #endregion


        #region Accounts
        public IEnumerable<Data.Account> GetAllAccounts()
        {
            return _db.GetCollection<Data.Account>(table).Find(a => a.Location == Instance.Location);
        }
        public bool InsertAccount(Data.Account account)
        {
            _db.GetCollection<Data.Account>(table).Insert(account);
            return true;
        }
        public void DeleteAccount(Guid value)
        {
            _db.GetCollection<Data.Account>(table).Delete(value);
        }

        #endregion

    }
}
