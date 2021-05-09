using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    //GET:ADMIN/LOGIN
    public class loginmodel
    {
        public string user { get; set; }
        public string pass { get; set; }
    }
}