using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// زیر دسته بندی
    /// </summary>
    public class SubCategory
    {
        /// <summary>
        /// آی دی 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// آی دی دسته بندی
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string Ename { get; set; }
        /// <summary>
        /// آیکن
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// شماره اولویت
        /// </summary>
        public int OrderNumber { get; set; }
        /// <summary>
        /// آدرس تصویر
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// وضعیت فال بودن
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// وضعیت حذف شدن
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
