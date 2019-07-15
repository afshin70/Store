using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// پیام
    /// </summary>
    public class ContactUsMessage
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int MessageId { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ایمیل
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// وضعیت دیده شدن پیام
        /// </summary>
        public bool IsSeen { get; set; }
        /// <summary>
        /// تاریخ ارسال
        /// </summary>
        public DateTime SendedDate { get; set; }
        /// <summary>
        /// وضعیت حذف پیام
        /// </summary>
        public int IsDeleted { get; set; }

    }
    public class ContactUsMessageConfig : IEntityTypeConfiguration<ContactUsMessage>
    {
        public void Configure(EntityTypeBuilder<ContactUsMessage> builder)
        {
            #region Relations
            builder.HasKey(k => k.MessageId);
            #endregion

            #region Properties
            builder.Property(p => p.Title).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.Name).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Email).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Description).HasColumnType("nvarchar(1000)");
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.SendedDate).HasColumnType("smalldatetime");
            #endregion
        }
    }
}
