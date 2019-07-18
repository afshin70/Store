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
        public bool AddComment(Comment comment, int ProductId)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Dto.Frount.Product.Product> GetbestSellersProducts(int count_Of = 7)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Dto.Frount.Product.Product> GetHighScoreProducts(int count_Of = 3)
        {
            throw new NotImplementedException();
        }

        public Category GetPopularCategory()
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
    }
}
