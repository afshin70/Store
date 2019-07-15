using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// کاربر
    /// </summary>
    public class User
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// نام کاربری - ایمیل
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// نام و نام خانوادگی
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// شماره تماس
        /// </summary>
        public string MobileNo { get; set; }
        /// <summary>
        /// تلفن ثابت
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// آدرس
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// شهر
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// استان
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// بیوگرافی
        /// </summary>
        public string Biography { get; set; }
        /// <summary>
        /// جنسیت
        /// </summary>
        public bool Gender { get; set; }
        /// <summary>
        /// گذر واژه
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// توکن ارسالی
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// مقدار ترکیب شده با گذر واژه
        /// </summary>
        public string Salt { get; set; }
        /// <summary>
        /// تاریخ ثبت نام
        /// </summary>
        public DateTime RegisterDate { get; set; }
        /// <summary>
        /// آی پی ریجستر شده
        /// </summary>
        //public string UserIpRegistered { get; set; }
        /// <summary>
        /// ایمیل
        /// </summary>
        //public string Email { get; set; }//username
        /// <summary>
        /// وضعیت تایید
        /// </summary>
        public bool IsVerified { get; set; }
        /// <summary>
        /// کد تایید
        /// </summary>
        public string ActivationCode { get; set; }
        /// <summary>
        /// تاریخ انقضا کد تایید
        /// </summary>
        public DateTime ActivationCodeExpireDate { get; set; }
        /// <summary>
        /// تاریخ بلاک
        /// </summary>
        public DateTime BlockedDate { get; set; }
        /// <summary>
        /// وضعیت بلاک بودن
        /// </summary>
        public bool IsBlock { get; set; }
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// تاریخ حذف
        /// </summary>
        public DateTime DeletedDate { get; set; }
        /// <summary>
        ///وضعیت حذف
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// محصولات مورد علاقه
        /// </summary>
        public string FavorateProduct_Json { get; set; }

        #region ForeignKeys
        /// <summary>
        /// نقش کاربر
        /// </summary>
        public string Role { get; set; }//role string
        #endregion

        #region NavigationProps
        //public City City { get; set; }
        //public ShopingCart ShopingCart { get; set; }
        //public ICollection<Order> Orders { get; set; }
        #endregion
    }
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            #region Relations
            builder.HasKey(k => k.UserId);
            //builder.HasOne<City>().WithMany(b => b.Users).HasForeignKey(fk => fk.CityId);
            builder.HasMany<Order>().WithOne(p => p.User).HasForeignKey(fk => fk.UserId);
            //builder.HasMany<Address>().WithOne(p => p.User).HasForeignKey(fk => fk.UserId);
            #endregion

            #region Properties
            builder.Property(p => p.UserName).HasColumnType("nvarchar(50)");
            builder.Property(p => p.UserName).IsRequired();
            builder.Property(p => p.FullName).HasColumnType("nvarchar(100)");
            builder.Property(p => p.MobileNo).HasColumnType("nvarchar(50)");
            builder.Property(p => p.Tel).HasColumnType("nvarchar(50)");
            builder.Property(p => p.Address).HasColumnType("nvarchar(500)");
            builder.Property(p => p.City).HasColumnType("nvarchar(50)");
            builder.Property(p => p.Province).HasColumnType("nvarchar(50)");
            builder.Property(p => p.Biography).HasColumnType("nvarchar(500)");
            builder.Property(p => p.Password).HasColumnType("nvarchar(250)");
            builder.Property(p => p.Password).IsRequired();
            builder.Property(p => p.Salt).HasColumnType("nvarchar(250)");
            builder.Property(p => p.RegisterDate).HasColumnType("smalldatetime");
            //builder.Property(p => p.UserIpRegistered).HasColumnType("nvarchar(20)");
            //builder.Property(p => p.Email).HasColumnType("nvarchar(50)");
            builder.Property(p => p.Role).HasColumnType("nvarchar(50)");
            builder.Property(p => p.ActivationCode).HasColumnType("nvarchar(50)");
            builder.Property(p => p.ActivationCodeExpireDate).HasColumnType("smalldatetime");
            builder.Property(p => p.BlockedDate).HasColumnType("smalldatetime");
            builder.Property(p => p.DeletedDate).HasColumnType("smalldatetime");
            #endregion
        }
    }
}
