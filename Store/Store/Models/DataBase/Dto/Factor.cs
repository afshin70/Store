using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto
{
    public class Factor
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int FactorId { get; set; }
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
        /// <summary>
        /// ﺷﻨﺎﺳﻪ ﻣﺮﺟﻊ
        /// </summary>
        public string Authority { get; set; }
        /// <summary>
        /// ﻭﺿﻌﻴﺖ 
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// ﺷﻤﺎﺭﻩ ﺗﺮﺍﻛﻨﺶ ﺧﺮﻳﺪ
        /// </summary>
        public string RefID { get; set; }
    }
}
