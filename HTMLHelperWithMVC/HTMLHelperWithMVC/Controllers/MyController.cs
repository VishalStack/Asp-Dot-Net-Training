using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHelperWithMVC.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Temp()
        {
            return View();
        }
    }
}