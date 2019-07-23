using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Admin.NavBar
{
    public class NavMenu
    {
        /// <summary>
        /// منو آی دی
        /// </summary>
        public int MenuId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// لینک
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// وضعیت فعال
        /// </summary>
        public bool IsActive { get; set; }
    }
    
}
