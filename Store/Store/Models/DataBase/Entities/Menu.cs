using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// منو بالای سایت
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// منو آی دی
        /// </summary>
        public int MenuId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// لینک
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// وضعیت فعال
        /// </summary>
        public bool IsActive { get; set; }
        ///// <summary>
        ///// وضعیت حذف
        ///// </summary>
        //public bool IsDeleted { get; set; }

    }
    public class MenuConfig : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            #region Relations
            builder.HasKey(k => k.MenuId);
            builder.HasMany<SubMenu>().WithOne(p => p.Menu).HasForeignKey(fk => fk.MenuId);
            #endregion

            #region Properties
            builder.Property(p => p.Name).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Url).HasColumnType("nvarchar(300)");
            #endregion
        }
    }
}
