using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Index
{
    /// <summary>
    /// اسلایدر
    /// </summary>
    public class IndexSlider
    {
        /// <summary>
        /// آی دی 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// آدرس تصویر اسلایدر
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// لینک ارسال به آدرس
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// متن دکمه
        /// </summary>
        public string ButtonText { get; set; }
        /// <summary>
        /// لینک آدرس دکمه
        /// </summary>
        public string ButtonUrl { get; set; }
    }
}
