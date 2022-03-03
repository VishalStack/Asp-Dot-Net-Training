using CRUD_cutomerApp.DataAccess;
using CRUD_cutomerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_cutomerApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult InsertCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertCustomer(Customer objCustomer)
        {
            objCustomer.bdate = Convert.ToDateTime(objCustomer.bdate);

            if (ModelState.IsValid) 
            {
                DataAccessLayer objDB = new DataAccessLayer();
                string result = objDB.InsertData(objCustomer);
                ViewData["result"] = result;
                ModelState.Clear(); //clearing model
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Error in saving data");
                return View();
            }
        }

        [HttpGet]
        public ActionResult ShowAllCustomerDetails()
        {
            
            DataAccessLayer objDB = new DataAccessLayer(); //calling class DBdata
            ModelState.Clear();
            return View(objDB.Selectalldata());
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            
            DataAccessLayer objDB = new DataAccessLayer(); //calling class DBdata
            return View(objDB.Selectalldata().Find(Cust => Cust.customerId==id));

        }

        [HttpPost]

        public ActionResult Edit(int id,Customer objCustomer)
        {
            objCustomer.bdate = Convert.ToDateTime(objCustomer.bdate);

            if (ModelState.IsValid) 
            {
                DataAccessLayer objDB = new DataAccessLayer(); 
                objDB.UpdateData(objCustomer);
                
                return RedirectToAction("ShowAllCustomerDetails");
            }
            else
            {
                ModelState.AddModelError("", "Error in saving data");
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                DataAccessLayer dt = new DataAccessLayer();
                if (dt.DeleteData(id))
                {
                    ViewBag.AlertMsg = "Employee details deleted successfully";

                }
                return RedirectToAction("ShowAllCustomerDetails");

            }
            catch
            {
                return View();
            }

        }

        //[HttpPost]
        //public ActionResult Delete(Customer objCustomer)
        //{
        //    DataAccessLayer objDB = new DataAccessLayer();
        //    string result = objDB.DeleteData(objCustomer);
        //    ViewData["result"] = result;
        //    ModelState.Clear(); 
        //    return View();

        //}


    }
}