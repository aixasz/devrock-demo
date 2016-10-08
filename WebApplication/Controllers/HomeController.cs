using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        // Get: /Home/Index
        public IActionResult Index()
        {
            ViewBag.Message = "Hello World";
            return View();
        }

        public IActionResult Test() => View("Hello Devrock!");
    }
}
