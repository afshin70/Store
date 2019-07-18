using Microsoft.EntityFrameworkCore;
using Store.Models.DataBase.Dto;
using Store.Models.DataBase.Dto.Admin.NavBar;
using Store.Models.IService.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Services.Admin
{
    public class MainService : IMainService
    {
        #region عملیات مربوط به نویگیشن منو
        /// <summary>
        /// لیست نویگیشن منو
        /// </summary>
        /// <returns></returns>
        public List<NavMenu> GetNavMenus()
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.Menus.Where(x => x.IsActive == true).Select(x => new NavMenu
                {
                    Id = x.MenuId,
                    IsActive = x.IsActive,
                    Name = x.Name,
                    Url = x.Url
                }).ToList();
            }
        }
        /// <summary>
        /// لیست زیر منو های نویگیشن منو
        /// </summary>
        /// <param name="main_menu_id">آی دی والد ساب منو</param>
        /// <returns></returns>
        public List<NavSubMenu> GetNavSubMenus(int main_menu_id)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.SubMenus.Where(x => x.IsActive == true & x.MenuId == main_menu_id).Select(x => new NavSubMenu
                {
                    Id = x.SubMenuId,
                    MainMenuId = x.MenuId,
                    IsActive = x.IsActive,
                    Name = x.Name,
                    Url = x.Url
                }).ToList();
            }
        }
        /// <summary>
        /// نویگیشن منو نمایش داده شود؟
        /// اگر بله، باید تمام زیر منو های این منو، نمایششان غیر فعال شود
        /// </summary>
        /// <param name="id">آی دی نویگیشن منو</param>
        /// <returns></returns>
        public bool ShowNavMainMenu(int id)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                try
                {
                    var record = _Storedb.Menus.Where(x => x.MenuId == id).First();
                    record.IsActive = true;
                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// زیر منو نویگیشن منو نمایش داده شود یا نه
        /// </summary>
        /// <param name="id">زیر منو نویگیشن منو</param>
        /// <returns></returns>
        public bool ShowNavSubMenu(int id)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                try
                {
                    var record = _Storedb.SubMenus.Where(x => x.SubMenuId == id).First();
                    record.IsActive = true;
                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// افزودن منو نویگیشن جدید
        /// </summary>
        /// <param name="menu">منو جدید</param>
        /// <returns></returns>
        public bool AddNavMainMenu(NavMenu menu)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                _Storedb.Menus.Add(new DataBase.Entities.Menu()
                {
                    Name = menu.Name,
                    Url = menu.Url,
                    IsActive = menu.IsActive
                });
                try
                {
                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// افزودن زیر منو جدید برای نویگیشن
        /// </summary>
        /// <param name="menu">زیر منو جدید</param>
        /// <param name="nav_main_id">آی دی والد این منو</param>
        /// <returns></returns>
        public bool AddNavSubMenu(NavSubMenu menu, int nav_main_id)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                _Storedb.SubMenus.Add(new DataBase.Entities.SubMenu()
                {
                    MenuId = menu.MainMenuId,
                    Name = menu.Name,
                    Url = menu.Url,
                    IsActive = menu.IsActive
                });
                try
                {
                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// حذف منو نویگیشن
        /// اگر حذف شد، باید فرزندان نیز حذف شود
        /// </summary>
        /// <param name="id">آی دی نویگیشن منو</param>
        /// <returns></returns>
        public bool RemoveNavMainMenu(int id)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                try
                {
                    var record = _Storedb.Menus.Where(x => x.MenuId == id).First();
                    var subs = _Storedb.SubMenus.Where(x => x.MenuId == id);
                    _Storedb.SubMenus.RemoveRange(subs);
                    _Storedb.Menus.Remove(record);
                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// حذف زیر منو نویگیشن منو
        /// </summary>
        /// <param name="id">آی دی زیر منو</param>
        /// <returns></returns>
        public bool RemoveNavSubMenu(int id)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                try
                {
                    var record = _Storedb.SubMenus.Where(x => x.MenuId == id).First();
                    _Storedb.SubMenus.Remove(record);
                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// بروزرسانی نویگیشن منو
        /// فقط نام منو آپدیت شود!!!!!!!!!!!!!!!!
        /// </summary>
        /// <param name="menu">منو جدید</param>
        /// <param name="id">آی دی منو جدید</param>
        /// <returns></returns>
        public bool UpdateNavMainMenu(NavMenu menu, int id)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                try
                {
                    var record = _Storedb.Menus.Where(x => x.MenuId == menu.Id).First();
                    record.IsActive = menu.IsActive;
                    record.Name = menu.Name;
                    record.Url = menu.Url;
                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// بروزرسانی زیر منو
        /// فقط نام منو آپدیت شود
        /// </summary>
        /// <param name="menu">زیر منو بروز شده</param>
        /// <param name="id">آی دی زیر منو</param>
        /// <returns></returns>
        public bool UpdateNavSubMenu(NavSubMenu menu, int id)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                try
                {
                    var record = _Storedb.SubMenus.Where(x => x.SubMenuId == menu.Id).First();
                    record.IsActive = menu.IsActive;
                    record.Name = menu.Name;
                    record.Url = menu.Url;
                    record.MenuId = menu.MainMenuId;
                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion
        #region  عضویت در خبرنامه
        /// <summary>
        /// عضویت در خبرنامه
        /// </summary>
        /// <param name="Email">ایمیل</param>
        /// <returns></returns>
        public bool SubscribeToNewsletter(string email)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                var record = _Storedb.NewsLetters.Where(x => x.Email.ToLower() == email.ToLower());

                if (record != null)
                {
                    if (record.Count() > 0)
                    {
                        record.First().IsDeleted = false;
                        record.First().Token = string.Empty.GetNewToken();
                    }
                    else
                    {
                        _Storedb.NewsLetters.Add(new DataBase.Entities.NewsLetter()
                        {
                            Email = email,
                            IsDeleted = false,
                            Token = "".GetNewToken()
                        });
                    }
                }
                else
                {
                    _Storedb.NewsLetters.Add(new DataBase.Entities.NewsLetter()
                    {
                        Email = email,
                        IsDeleted = false,
                        Token = "".GetNewToken()
                    });
                }
                try
                {
                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// توکن عضویت در خبرنامه جهت درخواست غیر فال سازی عضویت از سمت کاربر با لینک
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public string SubscribeToNewsletterToken(string email)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                var record = _Storedb.NewsLetters.Where(x => x.Email.ToLower() == email.ToLower());

                if (record != null)
                {
                    if (record.Count() > 0)
                    {
                        return record.First().Token;
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    return "";
                }
            }
        }
        /// <summary>
        /// حذف عضویت در خبرنامه
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public bool RemoveSubscribeToNewsletter(string token)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                var record = _Storedb.NewsLetters.Where(x => x.Token.ToLower() == token.ToLower()).IgnoreQueryFilters();

                if (record != null)
                {
                    if (record.Count() > 0)
                    {
                        record.First().IsDeleted = true;
                    }
                }
                try
                {
                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        /// <summary>
        ///  لیست ایمیلهای عضو در خبرنامه سایت
        /// </summary>
        /// <returns></returns>
        public List<string> GetEmails()
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.NewsLetters.Select(x => x.Email).Distinct().ToList();
            }
        }
        #endregion
        #region اسلایدر
        /// <summary>
        /// لیست اسلایدرها بر اساس اینکه آیا همه باشد یا آنهایی که قرار است در صفحه اصلی نمایش داده شود
        /// </summary>
        /// <param name="show_in_main_page">آیا در صفحه اصلی نمایش داده شود یا فعال باشد؟</param>
        /// <returns></returns>
        public List<Slider> GetSliders(bool show_in_main_page = true)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return _Storedb.Sliders.Where(x => x.IsActive == true).Select(p => new Slider
                {
                    SliderId = p.SliderId,
                    Title = p.Title,
                    Description = p.Description,
                    ImageName = p.ImageName,
                    ImageNameMob = p.ImageNameMob,
                    IsShowInMainPage = p.IsShowInMainPage,
                    UrlLink = p.UrlLink,
                    UrlText = p.UrlText
                }).ToList();
            }
        }
        /// <summary>
        /// حذف اسلایدر
        /// </summary>
        /// <param name="slider_id">آدی اسلایدر</param>
        /// <returns></returns>
        public bool RemoveSlider(int slider_id)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                try
                {
                    var record = _Storedb.Sliders.Where(x => x.SliderId == slider_id).First();
                    _Storedb.Sliders.Remove(record);
                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// غیرفعال کردن نمایش اسلایدر در صفحه اصلی
        /// </summary>
        /// <param name="id">آی دی اسلایدر</param>
        /// <returns></returns>
        public bool DeActiveSlider(int slider_id)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                try
                {
                    var record = _Storedb.Sliders.Where(x => x.SliderId == slider_id).First();
                    record.IsActive = false;
                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// اسلایدر جدید
        /// </summary>
        /// <param name="slider">اسلایدر</param>
        /// <returns></returns>
        public bool AddSlider(Slider slider)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                _Storedb.Sliders.Add(new DataBase.Entities.Slider()
                {
                    SliderId = slider.SliderId,
                    Title = slider.Title,
                    Description = slider.Description,
                    ImageName = slider.ImageName,
                    ImageNameMob = slider.ImageNameMob,
                    IsShowInMainPage = slider.IsShowInMainPage,
                    UrlLink = slider.UrlLink,
                    UrlText = slider.UrlText,
                    IsActive = true
                });
                try
                {
                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// بروزرسانی اسلایدر
        /// </summary>
        /// <param name="slider">اسلایدر</param>
        /// <param name="slider_id">آی دی اسلایدر</param>
        /// <returns></returns>
        public bool UpdateSlider(Slider slider, int slider_id)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                _Storedb.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                try
                {
                    var record = _Storedb.Sliders.Where(x => x.SliderId == slider.SliderId).First();

                    record.IsActive = false;
                    record.Description = slider.Description;
                    record.ImageName = slider.ImageName;
                    record.ImageNameMob = slider.ImageNameMob;
                    record.IsShowInMainPage = slider.IsShowInMainPage;
                    record.Title = slider.Title;
                    record.UrlLink = slider.UrlLink;
                    record.UrlText = slider.UrlText;

                    _Storedb.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            #endregion

        }
    }
}