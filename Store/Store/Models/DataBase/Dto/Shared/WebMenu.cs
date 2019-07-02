using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Shared
{
    public class WebMenu
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// آدرس لینک
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// زیر منو ها
        /// </summary>
        public List<WebSubMenu> SubMenus { get; set; }
    }
}
