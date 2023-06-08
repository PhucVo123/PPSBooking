using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;

//52000854 - Võ Huy Phúc

namespace FinalProject.Controllers
{
    public class ServiceController : Controller
    {
        TravelDB _db = new TravelDB();
        // GET: Service
        public ActionResult Index(string meta)
        {
            var v = from t in _db.Categories
                    where t.meta == meta
                    select t;
            return View(v.FirstOrDefault());

        }
        public ActionResult Detail(long id)
        {
            var v = from t in _db.Details
                    where t.ProductID == id && t.hide == true
                    orderby t.order_detail ascending
                    select t;
            return View(v.FirstOrDefault());
        }
        public ActionResult Search(string position)
        {
            var service = from t in _db.Products
                          where t.position.ToUpper().Contains(position.ToUpper()) && t.Category.meta == "tour-du-lich"
                          select t;
            return View(service);

        }
        //public ActionResult getDetailService(long id)
        //{
        //    var v = from t in _db.Details
        //            where  t.hide == true && t.ProductID == id
        //            orderby t.order_detail ascending
        //            select t;
        //    return PartialView(v.FirstOrDefault());
        //}
       
    }
}