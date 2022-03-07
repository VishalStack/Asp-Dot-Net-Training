using MVC_staffmanagement.DataAccess;
using MVC_staffmanagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_staffmanagement.Controllers
{
    public class StaffManagementController : Controller
    {
        // GET: StaffManagement
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult InsertData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertData(Staff objstaff)
        {
            objstaff.dob = Convert.ToDateTime(objstaff.dob);

            try
            {
                if (ModelState.IsValid)
                {
                    DataAccessLayer dal = new DataAccessLayer();

                    if (dal.InsertData(objstaff))
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


        public ActionResult ShowStaffList()
        {

            DataAccessLayer dal = new DataAccessLayer();
            ModelState.Clear();
            return View(dal.ShowStaffList());
        }

        public ActionResult EditData(int id)
        {
            DataAccessLayer dal = new DataAccessLayer();
            return View(dal.ShowStaffList().Find(c => c.id == id));

        }
        [HttpPost]
        public ActionResult EditData(int id, Staff obj)
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();

                dal.UpdateData(obj);
                return RedirectToAction("ShowStaffList");
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
                return RedirectToAction("ShowStaffList");

            }
            catch
            {
                return View();
            }
        }



    }

}
    