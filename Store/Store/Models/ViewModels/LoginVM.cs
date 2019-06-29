using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.ViewModels
{
    public class LoginVM
    {
        [Display(Name ="آدرس ایمیل")]
        [EmailAddress(ErrorMessage ="فرمت ایمیل نادرست می باشد.")]
        [Required(ErrorMessage ="فیلد {0} نباید خالی باشد.")]
        [MinLength(10,ErrorMessage ="طول فیلد {0} باید بیشتر از {1} کاراکتر باشد.")]
        [MaxLength(100,ErrorMessage ="طول فیلد {0} باید کمتر از {1} کاراکتر باشد.")]
        public string  Email { get; set; }
        [Display(Name = "رمز")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد.")]
        [MinLength(8, ErrorMessage = "طول فیلد {0} باید بیشتر از {1} کاراکتر باشد.")]
        [MaxLength(100, ErrorMessage = "طول فیلد {0} باید کمتر از {1} کاراکتر باشد.")]
        public string  Password { get; set; }
        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }
    }
}
