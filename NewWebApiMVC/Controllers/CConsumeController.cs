using NewWebApiMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace NewWebApiMVC.Controllers
{
    public class CConsumeController : Controller
    {
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            List<Client> list = new List<Client>();
            client.BaseAddress = new Uri("https://localhost:44307/api/SecondApi");
            var response = client.GetAsync("SecondApi");
            response.Wait();
            var test = response.Result;

            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<IList<Client>>();
                display.Wait();

                list = (List<Client>)display.Result;
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
            client.BaseAddress = new Uri("https://localhost:44307/api/SecondApi");
            var response = client.PostAsJsonAsync<Client>("SecondApi", cli);
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

            client.BaseAddress = new Uri("https://localhost:44307/api/SecondApi");
            var response = client.GetAsync("SecondApi?id=" + id.ToString());
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

            client.BaseAddress = new Uri("https://localhost:44307/api/SecondApi");
            var response = client.GetAsync("SecondApi?id=" + id.ToString());
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
            client.BaseAddress = new Uri("https://localhost:44307/api/SecondApi");
            var response = client.PutAsJsonAsync<Client>("SecondApi", c);
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

            client.BaseAddress = new Uri("https://localhost:44307/api/SecondApi");
            var response = client.GetAsync("SecondApi?id=" + id.ToString());
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
            client.BaseAddress = new Uri("https://localhost:44307/api/SecondApi");
            var response = client.DeleteAsync("SecondApi/" + id.ToString());
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