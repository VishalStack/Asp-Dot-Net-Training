using code4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace code4.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        //public ActionResult Index()
        //{
        //    StaffDBHandle dbhandle = new StaffDBHandle();
        //    ModelState.Clear();
        //    return View(dbhandle.GetStudent());
        //}

        //// GET: Staff/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Staff/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Staff/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            StaffDBHandle sdb = new StaffDBHandle();
        //            if (sdb.Create(smodel))
        //            {
        //                ViewBag.Message = "Staff Details Added Successfully";
        //                ModelState.Clear();
        //            }
        //        }
        //        return View();
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Staff/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    StaffDBHandle sdb = new StaffDBHandle();
        //    return View(sdb.GetStaff().Find(smodel => smodel.Id == id));
        //}

        //// POST: Staff/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{

        //        try
        //        {
        //            StaffDBHandle sdb = new StaffDBHandle();
        //            sdb.UpdateDetails(smodel);
        //            return RedirectToAction("Index");
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }

        //    // GET: Staff/Delete/5
        //    public ActionResult Delete(int id)
        //    {
        //        return View();
        //    }

        //    // POST: Staff/Delete/5
        //    [HttpPost]
        //    public ActionResult Delete(int id, FormCollection collection)
        //    {
        //        try
        //        {
        //            StaffDBHandle sdb = new StaffDBHandle();
        //            if (sdb.DeleteStaff(id))
        //            {
        //                ViewBag.AlertMsg = "Staff Deleted Successfully";
        //            }
        //            return RedirectToAction("Index");
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }



        // 1. *************RETRIEVE ALL STAFF DETAILS ******************
        // GET: Student
        public ActionResult Index()
        {
            StaffDBHandle dbhandle = new StaffDBHandle();
            ModelState.Clear();
            return View(dbhandle.GetStaff());
        }

        // 2. *************ADD NEW STAFF ******************
        // GET: Staff/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Staff/Create
        [HttpPost]
        public ActionResult Create(StaffModel smodel)
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

         //3. ************* EDIT STAFF DETAILS******************
         //GET: Staff/Edit/5
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

         //4. ************* DELETE STAFF DETAILS******************
         //GET: Staff/Delete/5
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

