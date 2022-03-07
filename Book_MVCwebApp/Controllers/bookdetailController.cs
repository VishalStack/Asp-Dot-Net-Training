using Book_MVCwebApp.DataAccess;
using Book_MVCwebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Book_MVCwebApp.Controllers
{
    public class bookdetailController : Controller
    {
        // GET: bookdetail
        /*
          public ActionResult Index()
          {
              return View();
          }
        */
        public ActionResult AddBookData()
        {
            return View();
        }

        // POST: Employee/AddEmployee    
        [HttpPost]
        public ActionResult AddBookData(Book obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DataAccessLayer dal = new DataAccessLayer();

                    if (dal.AddBookData(obj))
                    {
                        ViewBag.Message = "Employee details added successfully";
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult GetBookData()
        {

            DataAccessLayer dal = new DataAccessLayer();
            ModelState.Clear();
            return View(dal.GetBookData());
        }

        public ActionResult EditData(int id)
        {
             DataAccessLayer dal = new DataAccessLayer();
            return View(dal.GetBookData().Find(c => c.BookId == id));

        } 
        [HttpPost]
        public ActionResult EditData(int id, Book obj)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();

                dal.UpdateData(obj);
                return RedirectToAction("GetBookData");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeleteData(int id)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                if (dal.DeleteData(id))
                {
                    ViewBag.AlertMsg = "Employee details deleted successfully";

                }
                return RedirectToAction("GetBookData");

            }
            catch
            {
                return View();
            }
        }

    }
}