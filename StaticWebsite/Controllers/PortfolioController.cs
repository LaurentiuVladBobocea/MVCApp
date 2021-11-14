using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaticWebsite.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portofolio
        public ActionResult Index()
        {
            return View();
        }
    }
}