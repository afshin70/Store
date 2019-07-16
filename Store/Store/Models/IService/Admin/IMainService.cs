using Store.Models.DataBase.Dto;
using Store.Models.DataBase.Dto.Admin.NavBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.IService.Admin
{
    public interface IMainService
    {
        #region عملیات مربوط به نویگیشن منو
        /// <summary>
        /// لیست نویگیشن منو
        /// </summary>
        /// <returns></returns>
        List<NavMenu> GetNavMenus();
        /// <summary>
        /// لیست زیر منو های نویگیشن منو
        /// </summary>
        /// <param name="main_menu_id">آی دی والد ساب منو</param>
        /// <returns></returns>
        List<NavSubMenu> GetNavSubMenus(int main_menu_id);
        /// <summary>
        /// نویگیشن منو نمایش داده شود؟
        /// اگر بله، باید تمام زیر منو های این منو، نمایششان غیر فعال شود
        /// </summary>
        /// <param name="id">آی دی نویگیشن منو</param>
        /// <returns></returns>
        bool ShowNavMainMenu(int id);
        /// <summary>
        /// زیر منو نویگیشن منو نمایش داده شود یا نه
        /// </summary>
        /// <param name="id">زیر منو نویگیشن منو</param>
        /// <returns></returns>
        bool ShowNavSubMenu(int id);
        /// <summary>
        /// افزودن منو نویگیشن جدید
        /// </summary>
        /// <param name="menu">منو جدید</param>
        /// <returns></returns>
        bool AddNavMainMenu(NavMenu menu);
        /// <summary>
        /// افزودن زیر منو جدید برای نویگیشن
        /// </summary>
        /// <param name="menu">زیر منو جدید</param>
        /// <param name="nav_main_id">آی دی والد این منو</param>
        /// <returns></returns>
        bool AddNavSubMenu(NavSubMenu menu,int nav_main_id);
        /// <summary>
        /// حذف منو نویگیشن
        /// اگر حذف شد، باید فرزندان نیز حذف شود
        /// </summary>
        /// <param name="id">آی دی نویگیشن منو</param>
        /// <returns></returns>
        bool RemoveNavMainMenu(int id);
        /// <summary>
        /// حذف زیر منو نویگیشن منو
        /// </summary>
        /// <param name="id">آی دی زیر منو</param>
        /// <returns></returns>
        bool RemoveNavSubMenu(int id);
        /// <summary>
        /// بروزرسانی نویگیشن منو
        /// فقط نام منو آپدیت شود!!!!!!!!!!!!!!!!
        /// </summary>
        /// <param name="menu">منو جدید</param>
        /// <param name="id">آی دی منو جدید</param>
        /// <returns></returns>
        bool UpdateNavMainMenu(NavMenu menu,int id);
        /// <summary>
        /// بروزرسانی زیر منو
        /// فقط نام منو آپدیت شود
        /// </summary>
        /// <param name="menu">زیر منو بروز شده</param>
        /// <param name="id">آی دی زیر منو</param>
        /// <returns></returns>
        bool UpdateNavSubMenu(NavSubMenu menu,int id);
        #endregion

        #region عضویت در خبرنامه
        /// <summary>
        /// عضویت در خبرنامه
        /// </summary>
        /// <param name="Email">ایمیل</param>
        /// <returns></returns>
        bool SubscribeToNewsletter(string email);
        /// <summary>
        /// توکن عضویت در خبرنامه جهت درخواست غیر فال سازی عضویت از سمت کاربر با لینک
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        string SubscribeToNewsletterToken(string email);
        /// <summary>
        /// حذف عضویت در خبرنامه
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        bool RemoveSubscribeToNewsletter(string token);
        /// <summary>
        ///  لیست ایمیلهای عضو در خبرنامه سایت
        /// </summary>
        /// <returns></returns>
        List<string> GetEmails();
        #endregion

        #region  اسلایدر
        /// <summary>
       /// لیست اسلایدرها بر اساس اینکه آیا همه باشد یا آنهایی که قرار است در صفحه اصلی نمایش داده شود
       /// </summary>
       /// <param name="show_in_main_page">آیا در صفحه اصلی نمایش داده شود یا فعال باشد؟</param>
       /// <returns></returns>
        List<Slider> GetSliders(bool show_in_main_page=true);
        /// <summary>
        /// حذف اسلایدر
        /// </summary>
        /// <param name="slider_id">آدی اسلایدر</param>
        /// <returns></returns>
        bool RemoveSlider(int slider_id);
        /// <summary>
        /// غیرفعال کردن نمایش اسلایدر در صفحه اصلی
        /// </summary>
        /// <param name="id">آی دی اسلایدر</param>
        /// <returns></returns>
        bool DeActiveSlider(int slider_id);
        /// <summary>
        /// اسلایدر جدید
        /// </summary>
        /// <param name="slider">اسلایدر</param>
        /// <returns></returns>
        bool AddSlider(Slider slider);
        /// <summary>
        /// بروزرسانی اسلایدر
        /// </summary>
        /// <param name="slider">اسلایدر</param>
        /// <param name="slider_id">آی دی اسلایدر</param>
        /// <returns></returns>
        bool UpdateSlider(Slider slider, int slider_id);
        #endregion
    }
}
