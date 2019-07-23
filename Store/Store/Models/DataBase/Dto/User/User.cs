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
        /// نام کاربری - ایمیل
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
        /// آدرس
        /// </summary>
        public string Address_Json { get; set; }
        /// <summary>
        /// بیوگرافی
        /// </summary>
        public string Biography { get; set; }
        /// <summary>
        /// جنسیت
        /// </summary>
        public bool Gender { get; set; }
        /// <summary>
        /// گذر واژه
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// توکن ارسالی
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// مقدار ترکیب شده با گذر واژه
        /// </summary>
        public string Salt { get; set; }
        /// <summary>
        /// تاریخ ثبت نام
        /// </summary>
        public DateTime RegisterDate { get; set; }
        /// <summary>
        /// وضعیت تایید
        /// </summary>
        public bool IsVerified { get; set; }
        /// <summary>
        /// کد تایید
        /// </summary>
        public string ActivationCode { get; set; }
        /// <summary>
        /// تاریخ انقضا کد تایید
        /// </summary>
        public DateTime ActivationCodeExpireDate { get; set; }
        /// <summary>
        /// تاریخ بلاک
        /// </summary>
        public DateTime BlockedDate { get; set; }
        /// <summary>
        /// وضعیت بلاک بودن
        /// </summary>
        public bool IsBlock { get; set; }
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// تاریخ حذف
        /// </summary>
        public DateTime DeletedDate { get; set; }
        /// <summary>
        ///وضعیت حذف
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// محصولات مورد علاقه
        /// </summary>
        public string FavorateProduct_Json { get; set; }
        /// <summary>
        /// سبد خرید
        /// </summary>
        public string ShopingCart_Json { get; set; }
    }
}
