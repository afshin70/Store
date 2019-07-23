using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Admin
{
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
        /// <summary>
        /// وضعیت حذف
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
