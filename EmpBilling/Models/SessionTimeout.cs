﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EmpBilling.Models
{
    public class SessionTimeout : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpContext ctx = HttpContext.Current;
            if (HttpContext.Current.Session["EmpId"] == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                      new RouteValueDictionary(
                          new
                          {
                              controller = "Emp",
                              action = "EmpLogin",
                              returnUrl = filterContext.HttpContext.Request.Url.GetComponents(UriComponents.PathAndQuery, UriFormat.SafeUnescaped)
                          }));
            }



            base.OnActionExecuting(filterContext);
        }
    }
}