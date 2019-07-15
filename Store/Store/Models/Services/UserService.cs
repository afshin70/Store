using Store.Models.DataBase.Dto.User;
using Store.Models.IService;
using Store.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.Services
{
    public class UserService : IUserService
    {
        ///t
        /// <summary>
        /// دریافت اطلاعات یوزر با نام کاربری
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <returns></returns>
        public bool ChangePassword(string username, string old_passwor, string new_password)
        {
            try
            {

                using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
                {
                    var user = _Storedb.Users.Where(x => x.UserName == username & x.Password == Cryptography.Encrypt(old_passwor, x.Salt)).First();
                    user.Password = new_password;
                    user.Token = Guid.NewGuid().ToString();
                    _Storedb.SaveChanges();
                }
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        /// <summary>
        /// چک کردن توکن برای تغییرات رمز ورود
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="Token">توکن کاربر</param>
        /// <returns></returns>
        public bool CheckUserPasswordChange(string username, string Token)
        {
            try
            {
                using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
                {
                    var user = _Storedb.Users.Where(x => x.UserName == username & x.Token == Token).ToList();
                    if (user.Count > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        /// <summary>
        /// دریافت اطلاعات یوزر با آی دی
        /// </summary>
        /// <param name="UserId">آی دی کاربر</param>
        /// <returns></returns>
        public User GetUserById(int UserId)
        {

            try
            {
                using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
                {
                    var user = _Storedb.Users.Where(x => x.UserId == UserId).First();
                    User _user = new User() {
                        UserId=user.UserId,
                        UserName=user.UserName,
                        FullName=user.FullName,
                        //Email=user.Email,
                        Gender=user.Gender,
                        Biography=user.Biography,
                        IsBlock=user.IsBlock,
                        IsVerified=user.IsVerified,
                        MobileNo=user.MobileNo
                    };
                    return _user;
                }
            }
            catch (Exception Ex)
            {
                return null;
            }
        }
        /// <summary>
        /// تغیر رمز کاربری
        /// </summary>
        /// <param name="username">نام کاربری</param>
        /// <param name="old_passwor">رمز ورود قبلی</param>
        /// <param name="new_password">رمز ورود جدید</param>
        /// <returns></returns>
        public User GetUserByUsername(string username)
        {
            try
            {
                using (Store.Models.DataBase.Context.StoreContext _Storedb = new DataBase.Context.StoreContext(null))
                {
                    var user = _Storedb.Users.Where(x => x.UserName == username).First();
                    User _user = new User()
                    {
                        UserId = user.UserId,
                        UserName = user.UserName,
                        FullName = user.FullName,
                        //Email = user.Email,
                        Gender = user.Gender,
                        Biography = user.Biography,
                        IsBlock = user.IsBlock,
                        IsVerified = user.IsVerified,
                        MobileNo = user.MobileNo
                    };
                    return _user;
                }
            }
            catch (Exception Ex)
            {
                return null;
            }
        }
        /// <summary>
        /// ارسال ایمیل به مشتری
        /// </summary>
        /// <param name="username_Email">ایمیل مشتری</param>
        /// <param name="subject">موضوع ایمیل</param>
        /// <param name="body">متن ایمیل</param>
        /// <param name="signiture">امضا</param>
        /// <returns></returns>
        public bool SendEmailToCustomer(string username_Email, string subject, string body, string signiture)
        {
            try
            {
                BaseUtility utility = new BaseUtility();
               return utility.SendMail(username_Email, subject, body, false);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
