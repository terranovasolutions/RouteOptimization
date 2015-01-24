using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace RouteOptimizationUI.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }
       // [HttpGet]
        public ActionResult Login(Models.User user)
        {
           // return View();
            if (ModelState.IsValid)
            {
               string role= user.IsValid(user.UserName, user.Password);
                if (role=="admin")
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, user.RememberMe);
                    return RedirectToAction("Index", "Product");
                }
                else if(role=="employee")
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, user.RememberMe);
                    return RedirectToAction("Index", "Stores");
                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                }
            }
            return View(user);
        }

        [HttpPost]
        //public ActionResult Login(Models.User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (user.IsValid(user.UserName, user.Password))
        //        {
        //             FormsAuthentication.SetAuthCookie(user.UserName, user.RememberMe);
        //            return RedirectToAction("Index", "Home");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Login data is incorrect!");
        //        }
        //    }
        //    return View(user);
        //}
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}