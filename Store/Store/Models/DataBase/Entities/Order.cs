using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// سفارش
    /// </summary>
    public class Order
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// وضعیت پرداخت مالی
        /// </summary>
        public bool FinanceIsOk { get; set; }
        /// <summary>
        /// موبایل
        /// </summary>
        //public string Mobile { get; set; }
        ///// <summary>
        ///// شماره تلفن ثابت
        ///// </summary>
        //public string Telphone { get; set; }
        /// <summary>
        /// مبلغ پرداخت شده
        /// </summary>
        //public decimal PayCost { get; set; }
        /// <summary>
        /// آیا خرید کامل بوده است
        /// </summary>
        //public bool BuyIsOk { get; set; }
        /// <summary>
        /// تاریخ خرید
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// وضعیت خرید
        /// </summary>
        public int OrderStatus { get; set; }
        /// <summary>
        /// جمع کل هزینه ها
        /// </summary>
        public decimal OrderPrice { get; set; }
        /// <summary>
        /// جمع کل بدون تخفیف
        /// </summary>
        public decimal OrderPriceNoDiscount { get; set; }
        /// <summary>
        /// کد رهگیری
        /// </summary>
        public string TrackingCode { get; set; }
        /// <summary>
        /// سبد خرید
        /// </summary>
        public string ShopingCartDetails_Json { get; set; }
        /// <summary>
        /// جزئیات آدرس خرید
        /// </summary>
        public string AddressDetailes_Json { get; set; }
        /// <summary>
        /// آیا خرید کنسل شده است
        /// </summary>
        public bool IsCanceled { get; set; }
        /// <summary>
        /// آیا خرید تکمیل و پایان یافته است
        /// </summary>
        public bool IsFinished { get; set; }
        /// <summary>
        /// وضعیت حذف
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// کد بازگشتی از درگاه
        /// </summary>
        public string PaymentCode { get; set; }
        /// <summary>
        /// آی دی کد تخفیف
        /// </summary>
        public string DiscountName { get; set; }
        /// <summary>
        /// مبلغ تخفیف داده شده
        /// </summary>
        public decimal DiscountPrice { get; set; }

        #region ForeignKeys
        /// <summary>
        /// آی دی کاربر
        /// </summary>
        public int UserId { get; set; }
        
        #endregion

        #region NavigationProps
        public User User { get; set; }
        //public Discount Discount { get; set; }
        //public ICollection<Factor> Factors { get; set; }
        #endregion
    }
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            #region Relations
            builder.HasKey(k => k.OrderId);
            builder.HasMany<Factor>().WithOne(p => p.Order).HasForeignKey(fk => fk.OrderId);
            #endregion

            #region Properties
            builder.Property(p => p.OrderDate).HasColumnType("datetime");
            builder.Property(p => p.OrderPrice).HasColumnType("decimal(16,3)");
            builder.Property(p => p.OrderPriceNoDiscount).HasColumnType("decimal(16,3)");
            builder.Property(p => p.TrackingCode).HasColumnType("nvarchar(50)");
            builder.Property(p => p.TrackingCode).IsUnicode();
            builder.Property(p => p.DiscountName).HasColumnType("nvarchar(50)");
            builder.Property(p => p.DiscountPrice).HasColumnType("decimal(16,3)");

            #endregion
        }
    }
}
