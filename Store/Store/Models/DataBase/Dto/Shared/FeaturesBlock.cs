using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Shared
{
    /// <summary>
    /// بلاک ویژگی ها
    /// </summary>
    public class FeaturesBlock
    {
        /// <summary>
        /// وضعیت دیدن ویژگی ها
        /// </summary>
        public bool IsVisibleFeatures { get; set; }
        /// <summary>
        /// عنوان ویژگی ارسال
        /// </summary>
        public string FeaturesSendTitle { get; set; }
        /// <summary>
        /// توضیحات ویژگی ارسال
        /// </summary>
        public string FeaturesSendDescription { get; set; }
        /// <summary>
        /// عنوان ویژگی ‍‍پشتیبانی
        /// </summary>
        public string FeaturesSupportTitle { get; set; }
        /// <summary>
        /// توضیحات ویژگی پشتیبانی
        /// </summary>
        public string FeaturesSupportDescription { get; set; }
        /// <summary>
        /// عنوان ویژگی پرداخت
        /// </summary>
        public string FeaturesPaymentTitle { get; set; }
        /// <summary>
        /// توضیحات ویژگی پرداخت
        /// </summary>
        public string FeaturesPaymentDescription { get; set; }
        /// <summary>
        /// عنوان ویژگی پیشنهاد ها
        /// </summary>
        public string FeaturesOfferTitle { get; set; }
        /// <summary>
        /// توضیحات ویژگی پیشنهاد ها
        /// </summary>
        public string FeaturesOfferDescription { get; set; }
    }
}
