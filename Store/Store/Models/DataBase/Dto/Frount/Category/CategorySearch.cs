//using Store.Models.DataBase.Dto.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Category
{
    public class CategorySearch
    {
        /// <summary>
        /// لیست زیر دسته بندی
        /// </summary>
        public List<SubCategoriesFinded> SubCategoriesFindeds { get; set; }
        /// <summary>
        /// بیشترین 
        /// </summary>
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }
        public string SearchedText { get; set; }
        public int Pages { get; set; }
        public int CurrnetPage { get; set; }
        public int ProductFoundedCount { get; set; }
    }
    public class SubCategoriesFinded
    {
        public int SubcategoryId { get; set; }
        public string Name { get; set; }
        public string EName { get; set; }
        public int ProductCount { get; set; }
    }
}
