using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.BaseSearch
{
    public class Search
    {
        //public List<ProductBlock> Products { get; set; }
        public List<SearchFoundedCategory> SubCategories { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }
        public string SearchedText { get; set; }
        public int Pages { get; set; }
        public int CurrnetPage { get; set; }
        public int ProductFoundedCount { get; set; }
    }
    public class SearchFoundedCategory
    {
        public int SubcategoryId { get; set; }
        public string Name { get; set; }
        public string EName { get; set; }
        public int ProductCount { get; set; }
    }
}
