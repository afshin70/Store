using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Admin
{
    public class ContactUsMsg
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int MessageId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ایمیل
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// وضعیت دیده شدن پیام
        /// </summary>
        public bool IsSeen { get; set; }
        /// <summary>
        /// تاریخ ارسال
        /// </summary>
        public DateTime SendedDate { get; set; }
    }
}
