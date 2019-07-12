using Store.Models.DataBase.Dto.Frount.Category;
using Store.Models.DataBase.Dto.Frount.Public;
using Store.Models.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Services
{
    public class SiteHeaderService : ISiteHeaderService
    {
        public Category GetCategory()
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                var categories = _Storedb.Categories.Where(x => x.IsDeleted == false & x.IsEnabled == true).OrderBy(x => x.OrderNumber).ToList();
                List<Category> categories_list = new List<Category>();
                foreach (var cat in categories)
                {
                    Category category = new Category()
                    {
                        CategoryId=cat.CategoryId,
                        Description=cat.Description,
                        EName=cat.EName,
                        Icon=cat.Icon,
                        MainCategoryId=cat.MainCategoryId,
                        Name=cat.Name
                    };
                }
                return null;
            }
        }

        public NavBarMenu GetFooterMenu()
        {
            throw new NotImplementedException();
        }

        public NavBarMenu GetNavBarMenu()
        {
            throw new NotImplementedException();
        }

        public Slider GetSlider()
        {
            throw new NotImplementedException();
        }
    }
}
