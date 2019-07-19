using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Frount.Category
{
    /// <summary>
    /// دسته بندی اصلی
    /// </summary>
    public class MainCategory
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int MainCategoryId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        /// <summary>
        /// گروه های زیرین
        /// </summary>
        public List<Category> Categories { get; set; }
    }
    /// <summary>
    /// دسته بندی 
    /// </summary>
    public class Category
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// آی دی دسته بندی اصلی
        /// </summary>
        public int MainCategoryId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// نام لاتین
        /// </summary>
        public string EName { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        public List<SubCategory> SubCategoriess { get; set; }

    }
    /// <summary>
    /// زیر دسته بندی
    /// </summary>
    public class SubCategory
    {
        /// <summary>
        /// آی دی 
        /// </summary>
        public int SubCategoryId { get; set; }
        /// <summary>
        /// آی دی دسته بندی
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
    }
    
}
