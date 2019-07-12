using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// محصول
    /// </summary>
    public class Product
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        /// <summary>
        /// توضیحات کوتاه
        /// </summary>
        public string ShortDescription { get; set; }
        /// <summary>
        /// توضیحات اصلی
        /// </summary>
        public string MainDescription { get; set; }
        /// <summary>
        /// تصاویر
        /// </summary>
        public string Images_Json { get; set; }
        /// <summary>
        /// تگ محصول
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// برند کالا
        /// </summary>
        public int BrandId { get; set; }
        /// <summary>
        /// تعداد فروش
        /// </summary>
        public int SoldCount { get; set; }
        /// <summary>
        /// تعداد بادید
        /// </summary>
        public int VisitedCount { get; set; }
        /// <summary>
        /// تعداد موجود
        /// </summary>
        public int ExistCount { get; set; }
        /// <summary>
        /// بیشترین مبلغی که تخفیف مجاز است
        /// </summary>
        public decimal MaxDiscountPrice { get; set; }
        /// <summary>
        /// ویژگی ها بصورت html
        /// </summary>
        public string Features { get; set; }
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        ///  واحد کالا
        /// </summary>
        public string UnitType { get; set; }
        /// <summary>
        /// مبلغ فروش
        /// </summary>
        public decimal SalesPrice { get; set; }
        /// <summary>
        /// مبلغ اصلی
        /// </summary>
        public decimal WrittenPrice { get; set; }
        /// <summary>
        /// محصول ویژه
        /// </summary>
        public bool IsSpecial { get; set; }
        /// <summary>
        /// هشدار کمتر از
        /// </summary>
        public int MinCountNotify { get; set; }
        /// <summary>
        /// تاریخ افزودن محصول
        /// </summary>
        public DateTime InsertedDate { get; set; }
        /// <summary>
        /// وضعیت حذف
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// امتیاز کالا
        /// </summary>
        public int Rating { get; set; }

        #region ForeignKeys
        /// <summary>
        /// آی دی زیر دسته بندی
        /// </summary>
        public int SubCategoryId { get; set; }
        #endregion

        #region NavigationProps
        public SubCategory SubCategory { get; set; }
        public Brand Brand { get; set; }
        //public ICollection<Comment> Comments { get; set; }
        #endregion
    }
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            #region Relations
            builder.HasKey(k => k.ProductId);
            builder.HasMany<Comment>().WithOne(p => p.Product).HasForeignKey(fk => fk.ProductId);
            #endregion

            #region Properties
            builder.Property(p => p.Name).HasColumnType("nvarchar(50)");
            builder.Property(p => p.EName).HasColumnType("nvarchar(50)");
            builder.Property(p => p.ShortDescription).HasColumnType("nvarchar(1000)");
            builder.Property(p => p.MaxDiscountPrice).HasColumnType("decimal(16,3)");
            builder.Property(p => p.Tags).HasColumnType("nvarchar(250)");
            builder.Property(p => p.UnitType).HasColumnType("nvarchar(20)");
            builder.Property(p => p.SalesPrice).HasColumnType("decimal(16,3)");
            builder.Property(p => p.WrittenPrice).HasColumnType("decimal(16,3)");
            builder.Property(p => p.InsertedDate).HasColumnType("smalldatetime");
            #endregion
        }
    }
}
