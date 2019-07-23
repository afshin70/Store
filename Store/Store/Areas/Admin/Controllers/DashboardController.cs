using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Areas.Admin.Models.ViewModels;
using Store.Models.DataBase.Entities;
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
        #region Dashboard
        public IActionResult Index()
        {
            return View();
        }
        #endregion


        #region MainCategory
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
            var result = PService.AddMainCategory(new MainCategory
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
        [HttpGet]
        public IActionResult EditMainCategory(int? MainCategoryId)
        {
            if (!MainCategoryId.HasValue)
                return BadRequest();
            var MainCategory = PService.GetMainCategory(MainCategoryId.Value);
            if (MainCategory!=null)
            {
                return View(MainCategory);
            }
            return BadRequest();
        }
        [HttpPost]
        public IActionResult EditMainCategory(MainCategory mainCategory)
        {
            if (mainCategory==null)
                return BadRequest();
         
            if (PService.UpdateMainCaregory(mainCategory,mainCategory.MainCategoryId))
            {
                return View("MainCategory");
            }
            return BadRequest();
        }
        [HttpPost]
        public ActionResult DeleteMainCategory(int main_category_id)
        {
            bool Result = false;
            if (PService.RemoveMainCategory(main_category_id))
            {
                Result = true;
            }
            return Json(Result);
        }
        #endregion


    }
}