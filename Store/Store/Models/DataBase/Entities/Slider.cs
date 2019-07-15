using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// اسلایدر
    /// </summary>
    public class Slider
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int SliderId { get; set; }
        /// <summary>
        /// تصویر
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// نسخه موبایل
        /// </summary>
        public string ImageNameMob { get; set; }
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// متن لینک
        /// </summary>
        public string UrlText { get; set; }
        /// <summary>
        /// آدرس لینک
        /// </summary>
        public string UrlLink { get; set; }
        /// <summary>
        /// وضعیت نمایش در صفحه اصلی
        /// </summary>
        public bool IsShowInMainPage { get; set; }
    }
    public class SliderConfig : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            #region Relations
            builder.HasKey(k => k.SliderId);
            #endregion

            #region Properties
            builder.Property(p => p.ImageUrl).HasColumnType("nvarchar(300)");
            builder.Property(p => p.ImageUrl).IsRequired();
            builder.Property(p => p.Title).HasColumnType("nvarchar(300)");
            builder.Property(p => p.Description).HasColumnType("nvarchar(1000)");
            builder.Property(p => p.UrlLink).HasColumnType("nvarchar(300)");
            builder.Property(p => p.UrlText).HasColumnType("nvarchar(300)");
            //builder.Property(p => p.SendedDate).HasColumnType("smalldatetime");
            #endregion
        }
    }
}
