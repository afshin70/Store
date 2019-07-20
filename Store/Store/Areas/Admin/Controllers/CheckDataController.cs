using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CheckDataController : Controller
    {
        public JsonResult CheckMainCategoryEname(string EName)
        {
            var result = false;
            //چک کردن نام تکراری گروه اصلی
            return Json(result);

        }
        public JsonResult CheckMainCategoryName(string Name)
        {
            var result = false;
            //چک کردن نام تکراری گروه اصلی
            return Json(result);

        }
    }
}