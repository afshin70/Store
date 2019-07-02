using Store.Models.DataBase.Dto.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Index
{
    public class IndexProducts
    {
        public List<ProductBlock> SpecialProducts { get; set; }
        public List<ProductBlock> BestsellingProduct { get; set; }
        public List<ProductBlock> MostVisitedProduct { get; set; }
        public List<ProductBlock> SpecialOfferProduct { get; set; }
        public List<ProductBlock> NewestProduct { get; set; }
    }
}
