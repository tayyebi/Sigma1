using Core.RexaModel.ADONET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RexaModel.Interface.Resume
{
    public class Job : Resume
    {
        public override int Insert(string masterId, object o)
        {

            int id = base.Insert(masterId, o);

            using (var db = new MainModel())
            {
                db.JobSet.Add(new JobSet { Id = id });
            }

            return id;

        }
    }
}
