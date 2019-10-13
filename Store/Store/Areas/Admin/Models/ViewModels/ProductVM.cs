using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Models.DataBase.Dto.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Areas.Admin.Models.ViewModels
{
    public class ProductAddVM
    {
        
        /// <summary>
        /// آی دی
        /// </summary>
        public int ProductId { get; set; }
        [DisplayName("نام محصول")]
        [Required(ErrorMessage ="فیلد {0} را وارد نکرده اید.",AllowEmptyStrings =false)]
        [MaxLength(100,ErrorMessage ="حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckExistProductName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(Name), ErrorMessage = "مقدار فیلد {0}، تکراری است.")]
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        [DisplayName("نام انگلیسی")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        [Remote(action: "CheckExistProductEName", controller: "CheckData", areaName: "Admin", AdditionalFields = nameof(EName), ErrorMessage = "مقدار فیلد {0}، تکراری است.")]
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        [DisplayName("توضیحات کوتاه")]
        [MaxLength(1000, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [DataType(DataType.MultilineText)]
        /// <summary>
        /// توضیحات کوتاه
        /// </summary>
        public string ShortDescription { get; set; }
        [DisplayName("توضیحات کامل")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [DataType(DataType.Html)]
        /// <summary>
        /// توضیحات اصلی
        /// </summary>
        public string MainDescription { get; set; }
        /// <summary>
        /// تصاویر
        /// </summary>
        [DisplayName("تصویر اول و شاخص")]
        [Required(ErrorMessage = "{0} را انتخاب نکرده اید.", AllowEmptyStrings = false)]
        public IFormFile Image1 { get; set; }
        public IFormFile Image2 { get; set; }
        public IFormFile Image3 { get; set; }
        public IFormFile Image4 { get; set; }
        /// <summary>
        /// تگ محصول
        /// </summary>
        public string Tags { get; set; }
        [DisplayName("برند")]
        [Required(ErrorMessage = "{0} را انتخاب نکرده اید.", AllowEmptyStrings = false)]
        /// <summary>
        /// برند کالا
        /// </summary>
        public int BrandId { get; set; }
        [DisplayName("موجودی(تعداد)")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [DefaultValue(0)]
        /// <summary>
        /// تعداد موجود
        /// </summary>
        public int ExistCount { get; set; }
        [DisplayName("ویژگی ها")]
        [DataType(DataType.Html)]
        /// <summary>
        /// ویژگی ها بصورت html
        /// </summary>
        public string Features { get; set; }
        [DisplayName("انتشار")]
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
        [DisplayName("واحد کالا")]
        [MaxLength(50, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [DefaultValue("عدد")]
        /// <summary>
        ///  واحد کالا
        /// </summary>
        public string UnitType { get; set; }
        [DisplayName("مبلغ فروش(تومان)")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [DefaultValue(0)]
        /// <summary>
        /// مبلغ فروش
        /// </summary>
        public int SalesPrice { get; set; }
        [DisplayName("مبلغ فروش با تخفیف (تومان)")]
        /// <summary>
        /// مبلغ اصلی
        /// </summary>
        public int? WrittenPrice { get; set; }
        [DisplayName("محصول ویژه")]
        /// <summary>
        /// محصول ویژه
        /// </summary>
        public bool IsSpecial { get; set; }
        [DisplayName("دسته")]
        [Required(ErrorMessage = " {0} را انتخاب نکرده اید.", AllowEmptyStrings = false)]
        /// <summary>
        /// آی دی زیر دسته بندی
        /// </summary>
        public int SubCategoryId { get; set; }
        [DisplayName("دسته فرعی")]
        [Required(ErrorMessage = " {0} را انتخاب نکرده اید.", AllowEmptyStrings = false)]
        /// <summary>
        /// آی دی
        /// </summary>
        public int CategoryId { get; set; }
        [DisplayName("دسته اصلی")]
        [Required(ErrorMessage = " {0} را انتخاب نکرده اید.", AllowEmptyStrings = false)]
        /// <summary>
        /// آی دی
        /// </summary>
        public int MainCategoryId { get; set; }
    }


}
