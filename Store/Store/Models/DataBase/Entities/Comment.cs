using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// کامنت
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int CommentId { get; set; }
        /// <summary>
        /// متن کامنت
        /// </summary>
        public string CommentText { get; set; }
        /// <summary>
        /// نام کاربر
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// ایمیل
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// تاریخ ارسال کامنت
        /// </summary>
        public DateTime CommentedDate { get; set; }
        /// <summary>
        /// وضعیت دیده شده توسط ادمین
        /// </summary>
        public bool IsSeen { get; set; }
        /// <summary>
        /// وضعیت تایید
        /// </summary>
        public bool IsVerified { get; set; }
        /// <summary>
        /// وضعیت نمایش
        /// </summary>
        public bool IsShow { get; set; }

        #region ForeignKeys
        /// <summary>
        /// آی دی مطلب ارسال شده
        /// </summary>
        public int ProductId { get; set; }
        #endregion

        #region NavigationProps
        public Product Product { get; set; }
        #endregion
    }
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            #region Relations
            builder.HasKey(k => k.CommentId);
            #endregion

            #region Properties
            builder.Property(p => p.FullName).HasColumnType("nvarchar(100)");
            builder.Property(p => p.FullName).IsRequired();
            builder.Property(p => p.Email).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.CommentText).HasColumnType("nvarchar(1000)");
            builder.Property(p => p.CommentText).IsRequired();
            builder.Property(p => p.CommentedDate).HasColumnType("smalldatetime");
            builder.Property(p => p.CommentedDate).IsRequired();
            #endregion
        }
    }
}
