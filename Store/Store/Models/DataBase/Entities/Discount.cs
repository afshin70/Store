using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// تخفیف
    /// </summary>
    public class Discount
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
        /// توضیحات
        /// </summary>
        public string Descriptions { get; set; }
        /// <summary>
        /// بیشترین درصد تخفیف
        /// </summary>
        public decimal MaxPercent { get; set; }
        /// <summary>
        /// بیشترین مبلغ تخفیف
        /// </summary>
        public decimal MaxPrice { get; set; }
        /// <summary>
        /// شروع تاریخ
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// پایان تاریخ
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// وضعیت حذف شدن
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
