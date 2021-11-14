using StaticWebsite.Models;
using StaticWebsite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaticWebsite.Controllers
{
    //[Authorize]
    public class AdminController : Controller
    {
       
        IEmployeeData db;
        // GET: Admin
        public AdminController(IEmployeeData db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageEmployees()
        {
            var model = db.GetAll();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return RedirectToAction("DisplayError404", "Error404");
            }
            return View(model);
        }
        public ActionResult RetrieveImage(int id)
        {
            byte[] cover = db.GetImageFromDataBase(id);
            if (cover != null)
            {
                return File(cover, "image/jpg");
            }
            else
            {
                return null;
            }
        }
       
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
       
        [Route("Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            HttpPostedFileBase file = Request.Files["ImageData"];
            int i = db.Add(file, employee);
            if (i==1)//ModelState.IsValid()
            {
                //db.Add(file,employee);
                return RedirectToAction("Details", new { id = employee.Id });
            }
            return View();
        }
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return RedirectToAction("DisplayError404", "Error404");
            }
            return View(model);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Update(employee);
                
                return RedirectToAction("Details", new { id = employee.Id });
            }
            return View(employee);
        }
       
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.Get(id);
            if(model==null)
            { 
                return RedirectToAction("DisplayError404", "Error404");
            }
            return View(model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,FormCollection form)
        {
            db.Delete(id);
            return RedirectToAction("ManageEmployees", "Admin");
        }
    }   
}