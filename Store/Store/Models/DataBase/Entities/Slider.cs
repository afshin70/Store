﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// اسلایدر
    /// </summary>
    public class Slider
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// تصویر
        /// </summary>
        public string Image { get; set; }
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
    }
}
