using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// آدرس کاربر
    /// </summary>
    public class Address
    {
        /// <summary>
        /// آی دی آدرس
        /// </summary>
        public int AddressId { get; set; }
        /// <summary>
        /// آی دی کاربر
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// آی دی شهر
        /// </summary>
        public int CityId { get; set; }
        /// <summary>
        /// عنوان یا نام آدرس
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// کد پستی
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// وضعیت حذف
        /// </summary>
        public bool IsDeleted { get; set; }
        #region NavigationProps
        public User User { get; set; }
        #endregion
    }
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            #region Relations
            builder.HasKey(k => k.AddressId);
            #endregion

            #region Properties
            builder.Property(p => p.Name).HasColumnType("nvarchar(50)");
            builder.Property(p => p.Description).HasColumnType("nvarchar(500)");
            builder.Property(p => p.PostalCode).HasColumnType("nvarchar(50)");
            #endregion
        }
    }
}
