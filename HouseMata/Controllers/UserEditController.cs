using HouseMata.Models;
using HouseMata.Services;
using HouseMata.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HouseMata.Controllers
{
    public class UserEditController : Controller
    {
        private IEditService service = new EditServicecs();

        /* public UserEditController(IEditService _service)
         {
             service = _service;
         }*/
        // Post: Reacts
        [HttpGet]
        public ActionResult viewEditDetails()
        {
            int id = Convert.ToInt32(Session["Id"]);
            User x =  service.ViewEdit(id);
            return View(x);
        }
        [HttpPost]
          public ActionResult viewEditDetails(User _model)
        {
            if (ModelState.IsValid)
            {
                int _userID = Convert.ToInt32(Session["Id"]);
                service.SaveEdit(_model, _userID);
                return RedirectToAction("viewPosts", "Profile");


            }
            
                return RedirectToAction("viewEditDetails", "UserEdit");
        }
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Edit()
        {
            Session["Id"] = "0";
            return View();
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}