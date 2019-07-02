using Store.Models.DataBase.Dto.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto
{
    public class SubCategory
    {
        public List<ProductBlock> Products { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }
        public string SearchedText { get; set; }
        public int Pages { get; set; }
        public int CurrnetPage { get; set; }
        public int ProductFoundedCount { get; set; }
    }
}
