using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPartialDemo.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Students()
        {
            string[] arr = { "CS Students", "Aeronotical Students", "IT Students", "Civil Students", "Mechenical Students" };
            return PartialView("_students", arr);
        }

    }
}