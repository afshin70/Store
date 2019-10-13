using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Areas.Admin.Models.ViewModels
{
    
    public class BrandAddVM
    {
      
        
        [DisplayName("نام برند")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckExistBrandName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(Name), ErrorMessage = "مقدار فیلد {0}، تکراری است.")]
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        [DisplayName("نام برند(انگلیسی)")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckExistBrandEName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(EName), ErrorMessage = "مقدار فیلد {0}، تکراری است.")]
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        [DisplayName("توضیحات")]
        [MaxLength(1000, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [DataType(DataType.MultilineText)]
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
    }
    public class BrandEditedVM
    {

        public int BrandId { get; set; }
        [DisplayName("نام برند")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckExistOneBrandName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(BrandId), ErrorMessage = "مقدار فیلد {0}، تکراری است.")]
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        [DisplayName("نام برند(انگلیسی)")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckExistOneBrandEName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(BrandId), ErrorMessage = "مقدار فیلد {0}، تکراری است.")]
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        [DisplayName("توضیحات")]
        [MaxLength(1000, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [DataType(DataType.MultilineText)]
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
    }
}
