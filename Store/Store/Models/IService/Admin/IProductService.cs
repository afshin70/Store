using Store.Models.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.IService.Admin
{
   public interface IProductService
    {
        #region عملیات برند
        /// <summary>
        /// افزودن برند
        /// </summary>
        /// <param name="brand">برند</param>
        /// <returns></returns>
        bool AddProductBrand(Brand brand);
        /// <summary>
        /// حذف برند
        /// </summary>
        /// <param name="brandId">آی دی برند</param>
        /// <returns></returns>
        bool RemoveBrand(int brandId);
        /// <summary>
        /// بروزرسانی برند
        /// </summary>
        /// <param name="brand">برند</param>
        /// <param name="brandId">آی دی برند </param>
        /// <returns></returns>
        bool UpdateBrand(Brand brand, int brandId);
        /// <summary>
        /// چک کردن اینکه نام انگلیسی برند تکراری نباشد
        /// </summary>
        /// <param name="eName">نام انگلیسی و منحصر به فرد</param>
        /// <returns></returns>
        bool CheckExistBrandEName(string eName);
        /// <summary>
        /// چک کردن اینکه نام  برند تکراری نباشد
        /// </summary>
        /// <param name="name">نام انگلیسی و منحصر به فرد</param>
        /// <returns></returns>
        bool CheckExistBrandName(string name);
        /// <summary>
        /// لیست همه برند ها
        /// </summary>
        /// <returns></returns>
        List<Brand> GetAllBrands();
        /// <summary>
        /// اطلاعات برند برحسب آی دی
        /// </summary>
        /// <param name="brandId">آی دی</param>
        /// <returns></returns>
        Brand GetBrandById(int brandId);
        /// <summary>
        ///  اطلاعات برند برحسب نام انگلیسی 
        /// </summary>
        /// <param name="eName">نام انگلیسی و منحصر به فرد</param>
        /// <returns></returns>
        Brand GetBrandByEname(string eName);
        #endregion

        #region عملیات کامنت
       
        /// <summary>
        /// حذف کامنت
        /// </summary>
        /// <param name="commentId">آی دی کامنت</param>
        /// <returns></returns>
        bool RemoveComment(int commentId);
        /// <summary>
        /// کامنت خوانده شد
        /// </summary>
        /// <param name="commentId">آی دی کامنت</param>
        /// <returns></returns>
        bool CommentReaded(int commentId);
        /// <summary>
        /// تایید کامنت
        /// </summary>
        /// <param name="commentId">آی دی کامنت</param>
        /// <returns></returns>
        bool CommentVerification(int commentId);
        /// <summary>
        /// کامنت نمایش داده شود
        /// </summary>
        /// <param name="commentId">آی دی کامنت</param>
        /// <returns></returns>
        bool CommentShow(int commentId);
        /// <summary>
        /// لیست کامنتهای یک محصول
        /// </summary>
        /// <param name="productId">آی دی محصول</param>
        /// <returns></returns>
        List<Comment> GetProductComments(int productId);
        #endregion

        #region عملیات زیر دسته بندی محصول
        /// <summary>
        /// اضافه کردن زیردسته جدید
        /// </summary>
        /// <param name="subCatrgory">زیردسته جدید</param>
        /// <returns></returns>
        bool AddSubCategory(SubCategory subCategory);
        /// <summary>
        /// حذف زیردسته
        /// </summary>
        /// <param name="CatrgoryId">آی دی زیردسته</param>
        /// <returns></returns>
        bool RemoveSubCategory(int subCatrgoryId);
        /// <summary>
        /// بالا بردن اولویت نمایش دسته
        /// </summary>
        /// <param name="subCatrgoryId">آی دی دسته</param>
        /// <returns></returns>
        bool LevelUpSubCategory(int subCatrgoryId);
        /// <summary>
        /// پایین آوردن اویت دسته
        /// </summary>
        /// <param name="subCatrgoryId">آی دی دسته</param>
        /// <returns></returns>
        bool LevelDownSubCategory(int subCatrgoryId);
        /// <summary>
        /// بروزرسانی زیردسته
        /// </summary>
        /// <param name="subCatrgory">زیردسته بروزرسانی شده</param>
        /// <param name="SubCatrgoryId">آی دی زردسته ای که قرار است بروز شود</param>
        /// <returns></returns>
        bool UpdateSubCaregory(SubCategory subCategory, int SubCatrgoryId);
        /// <summary>
        /// چک کردن زیردسته تکراری
        /// </summary>
        /// <param name="SubCategoryName"></param>
        /// <returns></returns>
        bool CheckExistSubCategoryName(string SubCategoryName);
        /// <summary>
        /// چک کردن نام انگلیسی تکراری
        /// </summary>
        /// <param name="SubCategoryEName">نام انگلیسی</param>
        /// <returns></returns>
        bool CheckExistSubCategoryEName(string SubCategoryEName);
        /// <summary>
        /// فعال و غیر فعال کردن زیرگروه یا زیر دسته
        /// </summary>
        /// <param name="subctegory_id">آی دی گروه یا دسته</param>
        /// <param name="isActive">فعال باشه یا نباشه</param>
        /// <returns></returns>
        bool ActiveSubCategory(int subctegory_id, bool isActive);
        /// <summary>
        /// لیست تمام زیردسته ها
        /// </summary>
        /// <returns></returns>
        List<SubCategory> GetSubCatrgories();
        /// <summary>
        /// لیست زیردسته ها برحسب دسته
        /// </summary>
        /// <param name="CategoryId">آی دی دسته</param>
        /// <returns></returns>
        List<SubCategory> GetSubCatrgories(int CategoryId);
        #endregion

        #region عملیات دسته بندی محصول
        /// <summary>
        /// اضافه کردن دسته جدید
        /// </summary>
        /// <param name="catrgory">دسته جدید</param>
        /// <returns></returns>
        bool AddCategory(Category catrgory);
        /// <summary>
        /// حذف دسته بندی
        /// </summary>
        /// <param name="CatrgoryId">آی دی دسته</param>
        /// <returns></returns>
        bool RemoveCategory(int CatrgoryId);
        /// <summary>
        /// بالا بردن اولویت
        /// </summary>
        /// <param name="CatrgoryId">آی دی گروه</param>
        /// <returns></returns>
        bool LevelUpCategory(int CatrgoryId);
        /// <summary>
        /// پایین آوردن اولویت
        /// </summary>
        /// <param name="CatrgoryId">آی دی گروه</param>
        /// <returns></returns>
        bool LevelDownCategory(int CatrgoryId);
        /// <summary>
        /// آپدیت یک دسته
        /// </summary>
        /// <param name="catrgory">مشخصات دسته جدید</param>
        /// <param name="CatrgoryId">آی دی دسته ای که آپدیت میشود</param>
        /// <returns></returns>
        bool UpdateCaregory(Category category, int CatrgoryId);
        /// <summary>
        /// فعال و غیر فعال کردن گروه یا دسته
        /// </summary>
        /// <param name="ctegory_id">آی دی گروه یا دسته</param>
        /// <param name="isActive">فعال باشه یا نباشه</param>
        /// <returns></returns>
        bool ActiveCategory(int ctegory_id, bool isActive);
        /// <summary>
        /// چک کردن وجود دسته تکراری برای دسته جدید
        /// </summary>
        /// <param name="CategoryName">نام دسته جدید</param>
        /// <returns></returns>
        bool CheckExistCategoryName(string CategoryName);
        /// <summary>
        /// چک کردن نام انگلیسی
        /// </summary>
        /// <param name="CategoryEName">نام انگلیسی</param>
        /// <returns></returns>
        bool CheckExistCategoryEName(string CategoryEName);

        bool CheckExistOneCategoryName(string CategoryName, int CategoryId);
        bool CheckExistOneCategoryEName(string CategoryEName, int CategoryId);

        /// <summary>
        /// لیست دسته ها
        /// </summary>
        /// <returns></returns>
        List<Category> GetCategories();
        /// <summary>
        /// لیست دسته ها برحسب دسته اصلی
        /// </summary>
        /// <param name="MainCategoryId"></param>
        /// <returns></returns>
        Category GetCategory(int CategoryId);
        #endregion

        #region عملیات دسته بندی اصلی محصول
        /// <summary>
        /// گرفتن اطلاعات یک دسته اصلی
        /// </summary>
        /// <param name="MainCategoryId"></param>
        /// <returns></returns>
        MainCategory GetMainCategory(int MainCategoryId);
        /// <summary>
        /// اضافه کردن دسته بندی اصلی
        /// </summary>
        /// <param name="mainCategory">مشخصات دسته بندی</param>
        /// <returns></returns>
        bool AddMainCategory(MainCategory mainCategory);
        /// <summary>
        /// حذف دسته بندی اصلی
        /// </summary>
        /// <param name="mainCatrgoryId">آی دی دسته </param>
        /// <returns></returns>
        bool RemoveMainCategory(int mainCatrrgoryId);

        /// <summary>
        /// بالا بردن اولویت نمایش
        /// </summary>
        /// <param name="mainCatrrgoryId">ای دی گروه</param>
        /// <returns></returns>
        bool LevelUpMainCategory(int mainCatrrgoryId);
        /// <summary>
        /// پایین آوردن اولویت نمایش
        /// </summary>
        /// <param name="mainCatrrgoryId">آی دی گروه</param>
        /// <returns></returns>
        bool LevelDownMainCategory(int mainCatrrgoryId);
        /// <summary>
        /// آپدیت دسته
        /// </summary>
        /// <param name="mainCatrgory">مشخصات جدید</param>
        /// <param name="mainCatrgoryId">آی دی دسته ای که آپدیت می شود</param>
        /// <returns></returns>
        bool UpdateMainCaregory(MainCategory mainCatrgory, int mainCatrgoryId);
        /// <summary>
        /// چک کردن وجود یک دسته براساس نام
        /// </summary>
        /// <param name="CategoryName">نام دسته</param>
        /// <returns></returns>
        bool CheckExistMainCategoryName(string CategoryName);
        /// <summary>
        /// چک کردن وجود یک دسته براساس نام انگلیسی
        /// </summary>
        /// <param name="CategoryEName">نام انگلیسی دسته</param>
        /// <returns></returns>
        bool CheckExistMainCategoryEName(string CategoryEName);

        bool CheckExistOneMainCategoryName(string CategoryName, int MainCategoryId);
        bool CheckExistOneMainCategoryEName(string CategoryEName, int MainCategoryId);

        /// <summary>
        /// فعال و غیر فعال کردن گروه یا دسته اصلی
        /// </summary>
        /// <param name="main_ctegory_id">آی دی گروه یا دسته</param>
        /// <param name="isActive">فعال باشه یا نباشه</param>
        /// <returns></returns>
        bool ActiveMainCategory(int main_ctegory_id, bool isActive);
        /// <summary>
        /// لیست دسته بندی های اصلی
        /// </summary>
        /// <returns></returns>
        List<MainCategory> GetMainCategories();
        #endregion

        #region عملیات مدیریت محصول
        /// <summary>
        /// اضافه کردن محصول جدید
        /// </summary>
        /// <param name="product">Admin/Dtto/Product</param>
        /// <returns></returns>
        bool AddProduct(Product product);
        /// <summary>
        /// حذف یک محصول
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        bool RemoveProduct(int ProductId);
        /// <summary>
        /// آپدیت یک محصول
        /// </summary>
        /// <param name="product">اطلاعات محصول</param>
        /// <param name="Id">آی دی محصولی که قرار است آپدیت شود</param>
        /// <returns></returns>
        bool UpdateProduct(Product product, int Id);
        /// <summary>
        /// چک کردن نام انگلیسی یونیک در محصولات
        /// </summary>
        /// <param name="ename"></param>
        /// <returns></returns>
        bool CheckEnameOfProduct(string ename);
        /// <summary>
        /// پیدا کردن یک محصول با آی دی
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        Product GetProductById(int ProductId);
        /// <summary>
        /// پیدا کردن یک محصول با نام،نام انگلیسی،توضیحات کوتاه،تگ ها
        /// این متد برای جستجوی محصولات در مدیریت محصولات استفاده میشود.
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        List<Product> GetListProductByParameters(string name, string ename, string description, string tags);
        /// <summary>
        /// دریافت تمام محصولات در صفحه مدیریت محصول
        /// </summary>
        /// <returns></returns>
        List<Product> GetAllProducts();
        #endregion
    }
}
