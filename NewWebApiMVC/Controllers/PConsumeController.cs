using NewWebApiMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace NewWebApiMVC.Controllers
{
    public class PConsumeController : Controller
    {
        // GET: PConsume
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            List<Product> list = new List<Product>();
                client.BaseAddress = new Uri("https://localhost:44307/api/NewApi");
                var response = client.GetAsync("NewApi");
                response.Wait();  
                var test = response.Result;

                if (test.IsSuccessStatusCode)
                {
                    var display = test.Content.ReadAsAsync<IList<Product>>();
                    display.Wait();

                    list = (List<Product>)display.Result;
                }
        
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product pro)
        {
            client.BaseAddress = new Uri("https://localhost:44307/api/NewApi");
            var response = client.PostAsJsonAsync<Product>("NewApi",pro);
            response.Wait();
            var test = response.Result;

            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View("Create");
        }



        public ActionResult Details(int id)
        {
            Product p = null;
           
            client.BaseAddress = new Uri("https://localhost:44307/api/NewApi");
            var response = client.GetAsync("NewApi?id="+id.ToString());
            response.Wait();
            var test = response.Result;

            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Product>();
                display.Wait();

                p = display.Result;
            }

            return View(p);
        }


        public ActionResult Edit(int id)
        {
            Product p = null;

            client.BaseAddress = new Uri("https://localhost:44307/api/NewApi");
            var response = client.GetAsync("NewApi?id=" + id.ToString());
            response.Wait();
            var test = response.Result;

            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Product>();
                display.Wait();

                p = display.Result;
            }

            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(Product p)
        {
            client.BaseAddress = new Uri("https://localhost:44307/api/NewApi");
            var response = client.PutAsJsonAsync<Product>("NewApi", p);
            response.Wait();
            var test = response.Result;

            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View("Edit");
        }


        public ActionResult Delete(int id)
        {
            Product p = null;

            client.BaseAddress = new Uri("https://localhost:44307/api/NewApi");
            var response = client.GetAsync("NewApi?id=" + id.ToString());
            response.Wait();
            var test = response.Result;

            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Product>();
                display.Wait();

                p = display.Result;
            }

            return View(p);
        }

        [HttpPost,ActionName("Delete")]

        public ActionResult DeleteConfirmed(int id)
        {
            client.BaseAddress = new Uri("https://localhost:44307/api/NewApi");
            var response = client.DeleteAsync("NewApi/"+id.ToString());
            response.Wait();
            var test = response.Result;

            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View("Delete");
        }



    }
}