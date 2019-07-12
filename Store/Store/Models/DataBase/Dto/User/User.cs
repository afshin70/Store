using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.User
{
    public class User
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// نام کاربری
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// نام و نام خانوادگی
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// شماره تماس
        /// </summary>
        public string MobileNo { get; set; }
        /// <summary>
        /// بیوگرافی
        /// </summary>
        public string Biography { get; set; }
        /// <summary>
        /// جنسیت
        /// </summary>
        public bool Gender { get; set; }
        /// <summary>
        /// ایمیل
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// وضعیت تایید
        /// </summary>
        public bool IsVerified { get; set; }
        /// <summary>
        /// وضعیت بلاک بودن
        /// </summary>
        public bool IsBlock { get; set; }
    }
}
