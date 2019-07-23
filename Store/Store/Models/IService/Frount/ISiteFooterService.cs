using Store.Models.DataBase.Dto.Frount;
using Store.Models.DataBase.Dto.Frount.Footer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.IService.Frount
{
    /// <summary>
    /// سرویس فوتر
    /// </summary>
    public interface ISiteFooterService
    {
        /// <summary>
        ///  عضویت در خبرنامه
        /// </summary>
        /// <param name="email">ایمیل</param>
        /// <returns></returns>
        bool SubscribeByEmail(string email);
        /// <summary>
        ///دریافت منو فوتر
        /// </summary>
        /// <returns></returns>
        FoterBarMenu GetFooterMenu();
    }
}
