using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// دسته بندی 
    /// </summary>
    public class Category
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// آی دی دسته بندی اصلی
        /// </summary>
        public int MainCategoryId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// نام لاتین
        /// </summary>
        public string EName { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Descriptions { get; set; }
        /// <summary>
        /// آدرس تصویر
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// آیکن دسته بندی
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// شماره اولویت
        /// </summary>
        public int OrderNumber { get; set; }
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsEnabled { get; set; }
        /// <summary>
        /// وضعیت حذف شدن
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// آیا جزو دسته محبو ها است؟
        /// </summary>
        public bool IsFavorate { get; set; }
    }
}
