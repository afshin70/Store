using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// شهر
    /// </summary>
    public class City
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int CityId { get; set; }
        
        /// <summary>
        /// نام شهر
        /// </summary>
        public string Name { get; set; }

        #region ForeignKeys
        /// <summary>
        /// آی دی استان
        /// </summary>
        public int ProvinceId { get; set; }
        #endregion

        #region NavigationProps
        public Province Province { get; set; }
        //public ICollection<User> Users { get; set; }
        #endregion
    }
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            #region Relations
            builder.HasKey(k => k.CityId);
            builder.HasMany<User>().WithOne(p => p.City).HasForeignKey(fk => fk.CityId);
            #endregion
            
            #region Properties
            builder.Property(p => p.Name).HasColumnType("nvarchar(50)");
            #endregion
        }
    }
}
