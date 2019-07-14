using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Store.Models.Utility
{
    public class BaseUtility
    {
        /// <summary>
        /// ارسال ایمیل    
        /// </summary>
        /// <param name="mail_address">آدرس ایمیل</param>
        /// <param name="subject">عنوان ایمیل</param>
        /// <param name="body">محتوای ایمیل</param>
        /// <param name="is_body_html">آیا محتوای ایمیل اچ تی ام ال است؟</param>
        /// <returns></returns>
        public bool SendMail(string mail_address, string subject, string body,bool is_body_html)
        {
            try
            {
                MailMessage mail = new MailMessage();

                //پارامتر این شی همان حالت معرفی شده در تنظیمات ایمیل سرور می‌باشد که پیشتر معرفی شد.
                SmtpClient SmtpServer = new SmtpClient(StoreAssembly.StoreEmailHost);
                mail.From = new MailAddress(StoreAssembly.StoreEmailAddress);
                mail.To.Add(mail_address);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = is_body_html;

                SmtpServer.Port = StoreAssembly.StoreEmailPort;
                SmtpServer.Credentials = new System.Net.NetworkCredential(StoreAssembly.StoreEmailAddress, StoreAssembly.StoreEmailPassword);
                SmtpServer.EnableSsl = false;
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
