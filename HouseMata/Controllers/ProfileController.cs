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
        // GET: Profile
        DataContext db = new DataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult viewProfile()
        {
            User user = db.Users.SingleOrDefault(x => x.userID == 2);
            return View(user);
        }

        [HttpPost]
        public ActionResult viewProfile(FormCollection postField )
        {
            int x = Convert.ToInt32(Session["Id"]);
            Post post = new Post();
            post.userID = x;
            post.content = postField["post-field"];
            post.location = "fs";
            post.numberOfDisLikes = 0;
            post.numberOfLikes = 0;
            post.preference = "fg";
            post.privacyType = 1;
            db.Posts.Add(post);
            db.SaveChanges();
            return View(db.Users.SingleOrDefault(y=>y.userID==x));
        }
    }
}