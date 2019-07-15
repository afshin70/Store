using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// سوالات متداول
    /// </summary>
    public class FAQ
    {
        /// <summary>
        /// آی دی 
        /// </summary>
        public int FAQId { get; set; }
        /// <summary>
        /// سوال
        /// </summary>
        public string Question { get; set; }
        /// <summary>
        /// پاسخ
        /// </summary>
        public string Answer { get; set; }
        /// <summary>
        /// اولویت
        /// </summary>
        public int OrderNumber { get; set; }
    }
    public class FAQConfig : IEntityTypeConfiguration<FAQ>
    {
        public void Configure(EntityTypeBuilder<FAQ> builder)
        {
            #region Relations
            builder.HasKey(k => k.FAQId);
            #endregion

            #region Properties
            builder.Property(p => p.Question).IsRequired();
            builder.Property(p => p.Answer).IsRequired();
            #endregion
        }
    }
}
