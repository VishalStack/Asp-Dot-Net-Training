using MvcWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcWebApi.Controllers
{
    public class ProductApiController : ApiController
    {
        ExamEntities db = new ExamEntities();

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetProducts()
        {
            List<Product> list = db.Products.ToList();
            return Ok(list);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetProductById(int id)
        {
            var pro = db.Products.Where(model => model.ProductId == id).FirstOrDefault();
            return Ok(pro);
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult ProductInsert(Product p)
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

        [System.Web.Http.HttpDelete]
        public IHttpActionResult ProductDelete(int id)
        {
            var pro = db.Products.Where(model => model.ProductId == id).FirstOrDefault();
            db.Entry(pro).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok();
        }
    }
}
