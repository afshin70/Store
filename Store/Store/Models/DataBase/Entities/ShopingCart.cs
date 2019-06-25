using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// سبد خرید
    /// </summary>
    public class ShopingCart
    {
        /// <summary>
        /// آی دی کاربر
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// محصولات داخل سبد خرید
        /// </summary>
        public string ShopingCart_Json { get; set; }
        /// <summary>
        /// اخرین تاریخ تغییر
        /// </summary>
        public DateTime LastChangedDate { get; set; }
        /// <summary>
        /// جمع قیمت
        /// </summary>
        public decimal SumPrice { get; set; }
    }
}
