using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Admin.NavBar
{
    public class NavSubMenu
    {
        /// <summary>
        /// آی دی زیر منو
        /// </summary>
        public int SubMenuId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// لینک
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// آیا فعال است
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// آی دی منو
        /// </summary>
        public int MenuId { get; set; }
    }
}
