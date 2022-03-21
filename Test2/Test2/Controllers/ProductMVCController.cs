using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Test2.Models;

namespace Test2.Controllers
{
    public class ProductMVCController : Controller
    {
        HttpClient  client = new HttpClient();
        public ActionResult Index()
        {
            List<Product> Product_list = new List<Product>();
            client.BaseAddress = new Uri("https://localhost:44338/api/ProductApi");
            var response = client.GetAsync("ProductApi");
            response.Wait();

            var test = response.Result;
            if(test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Product>>();
                display.Wait();
                Product_list = display.Result;   

            }

            return View(Product_list);
        }

        public ActionResult create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult create(Product pro)
        {
            client.BaseAddress = new Uri("https://localhost:44338/api/ProductApi");
            var response = client.PostAsJsonAsync<Product>("ProductApi" ,pro);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View("create");
        }

        public ActionResult Details(int id)
        {
            Product e = null;
            client.BaseAddress = new Uri("https://localhost:44338/api/ProductApi");
            var response = client.GetAsync("ProductApi?id="+ id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Product>();
                display.Wait();
                e = display.Result;

            }

            return View(e);
        }



        public ActionResult Edit(int id)
        {
            Product p = null;
            client.BaseAddress = new Uri("https://localhost:44338/api/ProductApi");
            var response = client.GetAsync("ProductApi?Id=" + id.ToString());
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
            client.BaseAddress = new Uri("https://localhost:44338/api/ProductApi");
            var response = client.PutAsJsonAsync<Product>("ProductApi", p);
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
            Product c = null;
            client.BaseAddress = new Uri("https://localhost:44338/api/ProductApi");
            var response = client.GetAsync("ProductApi?Id=" + id.ToString());
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Product>();
                display.Wait();
                c = display.Result;
            }
            return View(c);
        }

        
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            client.BaseAddress = new Uri("https://localhost:44338/api/ProductApi");
            var response = client.DeleteAsync("ProductApi/" + id.ToString());
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