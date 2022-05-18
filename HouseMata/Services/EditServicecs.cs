using HouseMata.Models;
using HouseMata.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseMata.Services
{
    public class EditServicecs : IEditService
    {
        DataContext db = new DataContext();

        public User ViewEdit(int userId)
        {
           User user = db.Users.SingleOrDefault(x => x.userID == userId) ;
            return user;    
        }
        public void SaveEdit(User userE ,int userId)
        {
            User user = db.Users.SingleOrDefault(x => x.userID == userId);
            user.email = userE.email;
            user.firstName = userE.firstName;
            user.lastName = userE.lastName;
            user.city = userE.city;
            user.country = userE.country;
            user.phone = userE.phone;
            user.headerImage = userE.headerImage;
            user.profileImage = userE.profileImage;
            user.userPassword = userE.userPassword;
            user.userStatus = userE.userStatus; 
            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

        }

    }
}
