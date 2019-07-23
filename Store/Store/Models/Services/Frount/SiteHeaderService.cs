using Newtonsoft.Json;
using Store.Models.DataBase.Dto.Frount.Category;
using Store.Models.DataBase.Dto.Frount.Header;
using Store.Models.DataBase.Dto.Frount.Product;
using Store.Models.DataBase.Dto.Frount.Public;
using Store.Models.IService;
using Store.Models.IService.Frount;
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
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.Settings.Select(x => new Banner
                {
                    ImageName = x.BanerImageName,
                    ImageNameMob = x.BanerImageNameMob
                }).First();
            }
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
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.Products.Where(x => x.Name.Contains(search_text)||x.EName.Contains(search_text)).Select(x => new Product
                {
                    ProductId=x.ProductId,
                    Ename = x.EName,
                    ImageName = JsonConvert.DeserializeObject<List<ImageProduct>>(x.Images_Json).Where(p => p.IsDefaultImage == true).First().EName,
                    IsExist = x.ExistCount > 0 ? true : false,
                    IsSpecial=x.IsSpecial,
                    Name=x.Name,
                    Price_New=x.SalesPrice.ToPriceStringFormat(),
                    Price_Old=x.WrittenPrice.ToPriceStringFormat(),
                    UnitType=x.UnitType
                }).ToList();
            }
        }

        public List<Slider> GetSlider()
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.Sliders.Where(x=>x.IsActive).Select(x => new Slider {
                    Description=x.Description,
                    ImageName=x.ImageName,
                    ImageNameMob=x.ImageNameMob,
                    IsShowInMainPage=x.IsShowInMainPage,
                    SliderId=x.SliderId,
                    Title=x.Title,
                    UrlLink=x.UrlLink,
                    UrlText=x.UrlText
                }).ToList();
            }
        }
    }
}
