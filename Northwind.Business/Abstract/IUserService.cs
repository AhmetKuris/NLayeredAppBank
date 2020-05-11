using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);

        User GetUserById(int id);
        
        string Login(string name, string password);
        string SignUp(string name, string password);
        void ResetTempData();

        string ShowMyBalance();
        string WelcomeUser();

        void DepositMoney(decimal money);
        void WithdrawMoney(decimal money);
        void TransferMoney( string userTo, decimal money);
    }
}
