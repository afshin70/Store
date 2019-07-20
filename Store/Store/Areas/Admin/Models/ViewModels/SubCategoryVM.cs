using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Areas.Admin.Models.ViewModels
{
    public class SubCategoryVM
    {
        [ScaffoldColumn(false)]
        /// <summary>
        /// آی دی 
        /// </summary>
        public int SubCategoryId { get; set; }
        [DisplayName("نام زیر دسته:")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        [DisplayName("توضیحات زیر دسته:")]
        [MaxLength(1000, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        [DisplayName("نام زیر دسته به انگلیسی:")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        [DisplayName("اولویت نمایش:")]
        /// <summary>
        /// شماره اولویت
        /// </summary>
        public int OrderNumber { get; set; }
        [DisplayName("نمایش در سایت:")]
        /// <summary>
        /// وضعیت فال بودن
        /// </summary>
        public bool IsActive { get; set; }
    }
}
