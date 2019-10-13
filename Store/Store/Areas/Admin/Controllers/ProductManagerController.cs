using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Store.Areas.Admin.Models.ViewModels;
using Store.Models;
using Store.Models.DataBase.Dto.Admin;
using Store.Models.DataBase.Entities;
using Store.Models.IService;
using Store.Models.IService.Admin;

namespace Store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductManagerController : Controller
    {
        private IHostingEnvironment env;
        private IProductService PService;
        private IFileService fileService;
        public ProductManagerController(IProductService productService, IFileService _fileService, IHostingEnvironment _env)
        {
            PService = productService;
            fileService = _fileService;
            env = _env;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(ProductAddVM product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            string thmbnailPath = env.WebRootPath + @"\lib\images\products\thumbnail";
            string saveImagePath = env.WebRootPath + @"\lib\images\products";

            string imageName1 = string.Empty.GetNewName();
            string imageName2 = string.Empty.GetNewName();
            string imageName3 = string.Empty.GetNewName();
            string imageName4 = string.Empty.GetNewName();
            ProductImage productImage = new ProductImage
            {
                Thumbnail = imageName1,
                Image_1 = imageName1,
                Image_2 = imageName2,
                Image_3 = imageName3,
                Image_4 = imageName4
            };

            var save_Thubnailimage_Result = fileService.SaveImageFile(product.Image1, 229, 229, thmbnailPath, imageName1);
            var save_image1_Result = fileService.SaveImageFile(product.Image1, 700, 700, saveImagePath, imageName1);
            var save_image2_Result = fileService.SaveImageFile(product.Image1, 700, 700, saveImagePath, imageName2);
            var save_image3_Result = fileService.SaveImageFile(product.Image1, 700, 700, saveImagePath, imageName3);
            var save_image4_Result = fileService.SaveImageFile(product.Image1, 700, 700, saveImagePath, imageName3);

            var addResult = PService.AddProduct(new Store.Models.DataBase.Entities.Product
            {
                BrandId = product.BrandId,
                EName = product.EName,
                ExistCount = product.ExistCount,
                Features = product.Features,
                Images_Json = productImage.ToJsonImage(),
                InsertedDate = DateTime.Now,
                IsActive = product.IsActive,
                IsDeleted = false,
                IsSpecial = product.IsSpecial,
                MainDescription = product.MainDescription,
                Name = product.Name,
                SalesPrice = product.SalesPrice,
                ShortDescription = product.ShortDescription,
                Tags = product.Tags,
                SubCategoryId = product.SubCategoryId,
                UnitType = product.UnitType,
                WrittenPrice = product.WrittenPrice.HasValue? product.WrittenPrice.Value:0
            });
            if (addResult)
            {
                return View("Index");
            }
            return View(product);
        }
    }
}