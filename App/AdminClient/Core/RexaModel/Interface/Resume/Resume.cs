using Core.RexaModel.ADONET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RexaModel.Interface.Resume
{
    public class Resume:Logger
    {
        public override int Insert(string masterId, object o)
        {
            int id = base.Insert(masterId, null);

            using (var db = new ADONET.MainModel())
            {
                var u = o as ResumeSet;
                u.Id = id;
                db.ResumeSet.Add(u);
                db.SaveChanges();
            }
            return id;
        }

    }
}
