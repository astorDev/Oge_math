using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OgeFirst.Areas.Admin
{
    public class AdminOnlyAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var cookies = filterContext.HttpContext.Request.Cookies;

            if (cookies.Count == 0 || cookies[cookies.Count - 1].Value == null || cookies[cookies.Count - 1].Value != "iamadminbitch") { 

                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary
                {
                    { "area", "Admin" },
                    { "controller", "Home" },
                    { "action", "Register" }
                });

            }
        }
    }
}