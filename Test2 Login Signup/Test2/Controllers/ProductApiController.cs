using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test2.Models;

namespace Test2.Controllers
{
    public class ProductApiController : ApiController
    {
        Test2DBEntities db = new Test2DBEntities();
        [HttpGet]
        public IHttpActionResult GetProduct()
        {
            List<Product> list = db.Products.ToList();
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult GetProductById(int id)
        {
            var cli = db.Products.Where(Models => Models.ProductId == id).FirstOrDefault();
            return Ok(cli);
        }

        [HttpPost]
        public IHttpActionResult Productinsert(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
            return Ok();
        }

        [System.Web.Http.HttpPut]
        public IHttpActionResult ProductUpdate(Product p)
        {
            var pro = db.Products.Where(model => model.ProductId == p.ProductId).FirstOrDefault();
            if (pro != null)
            {
                pro.ProductId = p.ProductId;
                pro.ProductName = p.ProductName;
                pro.Quantity = p.Quantity;
                pro.Price = p.Price;
                db.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ProductDelete(int id)
        {
            var pro = db.Products.Where(model => model.ProductId == id).FirstOrDefault();
            db.Entry(pro).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok();
        }
    }
}
