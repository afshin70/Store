using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "آدرس ایمیل")]
        [EmailAddress(ErrorMessage = "فرمت ایمیل نادرست می باشد.")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد.")]
        [MinLength(10, ErrorMessage = "حداقل طول فیلد {0} باید بیشتر از {1} کاراکتر باشد.")]
        [MaxLength(100, ErrorMessage = "حداکثر طول فیلد {0} باید کمتر از {1} کاراکتر باشد.")]
        public string RegisterEmail { get; set; }
        [Display(Name = "رمز")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد.")]
        [MinLength(8, ErrorMessage = "حداقل طول فیلد {0} باید بیشتر از {1} کاراکتر باشد.")]
        [MaxLength(100, ErrorMessage = "حداکثر طول فیلد {0} باید کمتر از {1} کاراکتر باشد.")]
        public string RegisterPassword { get; set; }
        [Display(Name = "تایید رمز")]
        [Required(ErrorMessage = "فیلد {0} نباید خالی باشد.")]
        [MinLength(8, ErrorMessage = "حداقل طول فیلد {0} باید بیشتر از {1} کاراکتر باشد.")]
        [MaxLength(100, ErrorMessage = "حداکثر طول فیلد {0} باید کمتر از {1} کاراکتر باشد.")]
        [Compare("RegisterPassword", ErrorMessage ="گذرواژه شما جهت تایید نادرست است.")]
        public string ConfirmPassword { get; set; }
    }
}
