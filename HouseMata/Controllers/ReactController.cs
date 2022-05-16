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
    public class ReactController : Controller
    {
        private IReactService service = null;

        public ReactController(IReactService _service)
        {
            service = _service;
        }
        // Post: Reacts

        [HttpPost]
        public ActionResult viewReacts(PostReact _reactionField)
        {
            int _userID = Convert.ToInt32(Session["Id"]);
            service.SaveReactionToDB(_reactionField, _userID);
            return RedirectToAction("viewPosts", "Profile");
        }
    }
}