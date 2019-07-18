using Store.Models.DataBase.Dto.Frount.Category;
using Store.Models.DataBase.Dto.Frount.Header;
using Store.Models.DataBase.Dto.Frount.Product;
using Store.Models.DataBase.Dto.Frount.Public;
using Store.Models.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Services.Frount
{
    public class SiteHeaderService : ISiteHeaderService
    {
        public Banner GetBanner()
        {
            throw new NotImplementedException();
        }

        public Category GetCategory()
        {
            throw new NotImplementedException();
        }

        public NavBarMenu GetNavBarMenu()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsBySearch(string search_text)
        {
            throw new NotImplementedException();
        }

        public Slider GetSlider()
        {
            throw new NotImplementedException();
        }
    }
}
