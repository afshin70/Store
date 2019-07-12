using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Admin
{
    /// <summary>
    /// محصول
    /// </summary>
    public class Product
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// آی دی زیر دسته بندی
        /// </summary>
        public int SubCategoryId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        /// <summary>
        /// توضیحات کوتاه
        /// </summary>
        public string ShortDescription { get; set; }
        /// <summary>
        /// توضیحات اصلی
        /// </summary>
        public string MainDescription { get; set; }
        /// <summary>
        /// تصاویر
        /// </summary>
        public string Images_Json { get; set; }
        /// <summary>
        /// تگ محصول
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// برند کالا
        /// </summary>
        public int BrandId { get; set; }
        /// <summary>
        /// بیشترین مبلغی که تخفیف مجاز است
        /// </summary>
        public decimal MaxDiscountPrice { get; set; }
        /// <summary>
        /// تعداد موجود
        /// </summary>
        public int ExistCount { get; set; }
        /// <summary>
        /// ویژگی ها بصورت html
        /// </summary>
        public string Features { get; set; }
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        ///  واحد کالا
        /// </summary>
        public string UnitType { get; set; }
        /// <summary>
        /// مبلغ فروش
        /// </summary>
        public decimal SalesPrice { get; set; }
        /// <summary>
        /// مبلغ اصلی
        /// </summary>
        public decimal WrittenPrice { get; set; }
        /// <summary>
        /// محصول ویژه
        /// </summary>
        public bool IsSpecial { get; set; }
        /// <summary>
        /// هشدار کمتر از
        /// </summary>
        public int MinCountNotify { get; set; }
        /// <summary>
        /// امتیاز کالا
        /// </summary>
        public int Rating { get; set; }
        
    }
}
