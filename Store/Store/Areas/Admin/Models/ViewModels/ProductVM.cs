using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Areas.Admin.Models.ViewModels
{
    public class ProductVM
    {

        /// <summary>
        /// آی دی
        /// </summary>
        public int ProductId { get; set; }
        [DisplayName("نام محصول:")]
        [Required(ErrorMessage ="فیلد {0} را وارد نکرده اید.",AllowEmptyStrings =false)]
        [MaxLength(100,ErrorMessage ="حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        [DisplayName("نام انگلیسی:")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(3, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// نام انگلیسی
        /// </summary>
        public string EName { get; set; }
        [DisplayName("توضیحات کوتاه:")]
        [Required(ErrorMessage = "فیلد {0} را وارد نکرده اید.", AllowEmptyStrings = false)]
        [MaxLength(1000, ErrorMessage = "حداکثر طول {0}، {1} کاراکتر میباشد.")]
        [MinLength(5, ErrorMessage = "حداقل طول {0}، {1} کاراکتر میباشد.")]
        /// <summary>
        /// توضیحات کوتاه
        /// </summary>
        public string ShortDescription { get; set; }
        /// <summary>
        /// توضیحات اصلی
        /// </summary>
        public string MainDescription { get; set; }
        /// <summary>
        /// تصاویر
        /// </summary>
        public string Images_Json { get; set; }
        /// <summary>
        /// تگ محصول
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// برند کالا
        /// </summary>
        public int BrandId { get; set; }
        /// <summary>
        /// تعداد فروش
        /// </summary>
        public int SoldCount { get; set; }
        /// <summary>
        /// تعداد بادید
        /// </summary>
        public int VisitedCount { get; set; }
        /// <summary>
        /// تعداد موجود
        /// </summary>
        public int ExistCount { get; set; }
        /// <summary>
        /// بیشترین مبلغی که تخفیف مجاز است
        /// </summary>
        public decimal MaxDiscountPrice { get; set; }
        /// <summary>
        /// ویژگی ها بصورت html
        /// </summary>
        public string Features { get; set; }
        /// <summary>
        /// وضعیت فعال بودن
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        ///  واحد کالا
        /// </summary>
        public string UnitType { get; set; }
        /// <summary>
        /// مبلغ فروش
        /// </summary>
        public decimal SalesPrice { get; set; }
        /// <summary>
        /// مبلغ اصلی
        /// </summary>
        public decimal WrittenPrice { get; set; }
        /// <summary>
        /// محصول ویژه
        /// </summary>
        public bool IsSpecial { get; set; }
        /// <summary>
        /// هشدار کمتر از
        /// </summary>
        public int MinCountNotify { get; set; }
        /// <summary>
        /// تاریخ افزودن محصول
        /// </summary>
        public DateTime InsertedDate { get; set; }
        /// <summary>
        /// وضعیت حذف
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// امتیاز کالا
        /// </summary>
        public int Rating { get; set; }
        #region ForeignKeys
        /// <summary>
        /// آی دی زیر دسته بندی
        /// </summary>
        public int SubCategoryId { get; set; }
        #endregion


    }
}
