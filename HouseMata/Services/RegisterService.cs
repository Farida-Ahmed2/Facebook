using HouseMata.Models;
using HouseMata.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Web;

namespace HouseMata.Services
{
    public class RegisterService : IRegisterService
    {
        private DataContext _context = null;
        public RegisterService()
        {
            _context = new DataContext();
        }
        public void SaveUserToDB(SignUpViewModel _model)
        {
            User _user = new User();
            _user.profileImage = _model.ProfileImage;
            _user.firstName = _model.FirstName;
            _user.lastName = _model.LastName;
            _user.country = _model.Country;
            _user.city = _model.City;
            _user.phone = _model.Phone;
            _user.email = _model.Email;
            _user.userStatus = _model.Status;
            _user.headerImage = _model.HeaderImage;
            _user.userPassword = _model.Password;

            _context.Users.Add(_user);
            _context.SaveChanges();
        }
    }  
}