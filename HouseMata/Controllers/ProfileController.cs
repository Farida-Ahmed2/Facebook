using HouseMata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HouseMata.Controllers
{
    public class ProfileController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Profile

        [HttpGet]
        public ActionResult viewPosts()
        {
            if (Session["Id"] == "0" || Session["Id"] == null)
            {
                return RedirectToAction("Login", "Login");
            }

            int _x = Convert.ToInt32(Session["Id"]);

            User _user = new User();
            _user = db.Users.Find(_x);

            if (_user == null)
            {
                return RedirectToAction("Login", "Login");
            }
            return View(_user);
        }

        [HttpPost]
        public ActionResult viewPosts(FormCollection postField)
        {
            int _x = Convert.ToInt32(Session["Id"]);
            Post _post = new Post();
            _post.userID = _x;
            _post.content = postField["post-field"];
            _post.location = "fs";
            _post.numberOfDisLikes = 0;
            _post.numberOfLikes = 0;
            _post.preference = "fg";
            _post.privacyType = 1;
            db.Posts.Add(_post);
            db.SaveChanges();
            return View(db.Users.SingleOrDefault(y=>y.userID==_x));
        }
    }
}