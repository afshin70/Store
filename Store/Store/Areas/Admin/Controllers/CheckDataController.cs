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
        public JsonResult CheckMainCategoryEname(string EName)
        {
            return Json(!AdminProductService.CheckExistMainCategoryEName(EName));
        }
        public JsonResult CheckMainCategoryName(string Name)
        {
            return Json(!AdminProductService.CheckExistMainCategoryName(Name));
        }
    }
}