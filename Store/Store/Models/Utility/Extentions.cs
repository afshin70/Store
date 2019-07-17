using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public static class Extentions
    {
        public static bool IsImageValid(this IFormFile formFile)
        {
            try
            {
                Image image = Image.FromStream(formFile.OpenReadStream());
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private static string[] yakan = new string[10] { "صفر", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه" };
        private static string[] dahgan = new string[10] { "", "", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود" };
        private static string[] dahyek = new string[10] { "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هجده", "نوزده" };
        private static string[] sadgan = new string[10] { "", "یکصد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد" };
        private static string[] basex = new string[5] { "", "هزار", "میلیون", "میلیارد", "تریلیون" };
        private static string getnum3(int num3)
        {
            string s = "";
            int d3, d12;
            d12 = num3 % 100;
            d3 = num3 / 100;
            if (d3 != 0)
                s = sadgan[d3] + " و ";
            if ((d12 >= 10) && (d12 <= 19))
            {
                s = s + dahyek[d12 - 10];
            }
            else
            {
                int d2 = d12 / 10;
                if (d2 != 0)
                    s = s + dahgan[d2] + " و ";
                int d1 = d12 % 10;
                if (d1 != 0)
                    s = s + yakan[d1] + " و ";
                s = s.Substring(0, s.Length - 3);
            };
            return s;
        }
        /// <summary>
        /// تبدیل عدد به حروف فارسی
        /// </summary>
        /// <param name="input">ورودی عدد</param>
        /// <returns></returns>
        public static string ToPersianCharacterString(this int input)
        {
            string snum = input.ToString();
            string stotal = "";
            if (snum == "") return "صفر";
            if (snum == "0")
            {
                return yakan[0];
            }
            else
            {
                snum = snum.PadLeft(((snum.Length - 1) / 3 + 1) * 3, '0');
                int L = snum.Length / 3 - 1;
                for (int i = 0; i <= L; i++)
                {
                    int b = int.Parse(snum.Substring(i * 3, 3));
                    if (b != 0)
                        stotal = stotal + getnum3(b) + " " + basex[L - i] + " و ";
                }
                stotal = stotal.Substring(0, stotal.Length - 3);
            }
            return stotal;
        }
        /// <summary>
        ///تبدیل میلادی به شمسی 
        /// </summary>
        /// <param name="input">تاریخ میلادی</param>
        /// <returns>مثال : 1398/1/1</returns>
        public static string ToShamsiString(this DateTime input)
        {
            PersianCalendar _PersianCalendar = new PersianCalendar();
            return $"{_PersianCalendar.GetYear(input)}/{_PersianCalendar.GetMonth(input)}/{_PersianCalendar.GetDayOfMonth(input)}";
        }
        /// <summary>
        /// تبدیل به ساعت رشته
        /// </summary>
        /// <param name="input">Date Time</param>
        /// <returns>مثال : 8:0</returns>
        public static string ToTimeString(this DateTime input)
        {
            PersianCalendar _PersianCalendar = new PersianCalendar();
            return $"{input.Minute} : {input.Hour}";
        }
        /// <summary>
        /// شمسی به میلادی 
        /// </summary>
        /// <param name="input">تاریخ شمسی</param>
        /// <returns>7/16/2019</returns>
        public static DateTime ToMiladiDateTime(this DateTime input)
        {
            PersianCalendar p = new PersianCalendar();
            return p.ToDateTime(input.Year, input.Month, input.Day, input.Hour, input.Minute, 0, 0);
        }
        /// <summary>
        /// تاریخ میلادی به تاریخ و زمان به زبان فارسی
        /// </summary>
        /// <param name="input">تاریخ میلادی</param>
        /// <returns>مثال 1395-11-9 11:20:34</returns>
        public static string ToPersianDateTimeString(this DateTime input)
        {
            PersianCalendar p = new PersianCalendar();
            int Year = p.GetYear(input);
            int Month = p.GetMonth(input);
            int Day = p.GetDayOfMonth(input);
            int Hour = p.GetHour(input);
            int Minute = p.GetMinute(input);
            int Second = p.GetSecond(input);
            double Milliseconds = p.GetMilliseconds(input);
            return $"{Year}-{Month}-{Day} {Hour}:{Minute}:{Second}.{Milliseconds}";
        }
        /// <summary>
        /// تبدیل دسیمال به واحد نمایشی پول
        /// </summary>
        /// <param name="input">decimal</param>
        /// <returns>example : 25,000</returns>
        public static string ToPriceStringFormat(this decimal input)
        {
            int _Price = Decimal.ToInt32((Decimal)input);
            if (_Price > 0)
                return _Price.ToString("0,#");
            else
                return "0";
        }
        /// <summary>
        /// دریافت  نام ماه شمسی با گرفتن تاریخ میلادی
        /// </summary>
        /// <param name="input"></param>
        /// <returns>مثال : اردیبهشت</returns>
        public static string ToShamsiMonthNameString(this DateTime input)
        {
            try
            {
                PersianCalendar p = new PersianCalendar();
                int Year = p.GetYear(input);
                int Month = p.GetMonth(input);
                int Day = p.GetDayOfMonth(input);
                int Hour = p.GetHour(input);
                int Minute = p.GetMinute(input);
                int Second = p.GetSecond(input);
                double Milliseconds = p.GetMilliseconds(input);
                string MonthName = "";
                switch (Month)
                {
                    case 1:
                        MonthName = "فروردین";
                        break;

                    case 2:
                        MonthName = "اردیبهشت";
                        break;

                    case 3:
                        MonthName = "خرداد";
                        break;

                    case 4:
                        MonthName = "تیر";
                        break;

                    case 5:
                        MonthName = "مرداد";
                        break;

                    case 6:
                        MonthName = "شهریور";
                        break;

                    case 7:
                        MonthName = "مهر";
                        break;

                    case 8:
                        MonthName = "آبان";
                        break;

                    case 9:
                        MonthName = "آذر";
                        break;

                    case 10:
                        MonthName = "دی";
                        break;

                    case 11:
                        MonthName = "بهمن";
                        break;

                    case 12:
                        MonthName = "اسفند";
                        break;

                    default:
                        break;
                }

                return $"{Year}-{MonthName}-{Day} {Hour}:{Minute}:{Second}.{Milliseconds}";
            }
            catch (Exception)
            {
                return "";
            }
        }
        /// <summary>
        /// نام روز هفته در تاریخ شمسی 
        /// </summary>
        /// <param name="input">تاریخ میلادی</param>
        /// <returns>مثال : شنبه</returns>
        public static string sm_ToShamsiDayName(this DateTime input)
        {
            PersianCalendar p = new PersianCalendar();
            int Year = p.GetYear(input);
            int Month = p.GetMonth(input);
            int Day = p.GetDayOfMonth(input);
            int Hour = p.GetHour(input);
            int Minute = p.GetMinute(input);
            int Second = p.GetSecond(input);
            double Milliseconds = p.GetMilliseconds(input);
            string DayName = "";
            switch (input.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    DayName = "یکشنبه";
                    break;
                case DayOfWeek.Monday:
                    DayName = "دوشنبه";
                    break;
                case DayOfWeek.Tuesday:
                    DayName = "سه شنبه";
                    break;
                case DayOfWeek.Wednesday:
                    DayName = "چهارشنبه";
                    break;
                case DayOfWeek.Thursday:
                    DayName = "پنج شنبه";
                    break;
                case DayOfWeek.Friday:
                    DayName = "جمعه";
                    break;
                case DayOfWeek.Saturday:
                    DayName = "شنبه";
                    break;
                default:
                    break;
            }
            return DayName;
        }
    }
}
