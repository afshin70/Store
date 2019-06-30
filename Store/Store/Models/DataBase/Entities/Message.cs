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
    public class Message
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int MessageId { get; set; }
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// وضعیت دیده شدن پیام
        /// </summary>
        public bool IsSeen { get; set; }
        
        /// <summary>
        /// تاریخ ارسال
        /// </summary>
        public DateTime SendedDate { get; set; }
        /// <summary>
        /// سطح پیام پاسخ داده شده
        /// </summary>
        public int MessageLevel { get; set; }
        /// <summary>
        /// وضعیت حذف پیام
        /// </summary>
        public int IsDeleted { get; set; }

        #region ForeignKeys
        /// <summary>
        /// کاربر ارسال کننده پیام
        /// </summary>
        public int SenderUserId { get; set; }
        /// <summary>
        /// کاربر دریافت کننده پیام
        /// </summary>
        public int ReciverUserId { get; set; }
        /// <summary>
        /// پاسخ به پیام با آی دی
        /// </summary>
        public int ReplyedId { get; set; }
        #endregion

        #region NavigationProps
        public User User { get; set; }
        #endregion
    }
    public class MessageConfig : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            #region Relations
            builder.HasKey(k => k.MessageId);
            #endregion

            #region Properties
            builder.Property(p => p.Title).HasColumnType("nvarchar(50)");
            builder.Property(p => p.SendedDate).HasColumnType("nvarchar(50)");
            #endregion
        }
    }
}
