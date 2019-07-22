using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Frount.Footer
{
    /// <summary>
    /// تماس با ما در فوتر سایت
    /// </summary>
    public class FoterBarMenu
    {
        /// <summary>
        /// توضیحات تماس با ما
        /// </summary>
        public string ContactUsDescription { get; set; }
        /// <summary>
        /// آدرس 
        /// </summary>
        public string ContactUsAddress { get; set; }
        /// <summary>
        /// ایمیل
        /// </summary>
        public string ContactUsEmail { get; set; }
        /// <summary>
        /// شماره تماس
        /// </summary>
        public string ContactUsTel { get; set; }
        /// <summary>
        /// ساعت و شیفت کاری
        /// </summary>
        public string ContactusWorkTime { get; set; }
    }
}
