using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Shared
{
    public class WebCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EName { get; set; }
        public string ImageUrl { get; set; }
        public List<WebSubCategory> WebSubCategories { get; set; }
    }
}
