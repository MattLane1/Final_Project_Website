/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : RouteConfig.cs
  @Website Name : Assignment_2_The_Bear_Den_Restaraunt
  @File Description : This is RouteConfig file required by MVC
  
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Assignment_2_Matthew_Lane
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
