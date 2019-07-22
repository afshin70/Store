using Newtonsoft.Json;
using Store.Models.DataBase.Dto.Frount.Footer;
using Store.Models.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Services.Frount
{
    /// <summary>
    /// سرویس فوتر
    /// </summary>
    public class SiteFooterService : ISiteFooterService
    {
        /// <summary>
        ///  عضویت در خبرنامه
        /// </summary>
        /// <param name="email">ایمیل</param>
        /// <returns></returns>
        public FoterBarMenu GetFooterMenu()
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                return JsonConvert.DeserializeObject<FoterBarMenu>(_Storedb.Settings.First().ContactUs_Json);
            }
        }
        /// <summary>
        ///دریافت منو فوتر
        /// </summary>
        /// <returns></returns>
        public bool SubscribeByEmail(string email)
        {
            using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
            {
                try
                {
                    var result = _Storedb.NewsLetters.Where(x => x.Email == email);
                    if (result.Count() > 0)
                    {
                        result.First().IsDeleted = false;
                        result.First().Token = string.Empty.GetNewToken();
                    }
                    else
                    {
                        _Storedb.NewsLetters.Add(new DataBase.Entities.NewsLetter() {
                            Email = email,
                            IsDeleted = false,
                            Token = string.Empty.GetNewToken()
                        });
                    }
                    _Storedb.SaveChanges();
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