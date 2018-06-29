using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GitMVCApp.Models;

namespace GitMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutZuzeka()
        {
            MsZuzeka z = new MsZuzeka();
            z.Name = "Zuzeka";
            z.Surname = "Zimba";
            z.Age = "25";
            z.weight = 52;
            z.favouriteQuote = "Great things never come from comfort zones";

            return View(z);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
