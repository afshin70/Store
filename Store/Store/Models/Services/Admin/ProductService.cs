using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Store.Models.DataBase.Dto.Admin;
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
        public bool AddCategory(Catrgory catrgory)
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

        public bool AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool AddProductBrand(Brand brand)
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

        public List<Brand> GetAllBrands()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Brand GetBrandByEname(string eName)
        {
            throw new NotImplementedException();
        }

        public Brand GetBrandById(int brandId)
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

        public List<Product> GetListProductByParameters(string name, string ename, string description, string tags)
        {
            throw new NotImplementedException();
        }

        public List<MainCatrgory> GetMainCatrgories()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int ProductId)
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

        public bool UpdateBrand(Brand brand, int brandId)
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

        public bool UpdateProduct(Product product, int Id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSubCaregory(SubCatrgory subCatrgory, int SubCatrgoryId)
        {
            throw new NotImplementedException();
        }
    }
}
