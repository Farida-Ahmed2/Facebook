using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HouseMata.Models;
namespace HouseMata.Controllers
{

    public class FriendsController : Controller
    {
        // GET: Friends
        public DataContext db = new DataContext();
        public ActionResult ShowMyFriends()
        {
            int currentUserId = Convert.ToInt32(Session["uId"]);

            List<Friend> friends = db.Friends.Where(x => x.userID == currentUserId).ToList();
            return View(friends);
        }

        public ActionResult ShowMyFriendsPage(int? Id)
        {
            if (Session["uId"] == "0" || Session["uId"] == null || Id == null)
            {
                return RedirectToAction("Login", "Login");
            }
            User userToShow = new User();

            try
            {
                userToShow = db.Users.Find(Convert.ToInt32(Id));
            }
            catch
            {
                return RedirectToAction("Login", "Login");
            }

            return View(userToShow);
        }

    }
}