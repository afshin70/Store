using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Admin
{
    public class FAQMsg
    {
        /// <summary>
        /// آی دی 
        /// </summary>
        public int FAQId { get; set; }
        /// <summary>
        /// سوال
        /// </summary>
        public string Question { get; set; }
        /// <summary>
        /// پاسخ
        /// </summary>
        public string Answer { get; set; }
        /// <summary>
        /// اولویت
        /// </summary>
        public int OrderNumber { get; set; }
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
    }
}
