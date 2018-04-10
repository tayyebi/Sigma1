using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RexaModel.Interface
{
    public class Logger : Interface
    {
        public override int Insert(string masterId, object o)
        {
            base.Insert(masterId, o);
            DateTime dt = DateTime.Now;

            using (var db = new ADONET.MainModel())
            {
                ADONET.Logger l = new ADONET.Logger();
                l.MasterId = masterId;
                l.IsDeleted = false;
                l.EventDateTime = DateTime.Now;
                db.Logger.Add(l);
                db.SaveChanges();
                return l.IndexId;
            }
        }
        public override int Update(string masterId, object o)
        {
            return Insert(masterId, o);
        }
        public override int Delete(string masterId, object o)
        {
            base.Insert(masterId, o);
            DateTime dt = DateTime.Now;
            using (var db = new ADONET.MainModel())
            {
                ADONET.Logger l = new ADONET.Logger();
                l.MasterId = masterId;
                l.IsDeleted = true;
                l.EventDateTime = DateTime.Now;
                db.Logger.Add(l);
                db.SaveChanges();
                return l.IndexId;
            }
        }
    }
}
