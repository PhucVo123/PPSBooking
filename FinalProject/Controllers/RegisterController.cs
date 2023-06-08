using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class RegisterController : Controller
    {
        TravelDB _db = new TravelDB();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                var check = _db.Users.FirstOrDefault(s => s.numberphone== user.numberphone);
                if(check == null) 
                {
                    _db.Configuration.ValidateOnSaveEnabled = false;
                    user.id = getMaxId();
                    _db.Users.Add(user);
                    _db.SaveChanges();
                    return RedirectToAction("Index","Home"); 
                }
                else
                {
                    ViewBag.error = "Number Phone is existed";
                    return View();
                } 
            }
            return View();
        }
        public int getMaxId()
        {
            return _db.Users.Count();
        }
    }
}