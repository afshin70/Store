using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Models.IService.Admin;

namespace Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CheckDataController : Controller
    {
        IProductService AdminProductService;
        public CheckDataController(IProductService _AdminProductService)
        {
            AdminProductService = _AdminProductService;
        }

                #region MainCategoryCheck
        public JsonResult CheckMainCategoryEname(string EName)
        {
            return Json(!AdminProductService.CheckExistMainCategoryEName(EName));
        }
        public JsonResult CheckMainCategoryName(string Name)
        {
            return Json(!AdminProductService.CheckExistMainCategoryName(Name));
        }
        public JsonResult CheckExistOneMainCategoryName(string Name, int MainCategoryId)
        {
            return Json(AdminProductService.CheckExistOneMainCategoryName(Name, MainCategoryId));
        }
        public JsonResult CheckExistOneMainCategoryEName(string EName, int MainCategoryId)
        {
            return Json(AdminProductService.CheckExistOneMainCategoryEName(EName, MainCategoryId));
        }

        #endregion

                #region CategoryCheck
        public JsonResult CheckExistCategoryEName(string EName)
        {
            return Json(!AdminProductService.CheckExistCategoryEName(EName));
        }
        public JsonResult CheckExistCategoryName(string Name)
        {
            return Json(!AdminProductService.CheckExistCategoryName(Name));
        }
        public JsonResult CheckExistOneCategoryName(string Name, int CategoryId)
        {
            return Json(AdminProductService.CheckExistOneCategoryName(Name,CategoryId));
        }
        public JsonResult CheckExistOneCategoryEName(string EName, int CategoryId)
        {
            return Json(AdminProductService.CheckExistOneCategoryEName(EName, CategoryId));
        }
              #endregion



    }
}