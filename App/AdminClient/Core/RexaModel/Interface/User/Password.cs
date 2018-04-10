using Core.RexaModel.ADONET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RexaModel.Interface.User
{
    class Password : Logger
    {
        public int Change(string Value, int UserId)
        {
            using (var db = new ADONET.MainModel())
            {
                var p = new PasswordSet { Value = Value, UserId = UserId };
                db.PasswordSet.Add(p);
                db.SaveChanges();
                return p.Id;
            }
        }
    }
}
