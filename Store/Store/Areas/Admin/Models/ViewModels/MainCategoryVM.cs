using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Areas.Admin.Models.ViewModels
{
    public class MainCategoryVM
    {
        [ScaffoldColumn(false)]
        /// <summary>
        /// آی دی
        /// </summary>
        public int MainCategoryId { get; set; }
        [DisplayName("نام گروه اصلی")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckMainCategoryName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(Name), ErrorMessage = "مقدار فیلد {0} تکراری است.")]
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        [DisplayName("نام انگلیسی گروه اصلی")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action:"CheckMainCategoryEname",controller:"CheckData",areaName:"Admin",AdditionalFields =nameof(EName),ErrorMessage ="مقدار فیلد {0} تکراری است.")]
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        [DisplayName("اولویت نمایش")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [DefaultValue(0)] 
        /// <summary>
        /// شماره اولویت بندی
        /// </summary>
        public int OrderNumber { get; set; }
        [DisplayName("نمایش در سایت")]
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
    }
}
