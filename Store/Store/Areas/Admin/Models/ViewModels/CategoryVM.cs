using Microsoft.AspNetCore.Mvc;
using Store.Models.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Areas.Admin.Models.ViewModels
{
    public class CategoryAddVM
    {
        [DisplayName("دسته اصلی")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        /// <summary>
        /// آی دی دسته بندی اصلی
        /// </summary>
        public int MainCategoryId { get; set; }
        public int CategoryId { get; set; }
        [DisplayName("نام دسته")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckExistCategoryName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(Name), ErrorMessage = "مقدار فیلد {0}، تکراری است.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        [DisplayName("نام انگلیسی دسته")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckExistCategoryEName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(EName), ErrorMessage = "مقدار فیلد {0}، تکراری است.")]
        /// <summary>
        /// نام لاتین
        /// </summary>
        public string EName { get; set; }
        [DisplayName("توضیحات")]
        [MaxLength(1000, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        [DisplayName("شماره اولویت")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        /// <summary>
        /// شماره اولویت
        /// </summary>
        public int OrderNumber { get; set; }
        [DisplayName("نمایش در سایت")]
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
        [DisplayName("جزء دسته های محبوب باشد")]
        /// <summary>
        /// آیا جزو دسته محبو ها است؟
        /// </summary>
        public bool IsFavorate { get; set; }
    }

    public class CategoryEditedVM
    {
      
        public int CategoryId { get; set; }
        [DisplayName("نام دسته")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckExistOneCategoryName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(CategoryId), ErrorMessage = "مقدار فیلد {0}، تکراری است.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        [DisplayName("نام انگلیسی دسته")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckExistOneCategoryEName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(CategoryId), ErrorMessage = "مقدار فیلد {0}، تکراری است.")]
        /// <summary>
        /// نام لاتین
        /// </summary>
        public string EName { get; set; }
        [DisplayName("توضیحات")]
        [MaxLength(1000, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        [DisplayName("شماره اولویت")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        /// <summary>
        /// شماره اولویت
        /// </summary>
        public int OrderNumber { get; set; }
        [DisplayName("نمایش در سایت")]
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
        [DisplayName("جزء دسته های محبوب باشد")]
        /// <summary>
        /// آیا جزو دسته محبو ها است؟
        /// </summary>
        public bool IsFavorate { get; set; }
        [DisplayName("دسته اصلی")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        /// <summary>
        /// آی دی دسته بندی اصلی
        /// </summary>
        public int MainCategoryId { get; set; }
    }
}
