using Store.Models.DataBase.Dto.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Store.Models.IService
{
    public   interface IEmailService
    {
        /// <summary>
        /// دریافت تنظیمات smtp از فیال جیسان
        /// </summary>
        /// <returns></returns>
        SmtpClient GetSmtpClient();
        /// <summary>
        /// ارسال ایمیل
        /// </summary>
        /// <param name="message">پیام</param>
        /// <param name="smtp">تنظیمات smtp</param>
        /// <returns></returns>
        bool SendEmail(MailMessage message, SmtpClient smtp);
    }
}
