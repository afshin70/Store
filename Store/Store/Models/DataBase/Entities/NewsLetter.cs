using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// خبرنامه
    /// </summary>
    public class NewsLetter
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ایمیل
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// وضعیت تایید
        /// </summary>
        public bool IsVerified { get; set; }
        /// <summary>
        /// کد تایید
        /// </summary>
        public string VerifyCode { get; set; }
        /// <summary>
        /// تاریخ ارسال کد تایید
        /// </summary>
        public DateTime VerifyCodeDate { get; set; }
        /// <summary>
        /// تاریخ تایید 
        /// </summary>
        public DateTime VerifiedDate { get; set; }
        /// <summary>
        /// وضعیت حذف
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
