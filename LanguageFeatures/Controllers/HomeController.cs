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

        public ViewResult CreateProduct()
        {
            Product product = new Product
            {
                ProductId = 100,
                Name = "Kayak",
                Description = "A boat for one person",
                Price = 275M,
                Category = "Watersports"
            };

            return View("Result",
                (object)String.Format("Category {0}", product.Category));
        }

        public ViewResult CreateCollection()
        {
            string[] stringArray = { "apple", "orange", "plum" };

            List<int> intList = new List<int> { 10, 20, 30, 40 };

            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                { stringArray[0], intList[0]},
                { stringArray[1], intList[1]},
                { stringArray[2], intList[2]}
            };

            return View("Result",
                (object)stringArray[1]);
        }
    }
}