using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FinalProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Index", "{type}",
                new { controller = "Home", action = "Index" },
                new RouteValueDictionary
                {
                   {"type","trang-chu" }
                },
                namespaces: new[] { "FinalProject.Controllers" });

            routes.MapRoute("Register", "{type}",
                new { controller = "Register", action = "Register" },
                new RouteValueDictionary
                {
                   {"type","dang-ky" }
                },
                namespaces: new[] { "FinalProject.Controllers" });

            routes.MapRoute("Index1", "{type}",
             new { controller = "Login", action = "Index" },
             new RouteValueDictionary
             {
                   {"type","dang-nhap" }
             },
             namespaces: new[] { "FinalProject.Controllers" });

            routes.MapRoute("About", "{type}",
                new { controller = "Home", action = "About" },
                new RouteValueDictionary
                {
                    {"type","ve-chung-toi" }
                },
                namespaces: new[] {"FinalProject.Controllers"});
            routes.MapRoute("Contact", "{type}",
                new { controller = "Home", action = "Contact" },
                new RouteValueDictionary
                {
                    {"type","lien-he" }
                },
                namespaces: new[] { "FinalProject.Controllers" });

            routes.MapRoute("News", "{type}",
                new { controller = "News", action = "Index" },
                new RouteValueDictionary
                {
                    {"type","tin-tuc" }
                },
                namespaces: new[] { "FinalProject.Controllers" });


            routes.MapRoute("Service", "{type}/{meta}",
                    new { controller = "Service", action = "Index", meta = UrlParameter.Optional },
                    new RouteValueDictionary
                    {
                        {"type","dich-vu" }
                    },
                    namespaces: new[] { "FinalProject.Controllers" });

            routes.MapRoute("Detail", "{type}/{meta}/{meta_detail}/{id}",
                    new { controller = "Service", action = "Detail", meta = UrlParameter.Optional },
                    new RouteValueDictionary
                    {
                        {"type","dich-vu" }
                    },
                    namespaces: new[] { "FinalProject.Controllers" });

            routes.MapRoute("DetailNews", "{type}/{id}",
                    new { controller = "News", action = "DetailNews", meta = UrlParameter.Optional },
                    new RouteValueDictionary
                    {
                        {"type","tin-tuc" }
                    },
                    namespaces: new[] { "FinalProject.Controllers" });

            //routes.MapRoute("Search", "{type}/{metatimkiem}",
            //    new { controller = "Service", action = "Search", meta = UrlParameter.Optional },
            //    new RouteValueDictionary
            //    {
            //         {"type","dich-vu-tim-kiem" }
            //    },
            //    namespaces: new[] { "FinalProject.Controllers" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home",action = "Index",id = UrlParameter.Optional },
                namespaces: new[] { "FinalProject.Controllers" }
            );
        }
    }
}
