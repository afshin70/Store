using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto
{
    public class Slider
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int SliderId { get; set; }
        /// <summary>
        /// تصویر
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// نسخه موبایل
        /// </summary>
        public string ImageNameMob { get; set; }
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// متن لینک
        /// </summary>
        public string UrlText { get; set; }
        /// <summary>
        /// آدرس لینک
        /// </summary>
        public string UrlLink { get; set; }
        /// <summary>
        /// وضعیت نمایش در صفحه اصلی
        /// </summary>
        public bool IsShowInMainPage { get; set; }
    }
}
