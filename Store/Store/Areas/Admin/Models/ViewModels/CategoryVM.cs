using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Areas.Admin.Models.ViewModels
{
    public class CategoryVM
    {
        [ScaffoldColumn(false)]
        public int CategoryId { get; set; }
        [DisplayName("نام دسته:")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        [DisplayName("نام انگلیسی دسته:")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// نام لاتین
        /// </summary>
        public string EName { get; set; }
        [DisplayName("توضیحات:")]
        [MaxLength(1000, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        [DisplayName("شماره جایگاه نمایش:")]
        /// <summary>
        /// شماره اولویت
        /// </summary>
        public int OrderNumber { get; set; }
        [DisplayName("آیا این دسته برای استفاده فعال باشد؟:")]
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
        [DisplayName("جزء دسته های محبوب باشد؟:")]
        /// <summary>
        /// آیا جزو دسته محبو ها است؟
        /// </summary>
        public bool IsFavorate { get; set; }
    }
}
