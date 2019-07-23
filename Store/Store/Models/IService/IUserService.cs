using Store.Models.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.IService
{
    interface IUserService
    {
        #region سفارش
        bool AddOrder(Order order);
        #endregion

        #region عملیات مربوط به یوزر
        /// <summary>
        /// چک کردن رول کاربر
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="role">رول</param>
        /// <returns></returns>
        bool CheckUserRole(string username,string role);
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
        bool CheckUserPasswordChange(string username, string Token);
        /// <summary>
        /// دریافت اطلاعات یوزر با آی دی
        /// </summary>
        /// <param name="UserId">آی دی کاربر</param>
        /// <returns></returns>
        User GetUserById(int username);
        /// <summary>
        /// تغیر رمز کاربری
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="old_passwor">رمز ورود قبلی</param>
        /// <param name="new_password">رمز ورود جدید</param>
        /// <returns></returns>
        bool ChangePassword(string username, string old_passwor, string new_password);
        /// <summary>
        /// ارسال ایمیل فعال سازی برای مشتری
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="ActivationLink">لینک فعال سازی</param>
        /// <returns></returns>
        bool SendActivationLinkByEmail(string username,string ActivationLink);
        /// <summary>
        ///وضعیت اکانت مشتری
        ///فعال است یا خیر
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <returns></returns>
        bool UserAccountState(string username);
        /// <summary>
        /// دریافت نقش کاربر
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <returns></returns>
        string GetUserRole(string username);
        /// <summary>
        /// ریست پسورد
        /// </summary>
        /// <param name="newPassword">پسورد جدید</param>
        /// <param name="username">نام کاربری</param>
        /// <returns></returns>
        bool ResetPassword(string username,string newPassword);
        #endregion

        #region تیکت
        bool SendTiket(Ticket ticket,string username);
        bool IsSeen(int ticketId);

        #endregion

        #region داشبورد یا پروفایل مشتری
        /// <summary>
        /// اطلاعات داخل داشبورد مشتری شامل لیست سفارشات اخیر و نام و ایمیل و آدرس و ...
        /// دریافت اطلاعات کاربر یا مشتری
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <returns></returns>
        User GetUserInfo(string username);
        /// <summary>
        /// بروزرسانی اطلاعات
        /// اطلاعات داخل داشبورد مشتری شامل لیست سفارشات اخیر و نام و ایمیل و آدرس و ...
        /// دریافت اطلاعات کاربر یا مشتری
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="user">یوزر</param>
        /// <returns></returns>
        bool UpdateUserInfo(User user,string username);
        /// <summary>
       /// به روز رسانی آدرس کاربر
       /// </summary>
       /// <param name="adress"></param>
       /// <param name="username"></param>
       /// <returns></returns>
        bool UpdateUserAdress(string adress,string username);
        /// <summary>
        /// افزودن آدرس کاربر
        /// </summary>
        /// <param name="adress"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        bool AddUserAdress(string adress,string username);
        /// <summary>
        /// دریافت آدرس مشتری
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <returns></returns>
        string GetUserAdress(string username);
        /// <summary>
        /// سفارشات اخیر مشتری
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <returns></returns>
       // Order GetUserRecentOrders(string username);
        #endregion

        #region علاقه مندیها
        /// <summary>
        /// افزودن به علاقه مندی ها
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="productId">آی دی محصول</param>
        /// <returns></returns>
        bool AddItemInWishlist(int username,int productId);
        /// <summary>
        /// حذف از علاقه مندی ها
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="productId">آی دی محصول</param>
        /// <returns></returns>
        bool RemoveItemAsWishlist(int username,int productId);
        /// <summary>
        /// وجود محصول تکراری در سبد علاقه مندیها
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="productId">آی دی محصول</param>
        /// <returns></returns>
        bool ExistItemInWishlist(int username, int productId);
        /// <summary>
        /// لیست علاقه مندی ها
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
       string GetWishlist(int username);
        #endregion

        #region سبد خرید
        /// <summary>
        /// افزودن به سبد خرید
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="productId">آی دی محصول</param>
        /// <param name="qty">تعداد پیش فرض 1</param>
        /// <returns></returns>
        bool AddItemInCart(int username, int productId, int qty=1);
        /// <summary>
        /// وجود محصول تکراری در سبد خرید
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="productId">آی دی محصول</param>
        /// <returns></returns>
        bool ExistItemInCart(int username, int productId);
        /// <summary>
        /// حذف از سبد خرید
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="productId">آی دی محصول</param>
        /// <returns></returns>
        bool RemoveItemAsCart(int username, int productId);
        /// <summary>
        /// بروزرسانی تعداد محصول در سبد خرید
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="productId">آی دی محصول</param>
        /// <param name="qty">تعداد</param>
        /// <returns></returns>
        bool UpdateQty(int username, int productId, int qty);
        /// <summary>
        /// سبد خرید مشتری
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <returns></returns>
        string GetUserCart(int username);
        /// <summary>
        /// تعداد آیتم های سبد خرید
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <returns></returns>
        int GetQtyOfUserCaretItem(string username);
        #endregion
        
    }
}
