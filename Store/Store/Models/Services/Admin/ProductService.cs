using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Store.Models.DataBase.Context;
using Store.Models.DataBase.Entities;
using Store.Models.IService;
using Store.Models.IService.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Services.Admin
{
    public class ProductService : IProductService
    {
        public bool ActiveCategory(int ctegory_id, bool isActive)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Categories.Where(x => x.CategoryId == ctegory_id).First();
                    result.IsActive = isActive;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool ActiveMainCategory(int main_ctegory_id, bool isActive)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.MainCategories.Where(x => x.MainCategoryId == main_ctegory_id).First();
                    result.IsActive = isActive;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool ActiveSubCategory(int subctegory_id, bool isActive)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.SubCategories.Where(x => x.SubCategoryId == subctegory_id).First();
                    result.IsActive = isActive;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool AddCategory(Category catrgory)
        {
            using (var db = new StoreContext(null))
            {
                db.Categories.Add(catrgory);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool AddMainCategory(MainCategory mainCategory)
        {
            using (var db = new StoreContext(null))
            {
                db.MainCategories.Add(mainCategory);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool AddProduct(DataBase.Entities.Product product)
        {
            using (var db = new StoreContext(null))
            {
                db.Products.Add(product);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool AddProductBrand(DataBase.Entities.Brand brand)
        {
            using (var db = new StoreContext(null))
            {
                db.Brands.Add(brand);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool AddSubCategory(SubCategory subCategory)
        {
            using (var db = new StoreContext(null))
            {
                db.SubCategories.Add(subCategory);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool CheckEnameOfProduct(string ename)
        {
            using (var db = new StoreContext(null))
            {
                return db.Products.Any(x => x.EName == ename);
            }
        }

        public bool CheckExistBrandEName(string eName)
        {
            using (var db = new StoreContext(null))
            {
                return db.SubCategories.Any(x => x.EName == eName);
            }
        }

        public bool CheckExistBrandName(string name)
        {
            using (var db = new StoreContext(null))
            {
                return db.Brands.Any(x => x.Name == name);
            }
        }

        public bool CheckExistCategoryEName(string CategoryEName)
        {
            using (var db = new StoreContext(null))
            {
                return db.Categories.Any(x => x.EName == CategoryEName);
            }
        }

        public bool CheckExistCategoryName(string CategoryName)
        {
            using (var db = new StoreContext(null))
            {
                return db.Categories.Any(x => x.Name == CategoryName);
            }
        }

        public bool CheckExistMainCategoryEName(string CategoryEName)
        {
            using (var db = new StoreContext(null))
            {
                return db.MainCategories.Any(x => x.EName == CategoryEName);
            }
        }

        public bool CheckExistMainCategoryName(string CategoryName)
        {
            using (var db = new StoreContext(null))
            {
                return db.MainCategories.Any(x => x.Name == CategoryName);
            }
        }

        public bool CheckExistSubCategoryEName(string SubCategoryEName)
        {
            using (var db = new StoreContext(null))
            {
                return db.SubCategories.Any(x => x.EName == SubCategoryEName);
            }
        }

        public bool CheckExistSubCategoryName(string SubCategoryName)
        {
            using (var db = new StoreContext(null))
            {
                return db.SubCategories.Any(x => x.Name == SubCategoryName);
            }
        }

        public bool CommentReaded(int commentId)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Comments.Where(x => x.CommentId == commentId).First();
                    result.IsSeen = true;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool CommentShow(int commentId)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Comments.Where(x => x.CommentId == commentId).First();
                    result.IsShow = true;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool CommentVerification(int commentId)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Comments.Where(x => x.CommentId == commentId).First();
                    result.IsVerified = true;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public List<DataBase.Entities.Brand> GetAllBrands()
        {
            using (var db = new StoreContext(null))
            {
                return db.Brands.ToList();
            }
        }

        public List<DataBase.Entities.Product> GetAllProducts()
        {
            using (var db = new StoreContext(null))
            {
                return db.Products.ToList();
            }
        }

        public DataBase.Entities.Brand GetBrandByEname(string eName)
        {
            using (var db = new StoreContext(null))
            {
                return db.Brands.Where(x => x.EName == eName).First();
            }
        }

        public DataBase.Entities.Brand GetBrandById(int brandId)
        {
            using (var db = new StoreContext(null))
            {
                return db.Brands.Where(x => x.BrandId == brandId).First();
            }
        }

        public List<Category> GetCategories()
        {
            using (var db = new StoreContext(null))
            {
                return db.Categories.ToList();
            }
        }

        public List<Category> GetCatrgories(int MainCategoryId)
        {
            using (var db = new StoreContext(null))
            {
                return db.Categories.Where(x => x.MainCategoryId == MainCategoryId).ToList();
            }
        }

        public List<DataBase.Entities.Product> GetListProductByParameters(string name, string ename, string description, string tags)
        {
            using (var db = new StoreContext(null))
            {
                return db.Products.Where(x => x.Name.Contains(name) || x.EName.Contains(ename) || x.MainDescription.Contains(description) || x.Tags.Contains(tags)).ToList();
            }
        }

        public List<MainCategory> GetMainCategories()
        {
            using (var db = new StoreContext(null))
            {
                return db.MainCategories.ToList();
            }
        }

        public MainCategory GetMainCategory(int MainCategoryId)
        {
            using (var db = new StoreContext(null))
            {
                return db.MainCategories.Where(x => x.MainCategoryId == MainCategoryId).First();
            }
        }

        public DataBase.Entities.Product GetProductById(int ProductId)
        {
            using (var db = new StoreContext(null))
            {
                return db.Products.Where(x => x.ProductId == ProductId).First();
            }
        }

        public List<DataBase.Entities.Comment> GetProductComments(int productId)
        {
            using (var db = new StoreContext(null))
            {
                return db.Comments.Where(x => x.ProductId == productId).ToList();
            }
        }

        public List<SubCategory> GetSubCatrgories()
        {
            using (var db = new StoreContext(null))
            {
                return db.SubCategories.ToList();
            }
        }

        public List<SubCategory> GetSubCatrgories(int CategoryId)
        {
            using (var db = new StoreContext(null))
            {
                return db.SubCategories.Where(x => x.CategoryId == CategoryId).ToList();
            }
        }

        public bool LevelDownCategory(int CatrgoryId)
        {
            using (var db = new StoreContext(null))
            {
                var result = db.Categories.Where(x => x.CategoryId == CatrgoryId).First();
                result.OrderNumber -= 1;
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool LevelDownMainCategory(int mainCatrrgoryId)
        {
            using (var db = new StoreContext(null))
            {
                var result = db.MainCategories.Where(x => x.MainCategoryId == mainCatrrgoryId).First();
                result.OrderNumber -= 1;
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool LevelDownSubCategory(int subCatrgoryId)
        {
            using (var db = new StoreContext(null))
            {
                var result = db.SubCategories.Where(x => x.SubCategoryId == subCatrgoryId).First();
                result.OrderNumber -= 1;
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool LevelUpCategory(int CatrgoryId)
        {
            using (var db = new StoreContext(null))
            {
                var result = db.Categories.Where(x => x.CategoryId == CatrgoryId).First();
                result.OrderNumber += 1;
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool LevelUpMainCategory(int mainCatrrgoryId)
        {
            using (var db = new StoreContext(null))
            {
                var result = db.MainCategories.Where(x => x.MainCategoryId == mainCatrrgoryId).First();
                result.OrderNumber += 1;
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool LevelUpSubCategory(int subCatrgoryId)
        {
            using (var db = new StoreContext(null))
            {
                var result = db.SubCategories.Where(x => x.SubCategoryId == subCatrgoryId).First();
                result.OrderNumber += 1;
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool RemoveBrand(int brandId)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Brands.Where(x => x.BrandId == brandId).First();
                    db.Brands.Remove(result);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool RemoveCategory(int CatrgoryId)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Categories.Where(x => x.CategoryId == CatrgoryId).First();
                    db.Categories.Remove(result);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool RemoveComment(int commentId)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Comments.Where(x => x.CommentId == commentId).First();
                    db.Comments.Remove(result);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool RemoveMainCategory(int mainCatrrgoryId)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.MainCategories.Where(x => x.MainCategoryId == mainCatrrgoryId).First();
                    db.MainCategories.Remove(result);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool RemoveProduct(int ProductId)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Products.Where(x => x.ProductId == ProductId).First();
                    db.Products.Remove(result);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool RemoveSubCategory(int subCatrgoryId)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.SubCategories.Where(x => x.SubCategoryId == subCatrgoryId).First();
                    db.SubCategories.Remove(result);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool UpdateBrand(DataBase.Entities.Brand brand, int brandId)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Brands.Where(x => x.BrandId == brand.BrandId).First();

                    result.Description = brand.Description;
                    result.EName = brand.EName;
                    result.Name = brand.Name;

                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool UpdateCaregory(Category category, int CatrgoryId)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Categories.Where(x => x.CategoryId == category.CategoryId).First();
                    result.Description = category.Description;
                    result.EName = category.EName;
                    result.IsActive = category.IsActive;
                    result.IsFavorate = category.IsFavorate;
                    result.MainCategoryId = category.MainCategoryId;
                    result.Name = category.Name;

                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool UpdateMainCaregory(MainCategory mainCatrgory, int mainCatrgoryId)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.MainCategories.Where(x => x.MainCategoryId == mainCatrgory.MainCategoryId).First();
                    result.EName = mainCatrgory.EName;
                    result.IsActive = mainCatrgory.IsActive;
                    result.Name = mainCatrgory.Name;

                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool UpdateProduct(DataBase.Entities.Product product, int Id)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Products.Where(x => x.ProductId == product.ProductId).First();

                    result.BrandId = product.BrandId;
                    result.EName = product.EName;
                    result.ExistCount = product.ExistCount;
                    result.Features = product.Features;
                    result.Images_Json = product.Images_Json;
                    result.IsActive = product.IsActive;
                    result.IsSpecial = product.IsSpecial;
                    result.MainDescription = product.MainDescription;
                    result.MaxDiscountPrice = product.MaxDiscountPrice;
                    result.MinCountNotify = product.MinCountNotify;
                    result.Name = product.Name;
                    result.Rating = product.Rating;
                    result.SalesPrice = product.SalesPrice;
                    result.ShortDescription = product.ShortDescription;
                    result.SubCategoryId = product.SubCategoryId;
                    result.Tags = product.Tags;
                    result.UnitType = product.UnitType;
                    result.VisitedCount = product.VisitedCount;
                    result.WrittenPrice = product.WrittenPrice;

                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool UpdateSubCaregory(SubCategory subCategory, int SubCatrgoryId)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.SubCategories.Where(x => x.SubCategoryId == subCategory.SubCategoryId).First();

                    result.Description = subCategory.Description;
                    result.EName = subCategory.EName;
                    result.IsActive = subCategory.IsActive;
                    result.Name = subCategory.Name;
                    result.OrderNumber = subCategory.OrderNumber;

                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
