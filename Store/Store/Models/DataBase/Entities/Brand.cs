using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// برند
    /// </summary>
    public class Brand
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int BrandId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// تصویر بند انگشتی
        /// </summary>
        public string TumbImageUrl { get; set; }

        #region NavigationProps
        //public ICollection<Product> Products { get; set; }
        #endregion
    }
    public class BrandConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            #region Relations
            builder.HasKey(k => k.BrandId);
            builder.HasMany<Product>().WithOne(p => p.Brand).HasForeignKey(fk => fk.BrandId);
            #endregion

            #region Properties
            builder.Property(p => p.Name).HasColumnType("nvarchar(50)");
            builder.Property(p => p.EName).HasColumnType("nvarchar(50)");
            builder.Property(p => p.Description).HasColumnType("nvarchar(1000)");
            builder.Property(p => p.TumbImageUrl).HasColumnType("nvarchar(250)");
            #endregion
        }
    }
}
