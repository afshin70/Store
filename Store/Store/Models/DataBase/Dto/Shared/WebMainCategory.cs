using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Shared
{
    public class WebMainCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EName { get; set; }
        public List<WebCategory> WebCategories { get; set; }
    }
}
