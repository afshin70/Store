using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    ///// <summary>
    ///// سبد خرید
    ///// </summary>
    //public class ShopingCart
    //{
    //    /// <summary>
    //    /// آی دی
    //    /// </summary>
    //    public int ShopingCartId { get; set; }
        
    //    /// <summary>
    //    /// محصولات داخل سبد خرید
    //    /// </summary>
    //    public string ShopingCart_Json { get; set; }
    //    /// <summary>
    //    /// اخرین تاریخ تغییر
    //    /// </summary>
    //    public DateTime LastChangedDate { get; set; }
    //    /// <summary>
    //    /// جمع قیمت
    //    /// </summary>
    //    public decimal SumPrice { get; set; }

    //    #region ForeignKeys
    //    /// <summary>
    //    /// آی دی کاربر
    //    /// </summary>
    //    public int UserId { get; set; }
    //    #endregion

    //    #region NavigationProps
    //    //public User User { get; set; }
    //    #endregion
    //}
    //public class ShopingCartConfig : IEntityTypeConfiguration<ShopingCart>
    //{
    //    public void Configure(EntityTypeBuilder<ShopingCart> builder)
    //    {
    //        #region Relations
    //        builder.HasKey(k => k.ShopingCartId);
    //        //builder.HasOne<User>().WithOne(b => b.ShopingCart).HasForeignKey<ShopingCart>(fk => fk.UserId);
    //        #endregion

    //        #region Properties
    //        builder.Property(p => p.LastChangedDate).HasColumnType("smalldatetime");
    //        builder.Property(p => p.SumPrice).HasColumnType("decimal(16,3)");
    //        #endregion
    //    }
    //}
}
