using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsWebAPI.Models;

namespace ProductsWebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id=1, ProductName="WebAPIProd1" },
            new Product { Id=1, ProductName="WebAPIProd2" },
            new Product { Id=1, ProductName="WebAPIProd3" }
        };

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
