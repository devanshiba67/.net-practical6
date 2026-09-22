
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class ProductController : Controller
    {
        // Product Catalog
        public ActionResult Index()
        {
            List<Product> products = GetProducts();

            return View(products);
        }


        // Product Details
        public ActionResult Details(int id)
        {
            List<Product> products = GetProducts();

            Product product = products.Find(p => p.Id == id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }


        // Product Data
        private List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 50000,
                    Category = "Electronics"
                },

                new Product
                {
                    Id = 2,
                    Name = "Mobile",
                    Price = 25000,
                    Category = "Electronics"
                },

                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Price = 2000,
                    Category = "Accessories"
                },

                new Product
                {
                    Id = 4,
                    Name = "Smart Watch",
                    Price = 4500,
                    Category = "Electronics"
                },

                new Product
                {
                    Id = 5,
                    Name = "Wireless Mouse",
                    Price = 1200,
                    Category = "Accessories"
                },

                new Product
                {
                    Id = 6,
                    Name = "Keyboard",
                    Price = 1800,
                    Category = "Accessories"
                }
            };

            return products;
        }
    }
}
