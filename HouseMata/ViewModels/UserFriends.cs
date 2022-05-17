using HouseMata.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseMata.ViewModels
{
    public class UserFriends
    {
        public User user { get; set; }
        
        public List<User> friend { get; set; }
         

    }
}