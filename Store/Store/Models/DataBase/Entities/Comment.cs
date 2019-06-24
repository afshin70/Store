using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// کامنت
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// آی دی مطلب ارسال شده
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// متن کامنت
        /// </summary>
        public string CommentText { get; set; }
        /// <summary>
        /// نام کاربر
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// ایمیل
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// تاریخ ارسال کامنت
        /// </summary>
        public DateTime CommentedDate { get; set; }
    }
}
