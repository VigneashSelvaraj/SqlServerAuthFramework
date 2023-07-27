using SqlServerAuthFramework.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace SqlServerAuthFramework.Controllers
{
    public class HomeController : Controller
    {
        AppDb db = new AppDb(); 
        public ActionResult IndexField()
        {
            var Field = db.Field;
            return View(Field);
        }
    }
}