using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Customer
{
    public class CustomerOrders
    {
    }

    public class CustomerOrdersWithPagenation
    {
        //صفحه درخواست شده
        public int Page { get; set; }
        //تعداد  کل صفحات
        public int PageCount { get; set; }
        //صفحه انتخاب شده
        public int SelectedPage { get; set; }
        //لیست سفارشات
        public List<CustomerOrders> CustomerOrders { get; set; }

    }
}
