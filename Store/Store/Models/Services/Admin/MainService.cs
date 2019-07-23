using Microsoft.EntityFrameworkCore;
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
            throw new NotImplementedException();
        }

        public bool ActiveNavSubMenu(int sub_menu_id)
        {
            throw new NotImplementedException();
        }

        public bool ActiveOrDeActiveFAQ(int id)
        {
            throw new NotImplementedException();
        }

        public bool AddFAQ(FAQ fAQ)
        {
            throw new NotImplementedException();
        }

        public bool AddNavMainMenu(Menu menu)
        {
            throw new NotImplementedException();
        }

        public bool AddNavSubMenu(SubMenu subMenu)
        {
            throw new NotImplementedException();
        }

        public bool AddSlider(Slider slider)
        {
            throw new NotImplementedException();
        }

        public bool DeActiveSlider(int slider_id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFAQ(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMessage(int contactUsId)
        {
            throw new NotImplementedException();
        }

        public List<FAQ> GetAllFAQs()
        {
            throw new NotImplementedException();
        }

        public List<Slider> GetAllSliders()
        {
            throw new NotImplementedException();
        }

        public ContactUsMessage GetContactUsMessage(int contactUsId)
        {
            throw new NotImplementedException();
        }

        public List<ContactUsMessage> GetContactUsMessages()
        {
            throw new NotImplementedException();
        }

        public List<string> GetEmails()
        {
            throw new NotImplementedException();
        }

        public FAQ GetFAQById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetNavMenus()
        {
            throw new NotImplementedException();
        }

        public List<SubMenu> GetNavSubMenus(int sub_menu_id)
        {
            throw new NotImplementedException();
        }

        public Setting GetSetting()
        {
            throw new NotImplementedException();
        }

        public List<Slider> GetSliders(bool show_in_main_page = true)
        {
            throw new NotImplementedException();
        }

        public bool IsSeen(int contactUsId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveNavMainMenu(int menu_id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveNavSubMenu(int sub_menu_id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveSlider(int slider_id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveSubscribeToNewsletter(string token)
        {
            throw new NotImplementedException();
        }

        public bool SubscribeToNewsletter(string email)
        {
            throw new NotImplementedException();
        }

        public string SubscribeToNewsletterToken(string email)
        {
            throw new NotImplementedException();
        }

        public bool UpdateFAQ(FAQ fAQ)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNavMainMenu(Menu menu, int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNavSubMenu(SubMenu subMenu, int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSetting(Setting setting)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSlider(Slider slider, int slider_id)
        {
            throw new NotImplementedException();
        }
    }
}