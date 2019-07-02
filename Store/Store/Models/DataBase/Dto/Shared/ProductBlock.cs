using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Shared
{
    /// <summary>
    /// اطلاعات کالا در قالب بلاک
    /// </summary>
    public class ProductBlock
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// نام کالا
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// قمیت قبل
        /// </summary>
        public string OldPrice { get; set; }
        /// <summary>
        /// قیمیت جدید
        /// </summary>
        public string NewPrice { get; set; }
        /// <summary>
        /// آدرس تصویر
        /// </summary>
        public string TumbImageUrl { get; set; }
        /// <summary>
        /// ویژگی های مهم
        /// </summary>
        public List<string> ImportantFeuture { get; set; }
    }
}
