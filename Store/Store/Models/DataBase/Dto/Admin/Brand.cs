using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Admin
{
    public class Brand
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int BrandId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
    }
}
