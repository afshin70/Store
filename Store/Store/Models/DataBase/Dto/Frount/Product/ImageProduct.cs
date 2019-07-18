using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Frount.Product
{
    public class ImageProduct
    {
        /// <summary>
        /// نام تصویر
        /// </summary>
        public string EName { get; set; }
        /// <summary>
        /// آیا تصویر شاخص است؟
        /// </summary>
        public bool IsDefaultImage { get; set; }

    }
}
