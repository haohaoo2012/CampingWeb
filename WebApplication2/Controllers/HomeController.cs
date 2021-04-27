using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using WebApplication2.App_Start;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
   
    public class HomeController : Controller
    {
        WebEntities db = new WebEntities();

        public ActionResult Index()
        {
            return View();
        }
       
       
        public ActionResult Sign()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sign(login log)
        {
            var login = db.logins.Where(x => x.user == log.user && x.pass == log.pass).Count();
            if (login > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
        public ActionResult Signup()
        {
            return View();
        }
    }
}