using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Shared
{
    public class SharedProperties
    {
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string Family { get; set; }
        /// <summary>
        /// وضعیت احراز هویت کاربر
        /// </summary>
        public bool IsAuthorized { get; set; }
        /// <summary>
        /// توضیحات خبرنامه
        /// </summary>
        public string NewsLetterDescription { get; set; }
        /// <summary>
        /// آدرس اینستاگرام
        /// </summary>
        public string SocialInstagramUrl { get; set; }
        /// <summary>
        /// آدرس یوتوب
        /// </summary>
        public string SocialYoutube { get; set; }
        /// <summary>
        /// آدرس توییتر
        /// </summary>
        public string SocialTwitter { get; set; }
        /// <summary>
        /// آدرس فیس بوک
        /// </summary>
        public string SocialFacebook { get; set; }
        /// <summary>
        /// توضیحات تماس با ما پایین صفحه
        /// </summary>
        public string ContactUsDescription { get; set; }
        /// <summary>
        /// آدرس تماس با ما  پایین صفحه
        /// </summary>
        public string ContactUsAddress { get; set; }
        /// <summary>
        /// ایمیل تماس با ما پایین صفحه
        /// </summary>
        public string ContactUsEmail { get; set; }
        /// <summary>
        /// شماره تماس ،  تماس با ما پایین صفحه
        /// </summary>
        public string ContactUsTel { get; set; }
        /// <summary>
        /// ساعت کاری تماس با ما پایین صفحه
        /// </summary>
        public string ContactUsWorkTime { get; set; }
    }
}

