using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
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
        /// آیکن
        /// </summary>
        //public string Icon { get; set; }
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// وضعیت حذف
        /// </summary>
        //public bool IsDeleted { get; set; }

        #region NavigationProps
        //public ICollection<Category> Categories { get; set; }
        #endregion
    }
    public class MainCategoryConfig : IEntityTypeConfiguration<MainCategory>
    {
        public void Configure(EntityTypeBuilder<MainCategory> builder)
        {
            #region Relations
            builder.HasKey(k => k.MainCategoryId);
            builder.HasMany<Category>().WithOne(p => p.MainCategory).HasForeignKey(fk => fk.MainCategoryId);
            #endregion

            #region Properties
            builder.Property(p => p.Name).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Name).IsUnicode();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.EName).HasColumnType("nvarchar(100)");
            builder.Property(p => p.EName).IsRequired();
            #endregion
        }
    }
}
