using Store.Models.DataBase.Dto.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.IService
{
    interface ISiteHeaderService
    {
        /// <summary>
        /// سبد خرید مشتری
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <returns></returns>
        Cart GetCartItems(string username);
        /// <summary>
        /// حذف یک محصول از سبد خرید مشتری
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="ItemId">آیدی محصول</param>
        /// <returns></returns>
        Cart DeleteCartItems(string username,int ItemId);

    }
}
