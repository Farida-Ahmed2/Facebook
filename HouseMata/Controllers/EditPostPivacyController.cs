using HouseMata.Services;
using HouseMata.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HouseMata.Controllers
{
    public class EditPostPivacyController : Controller
    {
        // GET: EditPostPivacy
        private IEditPrivacy service = new EditPrivacy() ;

        /*public EditPostPivacyController (IEditPrivacy _service)
        {
            service = _service;
        }*/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit( EditPostPrivacy model)
        {
            service.Edit(model);
            return RedirectToAction("viewPosts", "Profile");
            return View();
        }
    }
}