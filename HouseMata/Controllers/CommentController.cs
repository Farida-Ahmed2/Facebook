using HouseMata.Models;
using HouseMata.Services;
using HouseMata.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HouseMata.Controllers
{
    public class CommentController : Controller
    {
        private ICommentService service = null;

        public CommentController(ICommentService _service)
        {
            service = _service;
        }
        // Post: Comments

        [HttpPost]
        public ActionResult viewComments(PostComment _commentField)
        {
            int _userID = Convert.ToInt32(Session["Id"]);
            service.SaveCommentToDB(_commentField, _userID);
            return RedirectToAction("viewPosts", "Profile");
        }
    }
}