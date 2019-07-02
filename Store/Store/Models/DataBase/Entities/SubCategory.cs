using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
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
        /// <summary>
        /// لینک
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// آیکن
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// شماره اولویت
        /// </summary>
        public int OrderNumber { get; set; }
        /// <summary>
        /// آدرس تصویر
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// وضعیت فال بودن
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// وضعیت حذف شدن
        /// </summary>
        public bool IsDeleted { get; set; }

        #region ForeignKeys
        /// <summary>
        /// آی دی دسته بندی
        /// </summary>
        public int CategoryId { get; set; }
        #endregion

        #region NavigationProps
        public Category Category { get; set; }
        //public ICollection<Product> Products { get; set; }
        #endregion
    }
    public class SubCategoryConfig : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            #region Relations
            builder.HasKey(k => k.SubCategoryId);
            builder.HasMany<Product>().WithOne(p => p.SubCategory).HasForeignKey(fk => fk.SubCategoryId);

            #endregion

            #region Properties
            builder.Property(p => p.Name).HasColumnType("nvarchar(50)");
            builder.Property(p => p.EName).HasColumnType("nvarchar(50)");
            builder.Property(p => p.Description).HasColumnType("nvarchar(1000)");
            builder.Property(p => p.Icon).HasColumnType("nvarchar(50)");
            builder.Property(p => p.ImageUrl).HasColumnType("nvarchar(50)");
            #endregion
        }
    }
}
