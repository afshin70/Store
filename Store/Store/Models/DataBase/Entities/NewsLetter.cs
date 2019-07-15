using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// خبرنامه
    /// </summary>
    public class NewsLetter
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ایمیل
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// توکن خبرنامه
        /// </summary>
        public string Token { get; set; }
        /// <summary>---------token,ip
        /// وضعیت تایید
        /// </summary>
        //public bool IsVerified { get; set; }
        ///// <summary>
        ///// کد تایید
        ///// </summary>
        //public string VerifyCode { get; set; }
        ///// <summary>
        ///// تاریخ ارسال کد تایید
        ///// </summary>
        //public DateTime VerifyCodeDate { get; set; }
        ///// <summary>
        ///// تاریخ تایید 
        ///// </summary>
        //public DateTime VerifiedDate { get; set; }
        /// <summary>
        /// وضعیت حذف
        /// </summary>
        public bool IsDeleted { get; set; }
    }
    public class NewsLetterConfig : IEntityTypeConfiguration<NewsLetter>
    {
        public void Configure(EntityTypeBuilder<NewsLetter> builder)
        {
            #region Relations
            builder.HasKey(k => k.Id);
            #endregion

            #region Properties
            builder.Property(p => p.Email).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.Email).IsUnicode();
            builder.Property(p => p.Token).HasColumnType("nvarchar(100)");
            builder.Property(p => p.Token).IsRequired();
            builder.Property(p => p.Token).IsUnicode();
            //builder.Property(p => p.VerifyCodeDate).HasColumnType("smalldatetime");
            //builder.Property(p => p.VerifiedDate).HasColumnType("smalldatetime");
            #endregion
        }
    }
}
