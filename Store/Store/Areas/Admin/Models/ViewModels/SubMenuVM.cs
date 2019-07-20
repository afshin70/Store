using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Areas.Admin.Models.ViewModels
{
    public class SubMenuVM
    {
        [ScaffoldColumn(false)]
        /// <summary>
        /// آی دی زیر منو
        /// </summary>
        public int SubMenuId { get; set; }
        [DisplayName("نام زیر منو:")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        [DisplayName("لینک:")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// آدرس
        /// </summary>
        public string Url { get; set; }
        [DisplayName("نمایش در سایت:")]
        /// <summary>
        /// آیا فعال است
        /// </summary>
        public bool IsActive { get; set; }
    }
}
