using Store.Models.DataBase.Dto;
using Store.Models.DataBase.Dto.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.IService
{
    interface ICustomerDashboardService
    {
        /// <summary>
        /// اطلاعات داشبورد مشتری
        /// </summary>
        /// <param name="usernsme">نام کاربری</param>
        /// <returns></returns>
        CustomerInfo GetDashboardInfo(string username);
        /// <summary>
        /// اطلاعات پروفایل کاربر
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <returns></returns>
        CustomerProfile GetCustomerProfile(string username);
        /// <summary>
        /// بروزرسانی اطلاعات پروفایل
        /// </summary>
        /// <param name="customerProfile">ازلاعات پروفایل</param>
        /// <returns></returns>
        CustomerProfile UpdateCustomerProfile(CustomerProfile customerProfile);
        /// <summary>
        /// لیست سفارشات اخیر مشتری همراه با صفحه بندی
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="page">شماره صفحه</param>
        /// <returns></returns>
        CustomerOrdersWithPagenation GetCustomerOrdersWithPagenation(string username,int page);
        /// <summary>
        /// تغییر رمز ورود پنل مشتری
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="currentPassword">رمز فعلی</param>
        /// <param name="newPassword">رمز جدید</param>
        /// <returns></returns>
        bool UpdatePassword(string username,string currentPassword,string newPassword);
    }
}
