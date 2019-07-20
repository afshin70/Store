using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Areas.Admin.Models.ViewModels
{
    public class FAQ_VM
    {
        [ScaffoldColumn(false)]
        /// <summary>
        /// آی دی 
        /// </summary>
        public int FAQId { get; set; }
        [DisplayName("پرسش:")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(1000, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// سوال
        /// </summary>
        public string Question { get; set; }
        [DisplayName("پاسخ:")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(1000, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// پاسخ
        /// </summary>
        public string Answer { get; set; }
        [DisplayName("اولویت نمایش:")]
        /// <summary>
        /// اولویت
        /// </summary>
        public int OrderNumber { get; set; }
        [DisplayName("نمایش در سایت:")]
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
    }
}
