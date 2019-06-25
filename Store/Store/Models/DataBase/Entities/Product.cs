using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// محصول
    /// </summary>
    public class Product
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int Id { get; set; }
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
        /// آی دی دسته بندی
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// آی دی زیر دسته بندی
        /// </summary>
        public int SubCategoryId { get; set; }
        /// <summary>
        /// تعداد فروش
        /// </summary>
        public int SoldCount { get; set; }
        /// <summary>
        /// تعداد بادید
        /// </summary>
        public int VisitedCount { get; set; }
        /// <summary>
        /// تعداد موجود
        /// </summary>
        public int ExistCount { get; set; }
        /// <summary>
        /// بیشترین مبلغی که تخفیف مجاز است
        /// </summary>
        public decimal MaxDiscountPrice { get; set; }
        /// <summary>
        /// ویژگی ها بصورت جیسون
        /// </summary>
        public string Features_Json { get; set; }
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
        /// تاریخ افزودن محصول
        /// </summary>
        public DateTime InsertedDate { get; set; }
        /// <summary>
        /// وضعیت حذف
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// امتیاز کالا
        /// </summary>
        public int Rating { get; set; }
    }
}
