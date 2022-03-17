using MvcWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApi.Controllers
{
    public class ProductMvcController : Controller
    {
        HttpClient client = new HttpClient(); 
        // GET: ProductMvc
        public ActionResult Index()
        {
            List<Product> list = new List<Product>();
            client.BaseAddress = new Uri("https://localhost:44346/api/ProductApi");
            var response = client.GetAsync("ProductApi");
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Product>>();
                display.Wait();
                list = display.Result;
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

            List<Product> list = new List<Product>();
            client.BaseAddress = new Uri("https://localhost:44346/api/ProductApi");
            var response = client.PostAsJsonAsync<Product>("ProductApi",pro);
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
            client.BaseAddress = new Uri("https://localhost:44346/api/ProductApi");
            var response = client.GetAsync("ProductApi?id="+ id.ToString());
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
            client.BaseAddress = new Uri("https://localhost:44346/api/ProductApi");
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

            client.BaseAddress = new Uri("https://localhost:44346/api/ProductApi");
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
            Product p = null;
            client.BaseAddress = new Uri("https://localhost:44346/api/ProductApi");
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
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            client.BaseAddress = new Uri("https://localhost:44346/api/ProductApi");
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