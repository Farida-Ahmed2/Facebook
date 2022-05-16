using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HouseMata.Models;
using HouseMata.ViewModels;

namespace HouseMata.Services
{
    public class LoginService : ILoginService
    {
        private DataContext _context = null;
        public User _user = new User();

        public LoginService()
        {
            _context = new DataContext();
        }

        public User IsValidUser(LoginViewModel model)
        {
            if (model.Username == "" || model.Password == "")
            {
                return null;
            }
            _user = _context.Users.Where(x => x.email == model.Username && x.userPassword == model.Password).FirstOrDefault();
            if (_user == null)
            {
                return null;
            }
            return _user;
        }

    }
}