using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Areas.Admin.Models.ViewModels
{
    public class MenuVM
    {
        [ScaffoldColumn(false)]
        /// <summary>
        /// منو آی دی
        /// </summary>
        public int MenuId { get; set; }
        [DisplayName("نام منو:")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        [DisplayName("لینک منو:")]
        [MaxLength(300, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// لینک
        /// </summary>
        public string Url { get; set; }
        [DisplayName("نمایش در سایت:")]
        /// <summary>
        /// وضعیت فعال
        /// </summary>
        public bool IsActive { get; set; }
    }
}
