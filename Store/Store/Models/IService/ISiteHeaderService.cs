using Store.Models.DataBase.Dto.Customer;
using Store.Models.DataBase.Dto.Frount.Category;
using Store.Models.DataBase.Dto.Frount.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.IService
{
    interface ISiteHeaderService
    {
        /// <summary>
        /// دریافت دسته بندی ها
        /// </summary>
        /// <returns></returns>
        Category GetCategory();
        /// <summary>
        ///دریافت منو نویگیشن یا فوتر
        /// </summary>
        /// <returns></returns>
        NavBarMenu GetNavBarMenu();
        /// <summary>
        ///دریافت منو نویگیشن یا فوتر
        /// </summary>
        /// <returns></returns>
        NavBarMenu GetFooterMenu();
        /// <summary>
        /// دریافت اسلایدر
        /// </summary>
        /// <returns></returns>
        Slider GetSlider();

    }
}
