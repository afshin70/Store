using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Admin
{
    public class Catrgory
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int CategoryId { get; set; }
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
        public string Description { get; set; }
        /// <summary>
        /// شماره اولویت
        /// </summary>
        public int OrderNumber { get; set; }
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// آیا جزو دسته محبو ها است؟
        /// </summary>
        public bool IsFavorate { get; set; }
    }
}
