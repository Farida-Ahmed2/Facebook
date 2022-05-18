using HouseMata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HouseMate.Controllers
{
    public class SearchController : Controller
    {
        DataContext db = new DataContext();
        public ActionResult search(string option , string search)
        {
              //ViewBag.id = Convert.ToInt32(Session["uId"]);
            //if a user choose the radio button option as Subject  
            if (option == "Email")
            {
        
                //List<User> ListOfUserRequest = new List<User>();
                var MyAccount = db.Users.Where(x => x.email == search || search == null).FirstOrDefault();
               // Session["Id"] = MyAccount.userID;
                //ListOfUserRequest = MyAccount;
                //ViewBag.ID = id; //which user account 
                return View(MyAccount);
               // return View(db.Users.Where(x => x.email == search || search == null));
            }
            else
            {
                //List<User> ListOfUserRequest = new List<User>();
                var MyAccount = db.Users.Where(x => x.email == search || search == null).FirstOrDefault();
                //ListOfUserRequest = MyAccount;
                //ViewBag.ID = id; //which user account 
                return View(MyAccount);

            }


        }
    }
}