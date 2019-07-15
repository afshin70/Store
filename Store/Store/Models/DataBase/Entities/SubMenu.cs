using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    public class SubMenu
    {
        /// <summary>
        /// آی دی زیر منو
        /// </summary>
        public int SubMenuId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// آدرس
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// آیا فعال است
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// وضعیت حذف
        /// </summary>
        public bool IsDeleted { get; set; }

        #region ForeignKeys
        /// <summary>
        /// آی دی منو
        /// </summary>
        public int MenuId { get; set; }
        #endregion
        #region NavigationProps
        public Menu Menu { get; set; }
        #endregion
    }
    public class SubMenuConfig : IEntityTypeConfiguration<SubMenu>
    {
        public void Configure(EntityTypeBuilder<SubMenu> builder)
        {
            #region Relations
            builder.HasKey(k => k.SubMenuId);
            #endregion

            #region Properties
            builder.Property(p => p.Name).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Url).IsRequired();
            #endregion
        }
    }
}
