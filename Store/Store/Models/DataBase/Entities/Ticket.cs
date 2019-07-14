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
    public class Ticket
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int TicketId { get; set; }
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
        /// <summary>
        /// تاریخ ارسال تیکت
        /// </summary>
        public DateTime TicketDate { get; set; }
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
    public class TicketConfig : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            #region Relations
            //builder.HasKey(k => k.);
            #endregion

            #region Properties
            builder.Property(p => p.Title).HasColumnType("nvarchar(50)");
            builder.Property(p => p.SendedDate).HasColumnType("smalldatetime");
            #endregion
        }
    }
}
