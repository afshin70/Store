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
            throw new NotImplementedException();
        }

        public bool ActiveMainCategory(int main_ctegory_id, bool isActive)
        {
            throw new NotImplementedException();
        }

        public bool ActiveSubCategory(int subctegory_id, bool isActive)
        {
            throw new NotImplementedException();
        }

        public bool AddCategory(Category catrgory)
        {
            throw new NotImplementedException();
        }

        public bool AddMainCategory(MainCategory mainCategory)
        {
            throw new NotImplementedException();
        }

        public bool AddProduct(DataBase.Entities.Product product)
        {
            throw new NotImplementedException();
        }

        public bool AddProductBrand(DataBase.Entities.Brand brand)
        {
            throw new NotImplementedException();
        }

        public bool AddSubCategory(SubCategory subCategory)
        {
            throw new NotImplementedException();
        }

        public bool CheckEnameOfProduct(string ename)
        {
            throw new NotImplementedException();
        }

        public bool CheckExistBrandEName(string eName)
        {
            throw new NotImplementedException();
        }

        public bool CheckExistBrandName(string name)
        {
            throw new NotImplementedException();
        }

        public bool CheckExistCategoryEName(string CategoryEName)
        {
            throw new NotImplementedException();
        }

        public bool CheckExistCategoryName(string CategoryName)
        {
            throw new NotImplementedException();
        }

        public bool CheckExistMainCategoryEName(string CategoryEName)
        {
            throw new NotImplementedException();
        }

        public bool CheckExistMainCategoryName(string CategoryName)
        {
            throw new NotImplementedException();
        }

        public bool CheckExistSubCategoryEName(string SubCategoryEName)
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

        public List<DataBase.Entities.Brand> GetAllBrands()
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Entities.Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public DataBase.Entities.Brand GetBrandByEname(string eName)
        {
            throw new NotImplementedException();
        }

        public DataBase.Entities.Brand GetBrandById(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCatrgories(int MainCategoryId)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Entities.Product> GetListProductByParameters(string name, string ename, string description, string tags)
        {
            throw new NotImplementedException();
        }

        public List<MainCategory> GetMainCategories()
        {
            using (var db=new StoreContext(null))
            {
                return db.MainCategories.ToList();
            }
        }

        public MainCategory GetMainCategory(int MainCategoryId)
        {
            throw new NotImplementedException();
        }

        public DataBase.Entities.Product GetProductById(int ProductId)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Entities.Comment> GetProductComments(int productId)
        {
            throw new NotImplementedException();
        }

        public List<SubCategory> GetSubCatrgories()
        {
            throw new NotImplementedException();
        }

        public List<SubCategory> GetSubCatrgories(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveBrand(int brandId)
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

        public bool RemoveMainCategory(int mainCatrrgoryId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveProduct(int ProductId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveSubCategory(int subCatrgoryId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBrand(DataBase.Entities.Brand brand, int brandId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCaregory(Category category, int CatrgoryId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMainCaregory(MainCategory mainCatrgory, int mainCatrgoryId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(DataBase.Entities.Product product, int Id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSubCaregory(SubCategory subCategory, int SubCatrgoryId)
        {
            throw new NotImplementedException();
        }
    }
}
