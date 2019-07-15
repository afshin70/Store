using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    ///// <summary>
    ///// استان
    ///// </summary>
    //public class Province
    //{
    //    /// <summary>
    //    /// آی دی
    //    /// </summary>
    //    public int ProvinceId { get; set; }
    //    /// <summary>
    //    /// نام استان
    //    /// </summary>
    //    public string Name { get; set; }

    //    #region NavigationProps
    //    //public ICollection<City> Cities { get; set; }
    //    #endregion
    //}
    //public class ProvinceConfig : IEntityTypeConfiguration<Province>
    //{
    //    public void Configure(EntityTypeBuilder<Province> builder)
    //    {
    //        #region Relations
    //        builder.HasKey(k => k.ProvinceId);
    //        builder.HasMany<City>().WithOne(p => p.Province).HasForeignKey(fk => fk.ProvinceId);
    //        #endregion

    //        #region Properties
    //        builder.Property(p => p.Name).HasColumnType("nvarchar(50)");
    //        #endregion
    //    }
    //}
}
