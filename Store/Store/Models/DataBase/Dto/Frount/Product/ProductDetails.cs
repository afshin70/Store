using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Frount.Product
{
    public class ProductDetails
    {
        /// <summary>
        /// آی دی محصول
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// نام انگلیسی و منحصر بفرد محصول
        /// </summary>
        public string Ename { get; set; }
        /// <summary>
        /// نام محصول
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// قیمت جدید محصول
        /// </summary>
        public string Price_New { get; set; }
        /// <summary>
        /// قیمت قبلی محصول
        /// </summary>
        public string Price_Old { get; set; }
        /// <summary>
        /// وضعیت موجود بودن محصول
        /// </summary>
        public bool IsExist { get; set; }
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        /// <summary>
        /// توضیحات کوتاه
        /// </summary>
        public string ShortDescription { get; set; }
        /// <summary>
        /// توضیحات اصلی
        /// </summary>
        public string MainDescription { get; set; }
        /// <summary>
        /// تصاویر
        /// </summary>
        public string Images_Json { get; set; }
        /// <summary>
        /// تگ محصول
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// برند کالا
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// ویژگی ها بصورت جیسون
        /// </summary>
        public string Features_Json { get; set; }
        /// <summary>
        /// امتیاز کالا
        /// </summary>
        public int Rating { get; set; }
    }
   
}
