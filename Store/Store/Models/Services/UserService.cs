
using Store.Models.DataBase.Entities;
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

        public bool AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public bool AddUserAdress(string adress, string username)
        {
            throw new NotImplementedException();
        }

        public bool ChangePassword(string username, string old_passwor, string new_password)
        {
            throw new NotImplementedException();
        }

        public bool CheckUserPasswordChange(string username, string Token)
        {
            throw new NotImplementedException();
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

        public string GetUserAdress(string username)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int username)
        {
            throw new NotImplementedException();
        }

        public User GetUserByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public string GetUserCart(int username)
        {
            throw new NotImplementedException();
        }

        public User GetUserInfo(string username)
        {
            throw new NotImplementedException();
        }

        public string GetUserRole(string username)
        {
            throw new NotImplementedException();
        }

        public string GetWishlist(int username)
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

        public bool SendTiket(Ticket ticket, string username)
        {
            throw new NotImplementedException();
        }

        public bool UpdateQty(int username, int productId, int qty)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserAdress(string adress, string username)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserInfo(User user, string username)
        {
            throw new NotImplementedException();
        }

        public bool UserAccountState(string username)
        {
            throw new NotImplementedException();
        }
    }
}
