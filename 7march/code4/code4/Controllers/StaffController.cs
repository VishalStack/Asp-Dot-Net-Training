using code4.Models;
using StaffMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace code4.Controllers
{
    public class StaffController : Controller
    {
        private StaffModel smodel;

        // GET: Staff

        public ActionResult Index()
        {
            StaffDBHandle dbhandle = new StaffDBHandle();
            ModelState.Clear();
            return View(dbhandle.GetStaff());
        }

        // GET: Staff/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Staff/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Staff/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: Staff/Edit/5
        public ActionResult Edit(int id)
        {
            StaffDBHandle sdb = new StaffDBHandle();
            return View(sdb.GetStaff().Find(smodel => (bool)(smodel.Id = id)));
        }

        // POST: Staff/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Staff/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Staff/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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

