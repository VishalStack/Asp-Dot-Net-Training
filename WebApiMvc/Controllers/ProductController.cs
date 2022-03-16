using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiMvc.Models;

namespace WebApiMvc.Controllers
{
    public class ProductController : ApiController
    {
        public IHttpActionResult GetProduct()
        {
            TestEntities cm = new TestEntities();
            var results = cm.Product.ToList();
            return Ok(results);
        }

    }
}
