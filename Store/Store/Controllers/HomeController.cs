using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Store.Models.Services;
namespace Store.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        [Route("/404")]
        public IActionResult PageNotFound()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ContactUs()
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ContactUs(int userRegister)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}