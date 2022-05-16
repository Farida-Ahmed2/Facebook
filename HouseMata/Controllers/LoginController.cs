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
    public class LoginController : Controller
    {
        private ILoginService service = null;

        public LoginController(ILoginService _service)
        {
            service = _service;
        }

        // GET: Login

        public ActionResult Login()
        {
            Session["Id"] = "0";
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel _model)
        {
            if (ModelState.IsValid)
            {
                User _user = service.IsValidUser(_model);
                if (_user == null)
                    return View();
                Session["Id"] = _user.userID.ToString();
                return RedirectToAction("viewPosts", "Profile");
            }
            return View();
        }

        public ActionResult SignUp()
        {
            return RedirectToAction("SignUp", "Register");
        }
    }
}