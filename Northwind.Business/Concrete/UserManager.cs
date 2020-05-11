using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    class UserManager:IUserService
    {
        private IUserDal _userDal;
        private User _loggedInUser;
        
        public UserManager(IUserDal userDal)
        {   
            _userDal = userDal;
            _loggedInUser = _userDal.Get(p => p.Id==10);
        }

        //Essential trio
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }


        //Backbone
        public User GetUserById(int id)
        {
            return _userDal.Get(p => p.Id == id);
        }

        public string Login(string name, string password)
        {
             User user =  _userDal.Get(p => p.Name==name);

            if (user != null)
            {
                if (user.Password == password)
                {
                    _userDal.Update(new User
                    {
                        Id = 10,
                        Name = user.Name,
                        Balance = user.Balance,
                        Password = user.Password,
                        ExtraForLogin = user.Id

                    });



                    return "True";
                }
                else
                {
                    return "FalsePassword";
                }
            }
            else
            {
                return "FalseUser";
            }
        }

        


        public string SignUp(string name, string password)
        {
            var user = _userDal.Get(p => p.Name == name); 

            if (user is null)
            {
                User newUser=new User();
                newUser.Name = name;
                newUser.Password = password;
                Add(newUser);
                return "Added";
            }
            else
            {
                return "AlreadyExists";
            }

        }

        public void ResetTempData()
        {
            _userDal.Update(new User
            {
                Id = 10,
                Name = " ",
                Balance = 0,
                Password = " "

            });
        }


        //Details and logics
        public string ShowMyBalance()
        {
            return Convert.ToString(_loggedInUser.Balance);
        }

        public string WelcomeUser()
        {
            return  _loggedInUser.Name;
        }

        public void DepositMoney(decimal money)
        {
            _loggedInUser.Balance = _loggedInUser.Balance+ money;
            _userDal.Update(new User
            {
                Id = _loggedInUser.ExtraForLogin,
                Name = _loggedInUser.Name,
                Balance = _loggedInUser.Balance,
                Password = _loggedInUser.Password
            });
        }

        public void WithdrawMoney( decimal money)
        {
            _loggedInUser.Balance = _loggedInUser.Balance - money;
            _userDal.Update(new User
            {
                Id = _loggedInUser.ExtraForLogin,
                Name = _loggedInUser.Name,
                Balance = _loggedInUser.Balance,
                Password = _loggedInUser.Password
            });
        }

        public void TransferMoney(string userTo, decimal money)
        {
            _loggedInUser.Balance = _loggedInUser.Balance - money;
            _userDal.Update(new User
            {
                Id = _loggedInUser.ExtraForLogin,
                Name = _loggedInUser.Name,
                Balance = _loggedInUser.Balance,
                Password = _loggedInUser.Password
            });

            ///////

            var tempUser= _userDal.Get(p => p.Name == userTo);
            tempUser.Balance = tempUser.Balance + money;

            _userDal.Update(tempUser);

        }
    }
}
