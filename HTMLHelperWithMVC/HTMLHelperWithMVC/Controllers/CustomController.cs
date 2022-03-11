using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHelperWithMVC.Controllers
{
    public class CustomController : Controller
    {
        // GET: Custom
        public ActionResult Index()
        {
            return View();
        }
    }
}