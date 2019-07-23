using Microsoft.EntityFrameworkCore;
using Store.Models.DataBase.Context;
using Store.Models.DataBase.Entities;
using Store.Models.IService.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Services.Admin
{
    public class MainService : IMainService
    {
        public bool ActiveNavMainMenu(int menu_id)
        {
            using (var db = new StoreContext(null))
            {
                var result = db.Menus.Where(x => x.MenuId == menu_id).First();
                result.IsActive = true;
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool ActiveNavSubMenu(int sub_menu_id)
        {
            using (var db = new StoreContext(null))
            {
                var result = db.SubMenus.Where(x => x.SubMenuId == sub_menu_id).First();
                result.IsActive = true;
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool ActiveOrDeActiveFAQ(int id)
        {
            using (var db = new StoreContext(null))
            {
                var result = db.FAQs.Where(x => x.FAQId == id).First();
                result.IsActive = !result.IsActive;
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool AddFAQ(FAQ fAQ)
        {
            using (var db = new StoreContext(null))
            {
                db.FAQs.Add(fAQ);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool AddNavMainMenu(Menu menu)
        {
            using (var db = new StoreContext(null))
            {
                db.Menus.Add(menu);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool AddNavSubMenu(SubMenu subMenu)
        {
            using (var db = new StoreContext(null))
            {
                db.SubMenus.Add(subMenu);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool AddSlider(Slider slider)
        {
            using (var db = new StoreContext(null))
            {
                db.Sliders.Add(slider);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool DeActiveSlider(int slider_id)
        {
            using (var db = new StoreContext(null))
            {
                var result = db.Sliders.Where(x => x.SliderId == slider_id).First();
                result.IsActive = false;
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool DeleteFAQ(int id)
        {
            using (var db = new StoreContext(null))
            {
                var result = db.FAQs.Where(x => x.FAQId == id).First();
                db.FAQs.Remove(result);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool DeleteMessage(int contactUsId)
        {
            using (var db = new StoreContext(null))
            {
                var result = db.ContactUsMessages.Where(x => x.MessageId == contactUsId).First();
                db.ContactUsMessages.Remove(result);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public List<FAQ> GetAllFAQs()
        {
            using (var db = new StoreContext(null))
            {
                return db.FAQs.ToList();
            }
        }

        public List<Slider> GetAllSliders()
        {
            using (var db = new StoreContext(null))
            {
                return db.Sliders.ToList();
            }
        }

        public ContactUsMessage GetContactUsMessage(int contactUsId)
        {
            using (var db = new StoreContext(null))
            {
                return db.ContactUsMessages.Where(x => x.MessageId == contactUsId).First();
            }
        }

        public List<ContactUsMessage> GetContactUsMessages()
        {
            using (var db = new StoreContext(null))
            {
                return db.ContactUsMessages.ToList();
            }
        }

        public List<string> GetEmails()
        {
            using (var db = new StoreContext(null))
            {
                return db.NewsLetters.Where(x => !x.IsDeleted).Select(x => x.Email).ToList();
            }
        }

        public FAQ GetFAQById(int id)
        {
            using (var db = new StoreContext(null))
            {
                return db.FAQs.Where(x => x.FAQId == id).First();
            }
        }

        public List<Menu> GetNavMenus()
        {
            using (var db = new StoreContext(null))
            {
                return db.Menus.ToList();
            }
        }

        public List<SubMenu> GetNavSubMenus(int sub_menu_id)
        {
            using (var db = new StoreContext(null))
            {
                return db.SubMenus.Where(x => x.MenuId == sub_menu_id).ToList();
            }
        }

        public Setting GetSetting()
        {
            using (var db = new StoreContext(null))
            {
                return db.Settings.First();
            }
        }

        public List<Slider> GetSliders(bool show_in_main_page = true)
        {
            using (var db = new StoreContext(null))
            {
                return db.Sliders.Where(x => x.IsShowInMainPage == show_in_main_page).ToList();
            }
        }

        public bool IsSeen(int contactUsId)
        {
            using (var db = new StoreContext(null))
            {
                return db.ContactUsMessages.Where(x => x.MessageId == contactUsId).First().IsSeen;
            }
        }

        public bool RemoveNavMainMenu(int menu_id)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Menus.Where(x => x.MenuId == menu_id).First();
                    db.Menus.Remove(result);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool RemoveNavSubMenu(int sub_menu_id)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.SubMenus.Where(x => x.SubMenuId == sub_menu_id).First();
                    db.SubMenus.Remove(result);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool RemoveSlider(int slider_id)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Sliders.Where(x => x.SliderId == slider_id).First();
                    db.Sliders.Remove(result);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool RemoveSubscribeToNewsletter(string token)
        {
            using (var db = new StoreContext(null))
            {
                if (db.NewsLetters.Any(x => x.Token == token))
                {
                    var result = db.NewsLetters.Where(x => x.Token == token).First();
                    result.IsDeleted = true;
                }
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool SubscribeToNewsletter(string email)
        {
            using (var db = new StoreContext(null))
            {

                if (db.NewsLetters.Any(x => x.Email == email))
                {
                    var result = db.NewsLetters.Where(x => x.Email == email).First();
                    result.IsDeleted = false;
                    result.Token = string.Empty.GetNewToken();
                }
                else
                {
                    db.NewsLetters.Add(new NewsLetter()
                    {
                        Email = email,
                        IsDeleted = false,
                        Token = string.Empty.GetNewToken()
                    });
                }
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public string SubscribeToNewsletterToken(string email)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    return db.NewsLetters.Where(x => x.Email == email).First().Token;
                }
                catch (Exception)
                {
                    return "";
                }
            }
        }

        public bool UpdateFAQ(FAQ fAQ)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.FAQs.Where(x => x.FAQId == fAQ.FAQId).First();
                    result.Answer = fAQ.Answer;
                    result.IsActive = fAQ.IsActive;
                    result.OrderNumber = fAQ.OrderNumber;
                    result.Question = fAQ.Question;
                    db.SaveChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool UpdateNavMainMenu(Menu menu, int id)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Menus.Where(x => x.MenuId == menu.MenuId).First();
                    result.IsActive = menu.IsActive;
                    result.Name = menu.Name;
                    result.Url = menu.Url;
                    db.SaveChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool UpdateNavSubMenu(SubMenu subMenu, int id)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.SubMenus.Where(x => x.SubMenuId == subMenu.SubMenuId).First();
                    result.IsActive = subMenu.IsActive;
                    result.Name = subMenu.Name;
                    result.Url = subMenu.Url;
                    result.MenuId = subMenu.MenuId;
                    db.SaveChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool UpdateSetting(Setting setting)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Settings.First();

                    result.AboutUsPage = setting.AboutUsPage;
                    result.BanerImageName = setting.BanerImageName;
                    result.BanerImageNameMob = setting.BanerImageNameMob;
                    result.ContactUsMapUrl = setting.ContactUsMapUrl;
                    result.ContactUsPage = setting.ContactUsPage;
                    result.ContactUs_Json = setting.ContactUs_Json;
                    result.FAQPage = setting.FAQPage;
                    result.Information_Json = setting.Information_Json;
                    result.SotialNetwork_Json = setting.SotialNetwork_Json;
                    result.Terms_ConditionsPage = setting.Terms_ConditionsPage;
                    result.UserAccountLink_json = setting.UserAccountLink_json;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool UpdateSlider(Slider slider, int slider_id)
        {
            using (var db = new StoreContext(null))
            {
                try
                {
                    var result = db.Sliders.Where(x => x.SliderId == slider.SliderId).First();
                    result.Description = slider.Description;
                    result.ImageName = slider.ImageName;
                    result.ImageNameMob = slider.ImageNameMob;
                    result.IsActive = slider.IsActive;
                    result.IsShowInMainPage = slider.IsShowInMainPage;
                    result.Title = slider.Title;
                    result.UrlLink = slider.UrlLink;
                    result.UrlText = slider.UrlText;

                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}