using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Areas.Admin.Models.ViewModels
{
    public class SubCategoryAddVM
    {
        [DisplayName("دسته فرعی")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        /// <summary>
        /// آی دی دسته بندی
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// آی دی 
        /// </summary>
        public int SubCategoryId { get; set; }
        [DisplayName("نام زیر دسته")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckExistSubCategoryName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(Name), ErrorMessage = "مقدار فیلد {0}، تکراری است.")]
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        [DisplayName("نام زیر دسته به انگلیسی")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckExistSubCategoryEName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(EName), ErrorMessage = "مقدار فیلد {0}، تکراری است.")]
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        [DisplayName("شماره اولویت")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        /// <summary>
        /// شماره اولویت
        /// </summary>
        public int OrderNumber { get; set; }
        [DisplayName("نمایش در سایت")]
        /// <summary>
        /// وضعیت فال بودن
        /// </summary>
        public bool IsActive { get; set; }
        [DisplayName("توضیحات زیر دسته")]
        [MaxLength(1000, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        [DisplayName("دسته اصلی")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        public int MainCategoryId { get; set; }
    }

    public class SubCategoryEditedVM
    {
        [DisplayName("دسته فرعی")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        /// <summary>
        /// آی دی دسته بندی
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// آی دی 
        /// </summary>
        public int SubCategoryId { get; set; }
        [DisplayName("نام زیر دسته")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckExistOneSubCategoryName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(SubCategoryId), ErrorMessage = "مقدار فیلد {0}، تکراری است.")]
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        [DisplayName("نام زیر دسته به انگلیسی")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckExistOneSubCategoryEName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(SubCategoryId), ErrorMessage = "مقدار فیلد {0}، تکراری است.")]
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        [DisplayName("شماره اولویت")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        /// <summary>
        /// شماره اولویت
        /// </summary>
        public int OrderNumber { get; set; }
        [DisplayName("نمایش در سایت")]
        /// <summary>
        /// وضعیت فال بودن
        /// </summary>
        public bool IsActive { get; set; }
        [DisplayName("توضیحات زیر دسته")]
        [MaxLength(1000, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        [DisplayName("دسته اصلی")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        public int MainCategoryId { get; set; }
    }
}
