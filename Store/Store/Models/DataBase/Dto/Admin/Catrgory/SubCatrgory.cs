﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Admin
{
    public class SubCatrgory
    {
        /// <summary>
        /// آی دی 
        /// </summary>
        public int SubCategoryId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        /// <summary>
        /// شماره اولویت
        /// </summary>
        public int OrderNumber { get; set; }
        /// <summary>
        /// وضعیت فال بودن
        /// </summary>
        public bool IsActive { get; set; }
    }
}
