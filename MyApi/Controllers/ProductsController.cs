using MyApi.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace MyApi.Controllers
{
    [RoutePrefix("api/Products")]
    public class ProductsController : ApiController
    {
        List<ProductModel> products = new List<ProductModel>();

        public ProductsController()
        {
            GetSampleProducts();
        }
       
        [Route("get")]
        public IEnumerable<ProductModel> get()
        {
            return products;
        }

        public ProductModel getProductById(int pId)
        {
            var product = products.FirstOrDefault(p => p.ProductId == pId);
                return product;
        }

        public void GetSampleProducts()
        {
            products.Add(new ProductModel { ProductId = 1, Name = "Farah", Description = "Mother", Price = 10 });
            products.Add(new ProductModel { ProductId = 2, Name = "Faraz", Description = "son", Price = 10 });
            products.Add(new ProductModel { ProductId = 3, Name = "Zoha", Description = "daughter", Price = 10 });
        }

    }
}