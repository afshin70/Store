using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using Store.Models.DataBase.Dto.Email;
using Store.Models.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Store.Models.Services
{
    public class EmailService : IEmailService
    {
        IHostingEnvironment env;
        public EmailService(IHostingEnvironment _env)
        {
            env = _env;
        }
        public SmtpClient GetSmtpClient()
        {
            EmailConfig config = JsonConvert.DeserializeObject<EmailConfig>(env.ContentRootPath + @"\EmailConfog.json");
            SmtpClient smtp = new SmtpClient
            {
                Port = config.Port,
                EnableSsl = config.EnableSsl,
                Credentials = new NetworkCredential(userName: config.EmailAdress, password: config.Password)
            };

            return smtp;
        }

        public bool SendEmail(MailMessage message, SmtpClient smtp)
        {
            try
            {
                smtp.Send(message);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
