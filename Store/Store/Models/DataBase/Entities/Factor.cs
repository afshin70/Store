using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// فاکتور
    /// </summary>
    public class Factor
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int FactorId { get; set; }
        /// <summary>
        /// مبلغ فاکتور
        /// </summary>
        public decimal SumPrice { get; set; }
        /// <summary>
        /// تاریخ فاکتور
        /// </summary>
        public DateTime FactorDate { get; set; }
        /// <summary>
        /// وضعیت حذف
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// ﺷﻨﺎﺳﻪ ﻣﺮﺟﻊ
        /// </summary>
        public string Authority { get; set; }
        /// <summary>
        /// ﻭﺿﻌﻴﺖ 
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// ﺷﻤﺎﺭﻩ ﺗﺮﺍﻛﻨﺶ ﺧﺮﻳﺪ
        /// </summary>
        public string RefID { get; set; }
        #region ForeignKeys
        /// <summary>
        /// شماره سفارش
        /// </summary>
        public int OrderId { get; set; }
        #endregion

        #region NavigationProps
        public Order Order { get; set; }
        #endregion
    }
    public class FactorConfig : IEntityTypeConfiguration<Factor>
    {
        public void Configure(EntityTypeBuilder<Factor> builder)
        {
            #region Relations
            builder.HasKey(k => k.FactorId);
            #endregion

            #region Properties
            builder.Property(p => p.SumPrice).HasColumnType("decimal(16,3)");
            builder.Property(p => p.SumPrice).IsRequired();
            builder.Property(p => p.FactorDate).HasColumnType("datetime");
            builder.Property(p => p.Authority).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Status).HasColumnType("nvarchar(100)");
            builder.Property(p => p.RefID).HasColumnType("nvarchar(100)");
            #endregion
        }
    }
}
