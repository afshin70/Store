using Newtonsoft.Json;
using Store.Models.DataBase.Entities;
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
        public bool AddComment(DataBase.Entities.Comment comment, int ProductId)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Entities.Product> GetbestSellersProducts(int count_Of = 7)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Entities.Product> GetHighScoreProducts(int count_Of = 3)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Entities.Category> GetPopularCategory()
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Entities.Product> GetRandomProducts(int count_Of = 3)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Entities.Product> GetSpecialOffersProducts(int count_Of = 3)
        {
            throw new NotImplementedException();
        }

        public List<DataBase.Entities.Product> GetSpecialProducts(int count_Of = 8)
        {
            throw new NotImplementedException();
        }
    }
}
