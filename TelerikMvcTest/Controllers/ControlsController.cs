using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Web.Mvc;
using TelerikMvcTest.Models;

namespace TelerikMvcTest.Controllers
{
    /// <summary>
    /// ControlsController
    /// </summary>
    public class ControlsController : Controller
    {
        /// <summary>
        /// GET: /Controls/
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GET: /Controls/Grid/
        /// </summary>
        /// <returns></returns>
        public ActionResult Grid()
        {
            return View();
        }

        private static List<Product> products = new List<Product>();

        static ControlsController()
        {
            var rnd = new Random();
            var categories = new string[] {
                "Cat",
                "Dog",
                "People",
            };
            for (int i = 0; i < 1000; ++i)
            {
                var id = i + 1;
                var price = decimal.Parse((rnd.Next() * rnd.NextDouble()).ToString());
                var category = categories[rnd.Next(categories.Count())];
                products.Add(new Product() { ID = id, Name = "Name" + id.ToString(), Price = price, Category = category });
            }
        }

        /// <summary>
        /// SelectProduct
        /// </summary>
        /// <returns></returns>
        //[HttpGet]
        [GridAction]
        public ActionResult SelectProduct()
        {
            return View(new GridModel(products));
        }

        /// <summary>
        /// InsertProduct
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [GridAction]
        public ActionResult InsertProduct()
        {
            var product = new Product();
            if (TryUpdateModel(product))
            {
                // Insert
                products.Add(product);
            }
            return View(new GridModel(products));
        }

        /// <summary>
        /// UpdateProduct
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [GridAction]
        public ActionResult UpdateProduct(int id)
        {
            var product = products.Find(p => p.ID == id);
            if (product != null)
            {
                if (TryUpdateModel(product))
                {
                    // Update
                }
            }
            return View(new GridModel(products));
        }

        /// <summary>
        /// DeleteProduct
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [GridAction]
        public ActionResult DeleteProduct(int id)
        {
            var product = products.Find(p => p.ID == id);
            if (product != null)
            {
                // Delete
                products.Remove(product);
            }
            return View(new GridModel(products));
        }
    }
}
