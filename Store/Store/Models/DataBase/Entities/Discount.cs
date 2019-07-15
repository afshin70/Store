﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// تخفیف
    /// </summary>
    public class Discount
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int DiscountId { get; set; }
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
        /// بیشترین مبلغ تخفیف
        /// </summary>
        public decimal DiscountPrice { get; set; }
        /// <summary>
        /// حداقل مبلغ خریداری برای اعمال کد تخفیف
        /// </summary>
        public decimal MinPriceToDiscount { get; set; }
        /// <summary>
        /// شروع تاریخ
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// پایان تاریخ
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }

        #region NavigationProps
        //public ICollection<Order> Orders { get; set; }
        #endregion
    }
    public class DiscountConfig : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            #region Relations
            builder.HasKey(k => k.DiscountId);
            //builder.HasMany<Order>().WithOne(p => p.Discount).HasForeignKey(fk => fk.DiscountId);
            #endregion

            #region Properties
            builder.Property(p => p.Name).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.EName).HasColumnType("nvarchar(100)");
            builder.Property(p => p.EName).IsRequired();
            builder.Property(p => p.EName).IsUnicode();
            builder.Property(p => p.Description).HasColumnType("nvarchar(1000)");
            builder.Property(p => p.DiscountPrice).HasColumnType("decimal(16,3)");
            builder.Property(p => p.MinPriceToDiscount).HasColumnType("decimal(16,3)");
            builder.Property(p => p.StartDate).HasColumnType("smalldatetime");
            builder.Property(p => p.EndDate).HasColumnType("smalldatetime");
            #endregion
        }
    }
}
