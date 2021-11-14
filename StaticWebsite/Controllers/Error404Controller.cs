using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaticWebsite.Controllers
{
    public class Error404Controller : Controller
    {
        // GET: Error404
        public ActionResult DisplayError404()
        {
            return View();
        }
    }
}