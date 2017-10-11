using MyWebAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebAPP.Controllers
{
    public class MyTempProdcutController : ApiController
    {
       MyTempProduct[] products = new MyTempProduct[]
       {
            new MyTempProduct { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new MyTempProduct { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new MyTempProduct { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
       };

        public IEnumerable<MyTempProduct> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
