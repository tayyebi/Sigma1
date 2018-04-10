using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RexaModel.Interface
{
    public class Interface
    {
        public virtual int Insert(string masterId, object o)
        {
            return Convert.ToInt32(o as string);
        }
        public virtual int Update(string masterId, object o)
        {
            return Convert.ToInt32(o as string);
        }
        public virtual int Delete(string masterId, object o)
        {
            return Convert.ToInt32(o as string);
        }
    }
}
