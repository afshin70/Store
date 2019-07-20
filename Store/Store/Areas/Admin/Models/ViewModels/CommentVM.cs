using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Areas.Admin.Models.ViewModels
{
    public class CommentVM
    {
        [ScaffoldColumn(false)]
        /// <summary>
        /// آی دی
        /// </summary>
        public int CommentId { get; set; }
        [DisplayName("متن نظر:")]
        /// <summary>
        /// متن کامنت
        /// </summary>
        public string CommentText { get; set; }
        [DisplayName("نام ارسال کننده نظر:")]
        /// <summary>
        /// نام کاربر
        /// </summary>
        public string FullName { get; set; }
        [DisplayName("ایمیل:")]
        /// <summary>
        /// ایمیل
        /// </summary>
        public string Email { get; set; }
        [DisplayName("تاریخ ارسال:")]
        /// <summary>
        /// تاریخ ارسال کامنت
        /// </summary>
        public DateTime CommentedDate { get; set; }
        [DisplayName("وضعیت خواندن:")]
        /// <summary>
        /// وضعیت دیده شده توسط ادمین
        /// </summary>
        public bool IsSeen { get; set; }
        [DisplayName("تایید و نمایش:")]
        /// <summary>
        /// وضعیت تایید
        /// </summary>
        public bool IsVerified { get; set; }
        [DisplayName("وضعیت نمایش:")]
        /// <summary>
        /// وضعیت نمایش
        /// </summary>
        public bool IsShow { get; set; }
    }
}
