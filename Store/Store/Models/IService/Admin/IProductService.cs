using Store.Models.DataBase.Dto.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.IService.Admin
{
    interface IProductService
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
        /// کامنت جدید
        /// </summary>
        /// <param name="comment">کامنت</param>
        /// <param name="ProductId">آی دی محصول</param>
        /// <returns></returns>
        bool AddComment(DataBase.Dto.Admin.Comment comment, int ProductId);
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
        #endregion

        #region عملیات زیر دسته بندی محصول
        /// <summary>
        /// اضافه کردن زیردسته جدید
        /// </summary>
        /// <param name="subCatrgory">زیردسته جدید</param>
        /// <returns></returns>
        bool AddMainSubCategory(SubCatrgory subCatrgory);
        /// <summary>
        /// حذف زیردسته
        /// </summary>
        /// <param name="CatrgoryId">آی دی زیردسته</param>
        /// <returns></returns>
        bool RemoveSubCategory(int CatrgoryId);
        /// <summary>
        /// بروزرسانی زیردسته
        /// </summary>
        /// <param name="subCatrgory">زیردسته بروزرسانی شده</param>
        /// <param name="SubCatrgoryId">آی دی زردسته ای که قرار است بروز شود</param>
        /// <returns></returns>
        bool UpdateSubCaregory(SubCatrgory subCatrgory, int SubCatrgoryId);
        /// <summary>
        /// چک کردن زیردسته تکراری
        /// </summary>
        /// <param name="SubCategoryName"></param>
        /// <returns></returns>
        bool CheckExistSubCategoryName(string SubCategoryName);
        /// <summary>
        /// لیست زیردسته ها
        /// </summary>
        /// <returns></returns>
        List<SubCatrgory> GetSubCatrgories();
        /// <summary>
        /// لیست زیردسته ها برحسب دسته
        /// </summary>
        /// <param name="CategoryId">آی دی دسته</param>
        /// <returns></returns>
        List<SubCatrgory> GetSubCatrgories(int CategoryId);
        #endregion

        #region عملیات دسته بندی محصول
        /// <summary>
        /// اضافه کردن دسته جدید
        /// </summary>
        /// <param name="catrgory">دسته جدید</param>
        /// <returns></returns>
        bool AddMainCategory(Catrgory catrgory);
        /// <summary>
        /// حذف دسته بندی
        /// </summary>
        /// <param name="CatrgoryId">آی دی دسته</param>
        /// <returns></returns>
        bool RemoveCategory(int CatrgoryId);
        /// <summary>
        /// آپدیت یک دسته
        /// </summary>
        /// <param name="catrgory">مشخصات دسته جدید</param>
        /// <param name="CatrgoryId">آی دی دسته ای که آپدیت میشود</param>
        /// <returns></returns>
        bool UpdateCaregory(Catrgory catrgory, int CatrgoryId);
        /// <summary>
        /// چک کردن وجود دسته تکراری برای دسته جدید
        /// </summary>
        /// <param name="CategoryName">نام دسته جدید</param>
        /// <returns></returns>
        bool CheckExistCategoryName(string CategoryName);
        /// <summary>
        /// لیست دسته ها
        /// </summary>
        /// <returns></returns>
        List<Catrgory> GetCatrgories();
        /// <summary>
        /// لیست دسته ها برحسب دسته اصلی
        /// </summary>
        /// <param name="MainCategoryId"></param>
        /// <returns></returns>
        List<Catrgory> GetCatrgories(int MainCategoryId);
        #endregion

        #region عملیات دسته بندی اصلی محصول
        /// <summary>
        /// اضافه کردن دسته بندی اصلی
        /// </summary>
        /// <param name="mainCatrgory">مشخصات دسته بندی</param>
        /// <returns></returns>
        bool AddMainCategory(MainCatrgory mainCatrgory);
        /// <summary>
        /// حذف دسته بندی اصلی
        /// </summary>
        /// <param name="mainCatrgoryId">آی دی دسته </param>
        /// <returns></returns>
        bool RemoveMainCategory(int mainCatrgoryId);
        /// <summary>
        /// آپدیت دسته
        /// </summary>
        /// <param name="mainCatrgory">مشخصات جدید</param>
        /// <param name="mainCatrgoryId">آی دی دسته ای که آپدیت می شود</param>
        /// <returns></returns>
        bool UpdateMainCaregory(MainCatrgory mainCatrgory, int mainCatrgoryId);
        /// <summary>
        /// چک کردن وجود یک دسته براساس نام
        /// </summary>
        /// <param name="CategoryName">نام دسته</param>
        /// <returns></returns>
        bool CheckExistMainCategoryName(string CategoryName);
        /// <summary>
        /// لیست دسته بندی های اصلی
        /// </summary>
        /// <returns></returns>
        List<MainCatrgory> GetMainCatrgories();
        #endregion

        #region عملیات مدیریت
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
