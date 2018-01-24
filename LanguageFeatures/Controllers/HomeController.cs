using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }

        public ViewResult AutoProperty()
        {
            Product product = new Product
            {
                Name = "Kayak"
            };

            return View("Result",
                (object) String.Format("Product name: {0}", product.Name.ToString()));
        }
    }
}