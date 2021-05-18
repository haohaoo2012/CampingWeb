using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using WebApplication2.Draw;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
   
    public class HomeController : Controller
    {
     
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sign()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult details()
        {
            return View();
        }
        public ActionResult NuiBaDen()
        {
            return View();
        }
        public ActionResult NhaTrang()
        {
            return View();
        }
        public ActionResult PhuYen()
        {
            return View();
        }
        public ActionResult Cocobeach()
        {
            return View();
        }
        public ActionResult LifeBeach()
        {
            return View();
        }
        public ActionResult DongCao()
        {
            return View();
        }
        public ActionResult Bavi()
        {
            return View();
        }
        public ActionResult CatTien()
        {
            return View();
        }
      
        public ActionResult CaoBang()
        {
            return View();
        }
        public ActionResult MaPiLeng()
        {
            return View();
        }
        public ActionResult TaDung()
        {
            return View();
        }
        public ActionResult Thanhtoan()
        {
            return View();
        }
        public ActionResult barbecue()
        {
            return View();
        }
        public ActionResult LoThan()
        {
            return View();
        }
        public ActionResult Leu()
        {
            return View();
        }
        public ActionResult Ghe()
        {
            return View();
        }
        public ActionResult Cui()
        {
            return View();
        }
        public ActionResult Tham()
        {
            return View();
        }
        public ActionResult Nuoc()
        {
            return View();
        }
        public ActionResult Yte()
        {
            return View();
        }
        public ActionResult Dia()
        {
            return View();
        }
        public ActionResult Noi()
        {
            return View();
        }
        public ActionResult Coca()
        {
            return View();
        }
        public ActionResult Thit()
        {
            return View();
        }
        //public ActionResult Sign(loginmodel model)
        //{
        //    //if(ModelState.IsValid)
        //    //{
        //    //    var draw = new userdraw();
        //    //    var result = draw.dn(model.user, model.pass);
        //    //    if (result)
        //    //    {
        //    //        var login = draw.GetById(model.user);

        //    //    }
        //    //    else
        //    //    {
        //    //        ModelState.AddModelError("", "Đăng nhập thất bại");
        //    //    }    
        //    //}    
        //    //return View("Index");
        //}
    }
}