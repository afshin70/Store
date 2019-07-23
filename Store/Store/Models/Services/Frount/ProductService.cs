using Newtonsoft.Json;
using Store.Models.DataBase.Dto.Admin;
using Store.Models.DataBase.Dto.Frount.Category;
using Store.Models.DataBase.Dto.Frount.Product;
using Store.Models.IService;
using Store.Models.IService.Frount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Services.Frount
{
    public class ProductService : IProductService
    {
        /// <summary>
        /// کامنت جدید
        /// </summary>
        /// <param name="comment">کامنت</param>
        /// <param name="ProductId">آی دی محصول</param>
        /// <returns></returns>
        public bool AddComment(Comment comment, int ProductId)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.Comments.Add(new DataBase.Entities.Comment()
                {
                    CommentedDate = DateTime.Now,
                    CommentText = comment.CommentText,
                    Email = comment.Email,
                    FullName = comment.FullName,
                    IsSeen = false,
                    IsShow = false,
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
        /// <summary>
        /// دریافت محصولات پرفروش
        /// </summary>
        /// <param name="count_Of">تعداد که مقدار پیشفرض 7 است</param>
        /// <returns></returns>
        public List<DataBase.Dto.Frount.Product.Product> GetbestSellersProducts(int count_Of = 7)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.Products.OrderByDescending(x => x.SoldCount).Take(count_Of).Select(s => new DataBase.Dto.Frount.Product.Product {
                    Ename=s.EName,
                    ImageName= JsonConvert.DeserializeObject<List<ImageProduct>>(s.Images_Json).Where(p => p.IsDefaultImage == true).First().EName,
                    IsExist= s.ExistCount > 0 ? true : false,
                    IsSpecial=s.IsSpecial,
                    Name=s.Name,
                    Price_New=s.SalesPrice.ToPriceStringFormat(),
                    Price_Old=s.WrittenPrice.ToPriceStringFormat(),
                    ProductId=s.ProductId,
                    UnitType=s.UnitType
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
                return _Storedb.Products.OrderByDescending(x => x.Rating).Take(count_Of).Select(s => new DataBase.Dto.Frount.Product.Product
                {
                    Ename = s.EName,
                    ImageName = JsonConvert.DeserializeObject<List<ImageProduct>>(s.Images_Json).Where(p => p.IsDefaultImage == true).First().EName,
                    IsExist = s.ExistCount > 0 ? true : false,
                    IsSpecial = s.IsSpecial,
                    Name = s.Name,
                    Price_New = s.SalesPrice.ToPriceStringFormat(),
                    Price_Old = s.WrittenPrice.ToPriceStringFormat(),
                    ProductId = s.ProductId,
                    UnitType = s.UnitType
                }).ToList();
            }
        }
        /// <summary>
        /// -  دریافت دسته بندی های محبوب
        /// دسته ها و زیر دسته ها
        /// </summary>
        /// <returns></returns>
        public List<Category> GetPopularCategory()
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.Categories.Where(x => x.IsFavorate).Select(x => new DataBase.Dto.Frount.Category.Category
                {
                    CategoryId = x.CategoryId,
                    Description = x.Description,
                    EName = x.EName,
                    Name = x.Name,
                    SubCategoriess = _Storedb.SubCategories.Where(p => p.CategoryId == x.CategoryId)
                    .Select(y => new SubCategory
                    {
                        SubCategoryId = y.SubCategoryId,
                        CategoryId = x.CategoryId,
                        EName = y.EName,
                        Name = y.Name,
                        Description = y.Description
                    }).ToList()
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
        /// دریافت محصولات فروش ویژه
        /// </summary>
        /// <param name="count_Of">تعداد که پیشفرض برابر 3 است</param>
        /// <returns></returns>
        public List<DataBase.Dto.Frount.Product.Product> GetSpecialOffersProducts(int count_Of = 3)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.Products.Where(x => x.IsSpecial).OrderBy(x=>Guid.NewGuid()).Take(count_Of).Select(s => new DataBase.Dto.Frount.Product.Product
                {
                    Ename = s.EName,
                    ImageName = JsonConvert.DeserializeObject<List<ImageProduct>>(s.Images_Json).Where(p => p.IsDefaultImage == true).First().EName,
                    IsExist = s.ExistCount > 0 ? true : false,
                    IsSpecial = s.IsSpecial,
                    Name = s.Name,
                    Price_New = s.SalesPrice.ToPriceStringFormat(),
                    Price_Old = s.WrittenPrice.ToPriceStringFormat(),
                    ProductId = s.ProductId,
                    UnitType = s.UnitType
                }).ToList();
            }
        }
        /// <summary>
        /// دریافت لیست محصولات ویژه
        /// </summary>
        /// <param name="count_Of">تعداد - پیشفرض 6 تا محصول</param>
        /// <returns></returns>
        public List<DataBase.Dto.Frount.Product.Product> GetSpecialProducts(int count_Of = 8)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.Products.Where(x => x.IsSpecial).Take(count_Of).Select(s => new DataBase.Dto.Frount.Product.Product
                {
                    Ename = s.EName,
                    ImageName = JsonConvert.DeserializeObject<List<ImageProduct>>(s.Images_Json).Where(p => p.IsDefaultImage == true).First().EName,
                    IsExist = s.ExistCount > 0 ? true : false,
                    IsSpecial = s.IsSpecial,
                    Name = s.Name,
                    Price_New = s.SalesPrice.ToPriceStringFormat(),
                    Price_Old = s.WrittenPrice.ToPriceStringFormat(),
                    ProductId = s.ProductId,
                    UnitType = s.UnitType
                }).ToList();
            }
        }
    }
}
