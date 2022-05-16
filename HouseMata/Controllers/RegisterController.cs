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
    public class RegisterController : Controller
    {
        private IRegisterService service = null;

        public RegisterController(IRegisterService _service)
        {
            service = _service;
        }

        // GET: Register

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(SignUpViewModel _model)
        {
            if (ModelState.IsValid)
            {
                service.SaveUserToDB(_model);
                return RedirectToAction("viewPosts", "Profile");
            }
            return View(_model);
        }

        public string change_Image_Path(HttpPostedFileBase _profileImage)
        {
            string _fileName = Path.GetFileName(_profileImage.FileName);
            string _path = Path.Combine(Server.MapPath("~/Images"), _fileName);
            _profileImage.SaveAs(_path);
            return _fileName;
        }

        public ActionResult Login()
        {
            return RedirectToAction("Login", "Login");
        }
    }
}