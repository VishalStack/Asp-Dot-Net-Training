using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Test2.Models;

namespace Test2.Controllers
{
    [AllowAnonymous]
    public class Account1Controller : Controller
    {
        // GET: Account1
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.Membership model)
        {
            using (var Context = new Test2DBEntities())
            {
                bool isValid = Context.Users.Any(x=>x.UserName == model.UserName && x.PassWord == model.PassWord);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index" , "ClientMVC");
                }
                ModelState.AddModelError("" , "Invalid UserName or Password");
                return View();
            }
                
        }


        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(User model)
        {
            using (var Context = new Test2DBEntities())
            {
              Context.Users.Add(model);
                Context.SaveChanges();
            }
            return RedirectToAction("login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}