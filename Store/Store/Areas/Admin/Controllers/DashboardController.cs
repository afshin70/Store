using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Areas.Admin.Models.ViewModels;
using Store.Models.DataBase.Dto.Admin;
using Store.Models.IService.Admin;
using Store.Models.Utility.Authorizetion;

namespace Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        IProductService PService;
        public DashboardController(IProductService productService)
        {
            PService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
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
            var result = PService.AddMainCategory(new MainCatrgory
            {
                EName = mainCategory.EName,
                IsActive = mainCategory.IsActive,
                Name = mainCategory.Name,
                OrderNumber = mainCategory.OrderNumber
            });
            if (!result)
            {
                return View(mainCategory);
            }
            return View();
        }


    }
}