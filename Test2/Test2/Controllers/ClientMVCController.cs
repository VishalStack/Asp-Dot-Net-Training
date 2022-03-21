using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Test2.Models;

namespace Test2.Controllers
{
    public class ClientMVCController : Controller
    {
        // GET: ClientMVC
        HttpClient  client = new HttpClient();
        public ActionResult Index()
        {
            List<Client> Client_list = new List<Client>();
            client.BaseAddress = new Uri("https://localhost:44338/api/ClientApi");
            var response = client.GetAsync("ClientApi");
            response.Wait();

            var test = response.Result;
            if(test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Client>>();
                display.Wait();
                Client_list = display.Result;   

            }

            return View(Client_list);
        }

        public ActionResult create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult create(Client cli)
        {
            client.BaseAddress = new Uri("https://localhost:44338/api/ClientApi");
            var response = client.PostAsJsonAsync<Client>("ClientApi" ,cli);
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
            Client e = null;
            client.BaseAddress = new Uri("https://localhost:44338/api/ClientApi");
            var response = client.GetAsync("ClientApi?id="+ id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Client>();
                display.Wait();
                e = display.Result;

            }

            return View(e);
        }

        public ActionResult Edit(int id)
        {
            Client e = null;
            client.BaseAddress = new Uri("https://localhost:44338/api/ClientApi");
            var response = client.GetAsync("ClientApi?id=" + id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Client>();
                display.Wait();
                e = display.Result;

            }

            return View(e);
        }

        [HttpPost]
        public ActionResult Edit(Client cli)
        {
            client.BaseAddress = new Uri("https://localhost:44338/api/ClientApi");
            var response = client.PutAsJsonAsync<Client>("ClientApi", cli);
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
            Client c = null;
            client.BaseAddress = new Uri("https://localhost:44338/api/ClientApi");
            var response = client.GetAsync("ClientApi?Id=" + id.ToString());
            response.Wait();
            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Client>();
                display.Wait();
                c = display.Result;
            }
            return View(c);
        }
        
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            client.BaseAddress = new Uri("https://localhost:44338/api/ClientApi");
            var response = client.DeleteAsync("ClientApi/" + id.ToString());
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