using MvcWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MvcWebApi.Controllers
{
    public class ClientMvcController : Controller
    {
        HttpClient client = new HttpClient();

        // GET: ClientMvc
        public ActionResult Index()
        {
            List<Client> list = new List<Client>();
            client.BaseAddress = new Uri("https://localhost:44346/api/ClientApi");
            var response = client.GetAsync("ClientApi");
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Client>>();
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
        public ActionResult Create(Client cli)
        {

            List<Client> list = new List<Client>();
            client.BaseAddress = new Uri("https://localhost:44346/api/ClientApi");
            var response = client.PostAsJsonAsync<Client>("ClientApi", cli);
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
            Client c = null;
            client.BaseAddress = new Uri("https://localhost:44346/api/ClientApi");
            var response = client.GetAsync("ClientApi?id="+id.ToString());
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

        public ActionResult Edit(int id)
        {
            Client c = null;
            client.BaseAddress = new Uri("https://localhost:44346/api/ClientApi");
            var response = client.GetAsync("ClientApi?Id="+id.ToString());
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

        [HttpPost]
        public ActionResult Edit(Client c)
        {
           
            client.BaseAddress = new Uri("https://localhost:44346/api/ClientApi");
            var response = client.PutAsJsonAsync<Client>("ClientApi", c);
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
            client.BaseAddress = new Uri("https://localhost:44346/api/ClientApi");
            var response = client.GetAsync("ClientApi?Id="+ id.ToString());
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
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            client.BaseAddress = new Uri("https://localhost:44346/api/ClientApi");
            var response = client.DeleteAsync("ClientApi/"+ id.ToString());
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