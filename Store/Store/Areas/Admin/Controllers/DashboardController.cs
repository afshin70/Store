using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Areas.Admin.Models.ViewModels;
using Store.Models.Utility.Authorizetion;

namespace Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MainCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MainCategory(MainCategoryVM mainCategory)
        {
            if (!ModelState.IsValid)
            {
                return View(mainCategory);
            }
            return View();
        }

    }
}