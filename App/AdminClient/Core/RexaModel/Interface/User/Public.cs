
using Core.RexaModel.ADONET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RexaModel.Interface.User
{
    public class Public : Logger
    {
        public bool Login(string Username, string Password)
        {
            using (var db = new MainModel())
            {
                var query =
                    (
                       from a in db.UserSet
                       join c in db.Logger
                       on a.Id equals c.IndexId
                       join b in db.PasswordSet
                       on a.Id equals b.UserId
                       where a.Logger.MasterId == Username
                       select a

                    ).Where(x => x.PasswordSet.OrderByDescending(y => y.Id).FirstOrDefault().Value == Password);
                if (query.Count() == 1)
                    return true;
            }
            return false;
        }
        public override int Insert(string masterId, object o)
        {
            var newUser = o as ADONET.UserPasswordView;
            int id = base.Insert(masterId, newUser.Id);

            using (var db = new ADONET.MainModel())
            {
                if (db.UserView.Where(x => x.MasterId == newUser.MasterId).FirstOrDefault() != null)
                    throw new System.OperationCanceledException("Username is submitted before");
                ADONET.UserSet u = new ADONET.UserSet();
                u.Id = id;
                u.Image = newUser.Image;
                u.Firstname = newUser.Firstname;
                u.Lastname = newUser.Lastname;
                db.UserSet.Add(u);
                db.SaveChanges();
                new Core.RexaModel.Interface.User.Password().Change(newUser.Password, id);
            }
            return id;
        }
        public override int Update(string masterId, object o)
        {
            return Insert(masterId, o);
        }
    }
}