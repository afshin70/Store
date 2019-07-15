using Store.Models.DataBase.Dto.Frount.Category;
using Store.Models.DataBase.Dto.Frount.Header;
using Store.Models.DataBase.Dto.Frount.Product;
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
        public Banner GetBanner()
        {
            throw new NotImplementedException();
        }

        public Category GetCategory()
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;

                var categories = _Storedb.Categories.Where(x => x.IsEnabled == true & x.IsEnabled == true).OrderBy(x => x.OrderNumber).ToList();
                List<Category> categories_list = new List<Category>();
                foreach (var cat in categories)
                {
                    Category category = new Category()
                    {
                        CategoryId=cat.CategoryId,
                        Description=cat.Description,
                        EName=cat.EName,
                        //Icon=cat.Icon,
                        MainCategoryId=cat.MainCategoryId,
                        Name=cat.Name
                    };
                }
                return null;
            }
        }

        public NavBarMenu GetNavBarMenu()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsBySearch(string search_text)
<<<<<<< HEAD
=======
        {
            throw new NotImplementedException();
        }

        public Slider GetSlider()
>>>>>>> 4a5cad46415c0d3f254b7ec0f6eed15972753a65
        {
            throw new NotImplementedException();
        }

        public Slider GetSlider()
        {
            throw new NotImplementedException();
        }
    }
}
