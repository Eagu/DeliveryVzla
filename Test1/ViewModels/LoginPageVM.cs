using System;
using System.Collections.Generic;
using System.Text;
using Test1.Models;
using Test1.Services;

namespace Test1.ViewModels
{
    public class LoginPageVM
    {
        public string Prueba { get; set; }

        public LoginPageVM()
        {
            Prueba = "Yes yes yes nojoda";
            DataBase.Users = new List<User>()
            {
                new User()
                {
                    Username = "igu",
                    Password = "0000"
                }
            };
        }

        public bool VerifyLogin(string username, string password)
        {
           foreach (User user in DataBase.Users)
            {
                if (user.Username == username)
                {
                    if (user.Password == password)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }
    }
}
