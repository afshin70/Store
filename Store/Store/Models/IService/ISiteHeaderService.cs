using Store.Models.DataBase.Dto.Customer;
using Store.Models.DataBase.Dto.Frount.Category;
using Store.Models.DataBase.Dto.Frount.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.IService
{
    /// <summary>
    /// سرویس هدر سایت و بنر صفحه اصلی
    /// </summary>
    interface ISiteHeaderService
    {
        /// <summary>
        /// دریافت دسته بندی ها
        /// </summary>
        /// <returns></returns>
        Category GetCategory();
        /// <summary>
        ///دریافت منو نویگیشن
        /// </summary>
        /// <returns></returns>
        NavBarMenu GetNavBarMenu();
        /// <summary>
        ///دریافت منو فوتر
        /// </summary>
        /// <returns></returns>
        NavBarMenu GetFooterMenu();
        /// <summary>
        /// دریافت اسلایدر
        /// </summary>
        /// <returns></returns>
        Slider GetSlider();
        /// <summary>
        /// دریافت تصویر بنر و ...
        /// </summary>
        /// <returns></returns>
        Banner GetBanner();

    }
}
