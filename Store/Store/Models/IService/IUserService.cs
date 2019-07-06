using Store.Models.DataBase.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.IService
{
    interface IUserService
    {
        /// <summary>
        /// دریافت اطلاعات یوزر با نام کاربری
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <returns></returns>
         User GetUserByUsername(string username);
        /// <summary>
        /// چک کردن توکن برای تغییرات رمز ورود
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="Token">توکن کاربر</param>
        /// <returns></returns>
         bool CheckUserPasswordChange(string username,string Token);
        /// <summary>
        /// دریافت اطلاعات یوزر با آی دی
        /// </summary>
        /// <param name="UserId">آی دی کاربر</param>
        /// <returns></returns>
         User GetUserById(int UserId);
        /// <summary>
        /// تغیر رمز کاربری
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="old_passwor">رمز ورود قبلی</param>
        /// <param name="new_password">رمز ورود جدید</param>
        /// <returns></returns>
        bool ChangePassword(string username,string old_passwor,string new_password);
        /// <summary>
        /// ارسال ایمیل به مشتری
        /// </summary>
        /// <param name="username_Email">ایمیل مشتری</param>
        /// <param name="subject">موضوع ایمیل</param>
        /// <param name="body">متن ایمیل</param>
        /// <param name="signiture">امضا</param>
        /// <returns></returns>
        bool SendEmailToCustomer(string username_Email,string subject,string body,string signiture);
    }
}
