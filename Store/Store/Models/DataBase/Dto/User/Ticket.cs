using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.User
{
    public class Ticket
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int TicketId { get; set; }
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// وضعیت دیده شدن پیام
        /// </summary>
        public bool IsSeen { get; set; }

        /// <summary>
        /// تاریخ ارسال
        /// </summary>
        public DateTime SendedDate { get; set; }
        /// <summary>
        /// سطح پیام پاسخ داده شده
        /// </summary>
        public int MessageLevel { get; set; }
        /// <summary>
        /// وضعیت حذف پیام
        /// </summary>
        public int IsDeleted { get; set; }
        /// <summary>
        /// تاریخ ارسال تیکت
        /// </summary>
        public DateTime TicketDate { get; set; }
    }
}
