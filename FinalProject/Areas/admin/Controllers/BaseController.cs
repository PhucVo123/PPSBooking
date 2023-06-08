using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FinalProject.Areas.admin.Code;
using FinalProject.Areas.Model;
namespace WebApplication5.Areas.admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = SessionHelper.GetSession();
            if(session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new 
                    RouteValueDictionary(new {controller = "Login", action = "Index", Area= "admin"}));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}