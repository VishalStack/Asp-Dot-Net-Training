using StaffMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaffMvcApp.Models
{
    public class StaffController : Controller
    {
        public ActionResult Index()
        {
            StaffDBHandle dbhandle = new StaffDBHandle();
            ModelState.Clear();
            return View(dbhandle.GetStaff());
        }

        
        public ActionResult AddStaff()
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult AddStaff(StaffModel smodel)
        {
           
            try
            {

                if (ModelState.IsValid)
                {
                    StaffDBHandle sdb = new StaffDBHandle();
                    if (sdb.AddStaff(smodel))
                    {
                        ViewBag.Message = "Staff Details Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(int id)
        {
            StaffDBHandle sdb = new StaffDBHandle();
            return View(sdb.GetStaff().Find(smodel => smodel.Id == id));
        }

        [HttpPost]
        public ActionResult Edit(int id, StaffModel smodel)
        {
            try
            {
                StaffDBHandle sdb = new StaffDBHandle();
                sdb.UpdateDetails(smodel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Delete(int id)
        {
            try
            {
                StaffDBHandle sdb = new StaffDBHandle();
                if (sdb.DeleteStaff(id))
                {
                    ViewBag.AlertMsg = "Staff Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}