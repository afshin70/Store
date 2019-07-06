using Store.Models.DataBase.Dto;
using Store.Models.DataBase.Dto.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.IService
{
    interface ICustomerService
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
        
    }
}
