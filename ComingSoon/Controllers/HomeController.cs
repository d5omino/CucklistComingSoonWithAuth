using System.Diagnostics;

using ComingSoon.Models;

using Microsoft.AspNetCore.Mvc;

namespace ComingSoon.Controllers
{
    public class HomeController:Controller
    {




        public Cucklist CompanyTitle = new Cucklist();
        public IActionResult Index()
        {


            ViewData["Title"] = CompanyTitle.CompanyName;
            return View();

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
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
