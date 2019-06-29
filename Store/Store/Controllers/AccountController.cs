using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Models.ViewModels;

namespace Store.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserAccountVM userLogin)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("Login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserAccountVM userRegister)
        {
            if (ModelState.IsValid)
            {

            }
            return View("Login");
        }

        [HttpGet]
        public IActionResult Profile()
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Profile(UserAccountVM userRegister)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePassword(UserAccountVM userRegister)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
        [HttpGet]
        public IActionResult Orders()
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Orders(UserAccountVM userRegister)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

        [HttpGet]
        public IActionResult Cart()
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cart(UserAccountVM userRegister)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

        [HttpGet]
        public IActionResult CheckOut()
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckOut(UserAccountVM userRegister)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}