using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// فاکتور
    /// </summary>
    public class Factor
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// شماره سفارش
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// مبلغ فاکتور
        /// </summary>
        public decimal SumPrice { get; set; }
        /// <summary>
        /// تاریخ فاکتور
        /// </summary>
        public DateTime FactorDate { get; set; }
        /// <summary>
        /// وضعیت حذف
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
