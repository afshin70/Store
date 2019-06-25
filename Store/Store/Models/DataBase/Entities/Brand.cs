using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EName { get; set; }
        public string Description { get; set; }
        public string TumbImageUrl { get; set; }
    }
}
