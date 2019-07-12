using Store.Models.DataBase.Dto.Frount.Category;
using Store.Models.DataBase.Dto.Frount.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Store.Models.IService
{
    interface IProductService
    {
        #region عملیات مدیریت
        /// <summary>
        /// اضافه کردن محصول جدید
        /// </summary>
        /// <param name="product">Admin/Dtto/Product</param>
        /// <returns></returns>
        bool AddProduct(DataBase.Dto.Admin.Product product);
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
        bool UpdateProduct(DataBase.Dto.Admin.Product product,int Id);
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
        DataBase.Dto.Admin.Product GetProductById(int ProductId);
        /// <summary>
        /// پیدا کردن یک محصول با نام،نام انگلیسی،توضیحات کوتاه،تگ ها
        /// این متد برای جستجوی محصولات در مدیریت محصولات استفاده میشود.
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        List<DataBase.Dto.Admin.Product> GetListProductByParameters(string name,string ename,string description,string tags);
        /// <summary>
        /// دریافت تمام محصولات در صفحه مدیریت محصول
        /// </summary>
        /// <returns></returns>
        List<DataBase.Dto.Admin.Product> GetAllProducts();
        #endregion

        #region متدهای صفحه اصلی
        /// <summary>
        /// دریافت لیست محصولات ویژه
        /// </summary>
        /// <param name="count_Of">تعداد - پیشفرض 6 تا محصول</param>
        /// <returns></returns>
        List<Product> GetSpecialProducts(int count_Of = 8);
        /// <summary>
        /// دریافت محصولات پرفروش
        /// </summary>
        /// <param name="count_Of">تعداد که مقدار پیشفرض 7 است</param>
        /// <returns></returns>
        List<Product> GetbestSellersProducts(int count_Of = 7);
        /// <summary>
        /// دریافت محصولات امتیاز بالا
        /// </summary>
        /// <param name="count_Of">تعد محصولات که پیشفرض برابر 3 است</param>
        /// <returns></returns>
        List<Product> GetHighScoreProducts(int count_Of = 3);
        /// <summary>
        /// دریافت محصولات فروش ویژه
        /// </summary>
        /// <param name="count_Of">تعداد که پیشفرض برابر 3 است</param>
        /// <returns></returns>
        List<Product> GetSpecialOffersProducts(int count_Of = 3);
        /// <summary>
        /// دریافت محصولات تصادفی
        /// </summary>
        /// <param name="count_Of">تعداد که پیشفرض 3 هست</param>
        /// <returns></returns>
        List<Product> GetRandomProducts(int count_Of = 3);
        /// <summary>
        /// -  دریافت دسته بندی های محبوب
        /// دسته ها و زیر دسته ها
        /// </summary>
        /// <returns></returns>
        Category GetPopularCategory();
        #endregion

    }
}
