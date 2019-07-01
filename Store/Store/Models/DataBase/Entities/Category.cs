using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
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
        /// <summary>
        /// آدرس تصویر
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// آیکن دسته بندی
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// شماره اولویت
        /// </summary>
        public int OrderNumber { get; set; }
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsEnabled { get; set; }
        /// <summary>
        /// وضعیت حذف شدن
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// آیا جزو دسته محبو ها است؟
        /// </summary>
        public bool IsFavorate { get; set; }

        #region ForeignKeys
        /// <summary>
        /// آی دی دسته بندی اصلی
        /// </summary>
        public int MainCategoryId { get; set; }

        #endregion

        #region NavigationProps
        public MainCategory MainCategory { get; set; }
        //public ICollection<SubCategory> SubCategories { get; set; }
        #endregion
    }
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            #region Relations
            builder.HasKey(k => k.CategoryId);
            builder.HasMany<SubCategory>().WithOne(p => p.Category).HasForeignKey(fk => fk.CategoryId);
            #endregion

            #region Properties
            builder.Property(p => p.Name).HasColumnType("nvarchar(50)");
            builder.Property(p => p.EName).HasColumnType("nvarchar(50)");
            builder.Property(p => p.Description).HasColumnType("nvarchar(1000)");
            builder.Property(p => p.ImageUrl).HasColumnType("nvarchar(250)");
            builder.Property(p => p.Icon).HasColumnType("nvarchar(50)");
            #endregion
        }
    }
}
