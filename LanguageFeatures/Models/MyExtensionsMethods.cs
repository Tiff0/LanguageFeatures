﻿using LanguageFeatures.Controllers;
using LanguageFeatures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public static class MyExtensionsMethods
    {
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)
            {
                total += prod.Price;
            }
            return total;
        }
    }
}