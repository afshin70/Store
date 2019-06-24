using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Entities
{
    /// <summary>
    /// سفارش
    /// </summary>
    public class Order
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// آی دی کاربر
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// آی دی کد تخفیف
        /// </summary>
        public int DiscountId { get; set; }
        /// <summary>
        /// وضعیت پرداخت مالی
        /// </summary>
        public bool FinanceIsOk { get; set; }
        /// <summary>
        /// موبایل
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// شماره تلفن ثابت
        /// </summary>
        public string Telphone { get; set; }
        /// <summary>
        /// مبلغ پرداخت شده
        /// </summary>
        public decimal PayCost { get; set; }
        /// <summary>
        /// آیا خرید کامل بوده است
        /// </summary>
        public bool BuyIsOk { get; set; }
        /// <summary>
        /// تاریخ خرید
        /// </summary>
        public DateTime BuyTime { get; set; }
        /// <summary>
        /// وضعیت خرید
        /// </summary>
        public int BuyStatus { get; set; }
        /// <summary>
        /// جمع کل هزینه ها
        /// </summary>
        public decimal SumPrice { get; set; }
        /// <summary>
        /// جمع کل بدون تخفیف
        /// </summary>
        public decimal SumPriceNoDiscount { get; set; }
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
    }
}
