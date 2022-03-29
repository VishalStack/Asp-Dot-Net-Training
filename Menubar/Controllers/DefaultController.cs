using Menubar.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Menubar.Controllers
{
    public class DefaultController : Controller
    {
        Data.db dblayer = new Data.db();

        public ActionResult Index()
        {
            DataSet ds = dblayer.get_category();
            ViewBag.category = ds.Tables[0];
            return View();
        }

        // Get submenu
        public void get_Submenu(int catid)
        {
            DataSet ds = dblayer.get_Subcategory(catid);
            List<Subcategory> submenulist = new List<Subcategory>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                submenulist.Add(new Subcategory
                {
                    Subcat_id = Convert.ToInt32(dr["Subcat_id"]),
                    Subcat_name = dr["Subcat_name"].ToString()
                });
            }
            Session["submenu"] = submenulist;
        }

        // Get Subtosubmenu
        public void get_Subtosubmenu(int Subcat_id)
        {
            DataSet ds = dblayer.get_SubtoSubcategory(Subcat_id);
            List<subtosubcategory> subtosubmenulist = new List<subtosubcategory>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                subtosubmenulist.Add(new subtosubcategory
                {
                    Subtosubcat_id = Convert.ToInt32(dr["Subcat_id"]),
                    Subtosubcat_Name = dr["SubtosubCat_Name"].ToString()
                });
            }
            Session["subtosubmenu"] = subtosubmenulist;
        }

       
    }
}