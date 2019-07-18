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
        public bool AddItemInCart(int username, int productId, int qty = 1)
        {
            throw new NotImplementedException();
        }

        public bool AddItemInWishlist(int username, int productId)
        {
            throw new NotImplementedException();
        }

        public bool AddUserAdress(Adress adress, string username)
        {
            throw new NotImplementedException();
        }

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

        public bool CheckUserRole(string username, string role)
        {
            throw new NotImplementedException();
        }

        public bool ExistItemInCart(int username, int productId)
        {
            throw new NotImplementedException();
        }

        public bool ExistItemInWishlist(int username, int productId)
        {
            throw new NotImplementedException();
        }

        public int GetQtyOfUserCaretItem(string username)
        {
            throw new NotImplementedException();
        }

        public Adress GetUserAdress(string username)
        {
            throw new NotImplementedException();
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

        public List<Cart> GetUserCart(int username)
        {
            throw new NotImplementedException();
        }

        public UserInfo GetUserInfo(string username)
        {
            throw new NotImplementedException();
        }

        public RecentOrders GetUserRecentOrders(string username)
        {
            throw new NotImplementedException();
        }

        public string GetUserRole(string username)
        {
            throw new NotImplementedException();
        }

        public List<Wishlist> GetWishlist(int username)
        {
            throw new NotImplementedException();
        }

        public bool IsSeen(int ticketId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveItemAsCart(int username, int productId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveItemAsWishlist(int username, int productId)
        {
            throw new NotImplementedException();
        }

        public bool ResetPassword(string username, string newPassword)
        {
            throw new NotImplementedException();
        }

        public bool SendActivationLinkByEmail(string username, string ActivationLink)
        {
            throw new NotImplementedException();
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

        public bool SendTiket(Ticket ticket, string username)
        {
            throw new NotImplementedException();
        }

        public bool UpdateQty(int username, int productId, int qty)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserAdress(Adress adress, string username)
        {
            throw new NotImplementedException();
        }

        public UserInfo UpdateUserInfo(string username)
        {
            throw new NotImplementedException();
        }

        public bool UserAccountState(string username)
        {
            throw new NotImplementedException();
        }
    }
}
