using Store.Models.DataBase.Dto.Admin;
using Store.Models.DataBase.Dto.Frount.Category;
using Store.Models.DataBase.Dto.Frount.Product;
using Store.Models.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Services
{
    public class ProductService : IProductService
    {
        public bool AddComment(Comment comment, int ProductId)
        {
            throw new NotImplementedException();
        }

        public bool AddMainCategory(Catrgory catrgory)
        {
            throw new NotImplementedException();
        }

        public bool AddMainCategory(MainCatrgory mainCatrgory)
        {
            throw new NotImplementedException();
        }

        public bool AddMainSubCategory(SubCatrgory subCatrgory)
        {
            throw new NotImplementedException();
        }

        public bool AddProduct(DataBase.Dto.Admin.Product product)
        {
            try
            {
                using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
                {
                    _Storedb.Products.Add(new DataBase.Entities.Product()
                    {
                        BrandId = product.BrandId,
                        EName = product.EName,
                        ExistCount = product.ExistCount,
                        Features = product.Features,
                        Images_Json = product.Images_Json,
                        InsertedDate = DateTime.Now,
                        IsActive = product.IsActive,
                        IsDeleted = false,
                        IsSpecial = product.IsSpecial,
                        MainDescription = product.MainDescription,
                        MaxDiscountPrice = product.MaxDiscountPrice,
                        MinCountNotify = product.MinCountNotify,
                        Name = product.Name,
                        Rating = product.Rating,
                        SalesPrice = product.SalesPrice,
                        ShortDescription = product.ShortDescription,
                        SoldCount = 0,
                        SubCategoryId = product.SubCategoryId,
                        Tags = product.Tags,
                        UnitType = product.UnitType,
                        VisitedCount = 0,
                        WrittenPrice = product.WrittenPrice
                    });
                    _Storedb.SaveChanges();
                    return true;
                }
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public bool CheckEnameOfProduct(string ename)
        {
            throw new NotImplementedException();
        }

        public bool CheckExistCategoryName(string CategoryName)
        {
            throw new NotImplementedException();
        }

        public bool CheckExistMainCategoryName(string CategoryName)
        {
            throw new NotImplementedException();
        }

        public bool CheckExistSubCategoryName(string SubCategoryName)
        {
            throw new NotImplementedException();
        }

        public bool CommentReaded(int commentId)
        {
            throw new NotImplementedException();
        }

        public bool CommentShow(int commentId)
        {
            throw new NotImplementedException();
        }

        public bool CommentVerification(int commentId)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Dto.Admin.Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Dto.Frount.Product.Product> GetbestSellersProducts(int count_Of = 7)
        {
            throw new NotImplementedException();
        }

        public List<Catrgory> GetCatrgories()
        {
            throw new NotImplementedException();
        }

        public List<Catrgory> GetCatrgories(int MainCategoryId)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Dto.Frount.Product.Product> GetHighScoreProducts(int count_Of = 3)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Dto.Admin.Product> GetListProductByParameters(string name, string ename, string description, string tags)
        {
            throw new NotImplementedException();
        }

        public List<MainCatrgory> GetMainCatrgories()
        {
            throw new NotImplementedException();
        }

        public Category GetPopularCategory()
        {
            throw new NotImplementedException();
        }

        public DataBase.Dto.Admin.Product GetProductById(int ProductId)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Dto.Frount.Product.Product> GetRandomProducts(int count_Of = 3)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Dto.Frount.Product.Product> GetSpecialOffersProducts(int count_Of = 3)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Dto.Frount.Product.Product> GetSpecialProducts(int count_Of = 8)
        {
            throw new NotImplementedException();
        }

        public List<SubCatrgory> GetSubCatrgories()
        {
            throw new NotImplementedException();
        }

        public List<SubCatrgory> GetSubCatrgories(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCategory(int CatrgoryId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveComment(int commentId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveMainCategory(int mainCatrgoryId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveProduct(int ProductId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveSubCategory(int CatrgoryId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCaregory(Catrgory catrgory, int CatrgoryId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMainCaregory(MainCatrgory mainCatrgory, int mainCatrgoryId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(DataBase.Dto.Admin.Product product, int Id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSubCaregory(SubCatrgory subCatrgory, int SubCatrgoryId)
        {
            throw new NotImplementedException();
        }
    }
}
