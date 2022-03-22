using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test2.Models;
using System.Web.Security;


namespace Test2.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: Account

        //login
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
                    FormsAuthentication.SetAuthCookie(model.UserName,false);
                    return RedirectToAction("Index", "ClientMVC");
                }
                ModelState.AddModelError("", "Invalid Username or Password");
                return View();
            }
            
        }


        //signup
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(Users model)
        {
            using ( var Context = new Test2DBEntities())
            {
                Context.Users.Add(model);
                Context.SaveChanges();

            }
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}