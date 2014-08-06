using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelerikMvcTest.Controllers
{
    /// <summary>
    /// HomeController
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}
