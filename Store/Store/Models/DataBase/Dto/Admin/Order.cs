using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Dto.Admin
{
    public class Order
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// وضعیت پرداخت مالی
        /// </summary>
        public bool FinanceIsOk { get; set; }
        /// <summary>
        /// تاریخ خرید
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// وضعیت خرید
        /// </summary>
        public int OrderStatus { get; set; }
        /// <summary>
        /// جمع کل هزینه ها
        /// </summary>
        public decimal OrderPrice { get; set; }
        /// <summary>
        /// جمع کل بدون تخفیف
        /// </summary>
        public decimal OrderPriceNoDiscount { get; set; }
        /// <summary>
        /// کد رهگیری
        /// </summary>
        public string TrackingCode { get; set; }
        /// <summary>
        /// سبد خرید
        /// </summary>
        public string ShopingCartDetails_Json { get; set; }
        /// <summary>
        /// جزئیات آدرس خرید
        /// </summary>
        public string AddressDetailes_Json { get; set; }
        /// <summary>
        /// آیا خرید کنسل شده است
        /// </summary>
        public bool IsCanceled { get; set; }
        /// <summary>
        /// آیا خرید تکمیل و پایان یافته است
        /// </summary>
        public bool IsFinished { get; set; }
        /// <summary>
        /// وضعیت حذف
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// کد بازگشتی از درگاه
        /// </summary>
        public string PaymentCode { get; set; }
        /// <summary>
        /// آی دی کد تخفیف
        /// </summary>
        public string DiscountName { get; set; }
        /// <summary>
        /// مبلغ تخفیف داده شده
        /// </summary>
        public decimal DiscountPrice { get; set; }
    }
}
