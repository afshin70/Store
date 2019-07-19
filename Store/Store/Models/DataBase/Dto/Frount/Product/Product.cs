using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Frount.Product
{
    
    public class Product
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
        /// نام تصویر شاخص محصول
        /// </summary>
        public string ImageName { get; set; }
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
        ///  واحد کالا
        /// </summary>
        public string UnitType { get; set; }
        /// <summary>
        /// محصول ویژه
        /// </summary>
        public bool IsSpecial { get; set; }
    }
}
