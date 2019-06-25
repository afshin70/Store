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
        public int Id { get; set; }
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

    }
}
