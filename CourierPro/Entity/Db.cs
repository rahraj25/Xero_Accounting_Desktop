using CourierPro.Common;
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
        LiteCollection<Data.Depot> _depots;
        const string TABLE = "Depots";

        public Db()
        {
            _db = new LiteDatabase(@"CourierPro.db");
            _depots = _db.GetCollection<Data.Depot>(TABLE);
        }


        public IEnumerable<Data.Depot> GetAllDepots()
        {
            return _depots.Find(a=>a.Location== Instance.Location);
        }

        public void InsertDepot(Data.Depot depot)
        {
            depot.Location = Instance.Location;
            _depots.Insert(depot);
        }

        public void DeleteDepot(Guid value)
        {
            _depots.Delete(value);
        }

    }
}
