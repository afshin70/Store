using Newtonsoft.Json;
using Store.Models.DataBase.Dto.Admin;
using Store.Models.DataBase.Dto.Frount.Category;
using Store.Models.DataBase.Dto.Frount.Product;
using Store.Models.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Services.Admin
{
    public class ProductService : IProductService
    {
        #region region
        /// <summary>
        /// کامنت جدید
        /// </summary>
        /// <param name="comment">کامنت</param>
        /// <param name="ProductId">
        public bool AddComment(Comment comment, int ProductId)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                _Storedb.Comments.Add(new DataBase.Entities.Comment()
                {
                    CommentedDate = DateTime.Now,
                    CommentText = comment.CommentText,
                    Email = comment.Email,
                    FullName = comment.FullName,
                    IsSeen = false,
                    IsShow = true,
                    IsVerified = false,
                    ProductId = comment.ProductId
                });
                try
                {
                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion
        #region  متدهای صفحه اصلی
        /// <summary>
        /// دریافت لیست محصولات ویژه
        /// </summary>
        /// <param name="count_Of">تعداد - پیشفرض 6 تا محصول</param>
        /// <returns></returns>
        public List<DataBase.Dto.Frount.Product.Product> GetSpecialProducts(int count_Of = 8)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.Products.Where(x => x.IsSpecial).Take(count_Of).Select(x => new DataBase.Dto.Frount.Product.Product
                {
                    ProductId = x.ProductId,
                    Ename = x.EName,
                    Name = x.Name,
                    ImageName = JsonConvert.DeserializeObject<List<ImageProduct>>(x.Images_Json).Where(p => p.IsDefaultImage == true).First().EName,
                    IsExist = x.ExistCount > 0 ? true : false,
                    IsSpecial = x.IsSpecial,
                    Price_New = x.SalesPrice.ToPriceStringFormat(),
                    Price_Old = x.WrittenPrice.ToPriceStringFormat(),
                    UnitType = x.UnitType,
                }).ToList();
            }
        }
        /// <summary>
        /// دریافت محصولات پرفروش
        /// </summary>
        /// <param name="count_Of">تعداد که مقدار پیشفرض 7 است</param>
        /// <returns></returns>
        public List<DataBase.Dto.Frount.Product.Product> GetbestSellersProducts(int count_Of = 7)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.Products.OrderByDescending(o => o.SoldCount).Take(count_Of).Select(x => new DataBase.Dto.Frount.Product.Product
                {
                    ProductId = x.ProductId,
                    Ename = x.EName,
                    Name = x.Name,
                    ImageName = JsonConvert.DeserializeObject<List<ImageProduct>>(x.Images_Json).Where(p => p.IsDefaultImage == true).First().EName,
                    IsExist = x.ExistCount > 0 ? true : false,
                    IsSpecial = x.IsSpecial,
                    Price_New = x.SalesPrice.ToPriceStringFormat(),
                    Price_Old = x.WrittenPrice.ToPriceStringFormat(),
                    UnitType = x.UnitType,
                }).ToList();
            }
        }
        /// <summary>
        /// دریافت محصولات امتیاز بالا
        /// </summary>
        /// <param name="count_Of">تعد محصولات که پیشفرض برابر 3 است</param>
        /// <returns></returns>
        public List<DataBase.Dto.Frount.Product.Product> GetHighScoreProducts(int count_Of = 3)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.Products.OrderByDescending(o => o.Rating).Take(count_Of).Select(x => new DataBase.Dto.Frount.Product.Product
                {
                    ProductId = x.ProductId,
                    Ename = x.EName,
                    Name = x.Name,
                    ImageName = JsonConvert.DeserializeObject<List<ImageProduct>>(x.Images_Json).Where(p => p.IsDefaultImage == true).First().EName,
                    IsExist = x.ExistCount > 0 ? true : false,
                    IsSpecial = x.IsSpecial,
                    Price_New = x.SalesPrice.ToPriceStringFormat(),
                    Price_Old = x.WrittenPrice.ToPriceStringFormat(),
                    UnitType = x.UnitType,
                }).ToList();
            }
        }
        /// <summary>
        /// دریافت محصولات فروش ویژه
        /// </summary>
        /// <param name="count_Of">تعداد که پیشفرض برابر 3 است</param>
        /// <returns></returns>
        public List<DataBase.Dto.Frount.Product.Product> GetSpecialOffersProducts(int count_Of = 3)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.Products.Where(o => o.IsSpecial).OrderBy(x => Guid.NewGuid()).Take(count_Of).Select(x => new DataBase.Dto.Frount.Product.Product
                {
                    ProductId = x.ProductId,
                    Ename = x.EName,
                    Name = x.Name,
                    ImageName = JsonConvert.DeserializeObject<List<ImageProduct>>(x.Images_Json).Where(p => p.IsDefaultImage == true).First().EName,
                    IsExist = x.ExistCount > 0 ? true : false,
                    IsSpecial = x.IsSpecial,
                    Price_New = x.SalesPrice.ToPriceStringFormat(),
                    Price_Old = x.WrittenPrice.ToPriceStringFormat(),
                    UnitType = x.UnitType,
                }).ToList();
            }
        }
        /// <summary>
        /// دریافت محصولات تصادفی
        /// </summary>
        /// <param name="count_Of">تعداد که پیشفرض 3 هست</param>
        /// <returns></returns>
        public List<DataBase.Dto.Frount.Product.Product> GetRandomProducts(int count_Of = 3)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.Products.OrderBy(x => Guid.NewGuid()).Take(count_Of).Select(x => new DataBase.Dto.Frount.Product.Product
                {
                    ProductId = x.ProductId,
                    Ename = x.EName,
                    Name = x.Name,
                    ImageName = JsonConvert.DeserializeObject<List<ImageProduct>>(x.Images_Json).Where(p => p.IsDefaultImage == true).First().EName,
                    IsExist = x.ExistCount > 0 ? true : false,
                    IsSpecial = x.IsSpecial,
                    Price_New = x.SalesPrice.ToPriceStringFormat(),
                    Price_Old = x.WrittenPrice.ToPriceStringFormat(),
                    UnitType = x.UnitType,
                }).ToList();
            }
        }
        /// <summary>
        /// -  دریافت دسته بندی های محبوب
        /// دسته ها و زیر دسته ها
        /// </summary>
        /// <returns></returns>
        public Category GetPopularCategory()
        {
            //using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            //{
            //    //_Storedb.
            //    List<MainCategory> mainCategories = _Storedb.MainCategories.OrderBy(x => x.OrderNumber).Select(x => new MainCategory
            //    {
            //        MainCategoryId = x.MainCategoryId,
            //        EName = x.EName,
            //        Name = x.Name
            //    }).ToList();
            //    foreach (var maincat in mainCategories)
            //    {
            //        List<Category> Cat = _Storedb.Categories.OrderBy(x => x.OrderNumber).Select(x => new Category
            //        {
            //            CategoryId = x.CategoryId,
            //            MainCategoryId = maincat.MainCategoryId,
            //            Description = x.Description,
            //            EName = x.EName,
            //            Name = x.Name
            //        }).ToList();
            //        List<SubCategory> subCat = new List<SubCategory>();
            //        foreach (var cat in Cat)
            //        {
            //            subCat = _Storedb.SubCategories.OrderBy(x => x.OrderNumber).Select(x => new SubCategory
            //            {
            //                SubCategoryId = x.SubCategoryId,
            //                CategoryId = cat.CategoryId,
            //                Description = x.Description,
            //                EName = x.EName,
            //                Name = x.Name
            //            }).ToList();
            //            maincat.Categories.Where(x => x.CategoryId == cat.CategoryId).First().SubCategoriess.AddRange(subCat);
            //        }
            //        mainCategories.Where(x => x.MainCategoryId == maincat.MainCategoryId).First().Categories = new List<Category>(Cat);
            //    }
            //    return mainCategories;
            //}
            return null;
        }
        #endregion






    }
}
