using Store.Models.DataBase.Dto;
using Store.Models.DataBase.Dto.Customer;
using Store.Models.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Services
{
    public class CustomerService : ICustomerService
    {
        /// <summary>
        /// اطلاعات داشبورد مشتری
        /// </summary>
        /// <param name="usernsme">نام کاربری</param>
        /// <returns></returns>
        public CustomerOrdersWithPagenation GetCustomerOrdersWithPagenation(string username, int page)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// اطلاعات پروفایل کاربر
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <returns></returns>
        public CustomerProfile GetCustomerProfile(string username)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// بروزرسانی اطلاعات پروفایل
        /// </summary>
        /// <param name="customerProfile">ازلاعات پروفایل</param>
        /// <returns></returns>
        public CustomerInfo GetDashboardInfo(string username)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// لیست سفارشات اخیر مشتری همراه با صفحه بندی
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="page">شماره صفحه</param>
        /// <returns></returns>
        public CustomerProfile UpdateCustomerProfile(CustomerProfile customerProfile)
        {
            throw new NotImplementedException();
        }
    }
}
