using StaticWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaticWebsite.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if (user.Name.Equals("Admin") && user.Password.Equals("12345678"))
            {
                return RedirectToAction("ManageEmployees", "Admin");
            }
            else return View();
        }
            

    } 
}