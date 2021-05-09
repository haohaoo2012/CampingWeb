using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.EF;

namespace WebApplication2.Draw
{
    public class userdraw
    {
        Model1 db = null;
        public userdraw()
        {
            db = new Model1();
        }
        public string Insert (login entity)
        {
           db.logins.Add(entity);
            db.SaveChanges();
            return entity.user;
        }
        public login GetById(string user)
        {
            return db.logins.SingleOrDefault(x => x.user == user);
        }
        public bool dn(string user, string pass)
        {
            var result = db.logins.Count(x => x.user == user && x.pass == pass);
            if(result>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}