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

        #region Category
        [HttpGet]
        public IActionResult Category()
        {
           
            return View(null);
        }
        [HttpPost]
        public IActionResult Category(CategoryAddVM category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            var result = PService.AddCategory(new Category
            {
                EName = category.EName,
                IsActive = category.IsActive,
                Name = category.Name,
                OrderNumber = category.OrderNumber,
                Description=category.Description,
                IsFavorate=category.IsFavorate,
                MainCategoryId=category.MainCategoryId
            });
            if (!result)
            {
                ModelState.AddModelError(nameof(category.Name), "خطایی ناخواسته رخ داده است لطفا بعدا دوباره امتحان کنید.");
                return View(category);
            }
            return View();
        }
        [HttpGet]
        public IActionResult EditeCategory(int? id)
        {
            if (id.HasValue)
            {
                var category = PService.GetCategory(id.Value);
                if (category != null)
                {
                    CategoryEditedVM editedVM = new CategoryEditedVM
                    {
                        CategoryId=category.CategoryId,
                        EName = category.EName,
                        IsActive = category.IsActive,
                        MainCategoryId = category.MainCategoryId,
                        Name = category.Name,
                        OrderNumber = category.OrderNumber,
                        Description=category.Description,
                        IsFavorate=category.IsFavorate
                    };
                    return View(editedVM);
                }
            }
            return BadRequest();
        }
        [HttpPost]
        public IActionResult EditeCategory(CategoryEditedVM Category)
        {
            if (Category == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest();


            if (PService.UpdateCaregory(new Category
            {
                EName = Category.EName,
                IsActive = Category.IsActive,
                Name = Category.Name,
                OrderNumber = Category.OrderNumber,
                MainCategoryId = Category.MainCategoryId,
                Description=Category.Description,
                IsFavorate=Category.IsFavorate,
                CategoryId=Category.CategoryId
            }, Category.CategoryId))
            {
                return RedirectToAction("Category");
            }
            return BadRequest();
        }
        [HttpPost]
        public IActionResult DeleteCategory(int category_id)
        {
            var state = PService.RemoveCategory(category_id);
            return new JsonResult(state);
        }
        [HttpPost]
        public IActionResult LevelUpCategory(int category_id)
        {
            var state = PService.LevelUpCategory(category_id);
            return new JsonResult(state);
        }
        [HttpPost]
        public IActionResult LevelDownCategory(int category_id)
        {
            var state = PService.LevelDownCategory(category_id);
            return new JsonResult(state);
        }
        #endregion
        #region MainCategory
        [HttpGet]
        public IActionResult MainCategory()
        {
            return View(null);
        }
        [HttpPost]
        public IActionResult MainCategory(MainCategoryAddVM mainCategory)
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
                ModelState.AddModelError(nameof(mainCategory.Name), "خطایی ناخواسته رخ داده است لطفا بعدا دوباره امتحان کنید.");
                return View(mainCategory);
            }
            return View();
        }
        [HttpGet]
        public IActionResult EditeMainCategory(int? id)
        {
            if (id.HasValue)
            {
                var category = PService.GetMainCategory(id.Value);
                if (category!=null)
                {
                    MainCategoryEditedVM mainCategory = new MainCategoryEditedVM {

                        EName=category.EName,IsActive=category.IsActive,MainCategoryId=category.MainCategoryId,Name=category.Name,OrderNumber=category.OrderNumber
                    };
                    return View(mainCategory);
                }
            }
            return BadRequest();
        }
        [HttpPost]
        public IActionResult EditeMainCategory(MainCategoryEditedVM mainCategory)
        {
            if (mainCategory==null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest();

            
            if (PService.UpdateMainCaregory(new MainCategory
            {
                EName = mainCategory.EName,
                IsActive = mainCategory.IsActive,
                Name = mainCategory.Name,
                OrderNumber = mainCategory.OrderNumber,
                MainCategoryId=mainCategory.MainCategoryId
            },mainCategory.MainCategoryId))
            {
                return RedirectToAction("MainCategory");
            }
            return BadRequest();
        }
        [HttpPost]
        public IActionResult DeleteMainCategory(int main_category_id)
        {
            var state = PService.RemoveMainCategory(main_category_id);
            return new JsonResult(state);
        }
        [HttpPost]
        public IActionResult LevelUp(int main_category_id)
        {
            var state = PService.LevelUpMainCategory(main_category_id);
            return new JsonResult(state);
        }
        [HttpPost]
        public IActionResult LevelDown(int main_category_id)
        {
            var state = PService.LevelDownMainCategory(main_category_id);
            return new JsonResult(state);
        }
        #endregion


    }
}