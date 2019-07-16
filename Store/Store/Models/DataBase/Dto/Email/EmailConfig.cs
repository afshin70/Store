using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Email
{
    public class EmailConfig
    {
        public int Port { get; set; }
        public bool EnableSsl { get; set; }
        public string Password { get; set; }
        public string EmailAdress { get; set; }
       
    }
}
