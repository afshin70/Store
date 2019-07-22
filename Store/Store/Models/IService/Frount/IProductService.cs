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

        #region کامنت
        /// <summary>
        /// کامنت جدید
        /// </summary>
        /// <param name="comment">کامنت</param>
        /// <param name="ProductId">آی دی محصول</param>
        /// <returns></returns>
        bool AddComment(DataBase.Dto.Admin.Comment comment, int ProductId);
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
        List<Category> GetPopularCategory();
        #endregion

    }
}
