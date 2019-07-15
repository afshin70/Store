using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    public class Setting
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int SettingId { get; set; }
        /// <summary>
        /// تماس با ما
        /// </summary>
        public string ContactUs_Json { get; set; }
        /// <summary>
        /// بخش اطلاعات پایین صفحه
        /// </summary>
        public string Information_Json { get; set; }
        /// <summary>
        /// بخش لینک های حساب کاربری
        /// </summary>
        public string UserAccountLink_json { get; set; }
        /// <summary>
        /// آدرس شبکه های اجتماعی
        /// </summary>
        public string SotialNetwork_Json { get; set; }
        /// <summary>
        /// صفحه درباره ما
        /// </summary>
        public string AboutUsPage { get; set; }
        /// <summary>
        /// صفحه درباره ما
        /// </summary>
        public string ContactUsPage { get; set; }
        /// <summary>
        /// آدرس نقشه صفحه درباره ما
        /// </summary>
        public string ContactUsMapUrl { get; set; }
        /// <summary>
        /// صفحه قوانین و مقررات
        /// </summary>
        public string Terms_ConditionsPage { get; set; }
        /// <summary>
        /// صفحه سوالات متداول
        /// </summary>
        public string FAQPage { get; set; }
        public string BanerImageName { get; set; }
        public string BanerImageNameMob { get; set; }
    }
    public class SettingConfig : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            #region Relations
            builder.HasKey(k => k.SettingId);
            #endregion

            #region Properties
            //builder.Property(p => p.Email).HasColumnType("nvarchar(50)");
            //builder.Property(p => p.VerifyCode).HasColumnType("nvarchar(50)");
            //builder.Property(p => p.VerifyCodeDate).HasColumnType("smalldatetime");
            //builder.Property(p => p.VerifiedDate).HasColumnType("smalldatetime");
            #endregion
        }
    }
}
