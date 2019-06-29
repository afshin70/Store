using Store.Models.DataBase.Dto;
using Store.Models.DataBase.Dto.Customer;
using Store.Models.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Services
{
    public class CustomerDashboardService : ICustomerDashboardService
    {
        
        public bool UpdatePassword(string username, string currentPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public CustomerOrdersWithPagenation GetCustomerOrdersWithPagenation(string username, int page)
        {
            throw new NotImplementedException();
        }

        public CustomerProfile GetCustomerProfile(string username)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// اطلاعات داشبورد مشتری
        /// </summary>
        /// <param name="usernsme">نام کاربری</param>
        /// <returns></returns>
        public CustomerInfo GetDashboardInfo(string username)
        {
            throw new NotImplementedException();
        }

        public CustomerProfile UpdateCustomerProfile(CustomerProfile customerProfile)
        {
            throw new NotImplementedException();
        }
    }
}
