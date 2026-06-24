using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BestStore.Models;

namespace BestStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "BestStore is an online shopping platform offering quality products and services";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Get in touch with BestStore.";

            ViewData["Address"] = "123 Shopping Street, Ahmedabad, Gujarat, India";
            ViewData["Phone"] = "+91 98765 43210";
            ViewData["Email"] = "support@beststore.com";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
