/**********************************************************************************************//**
 * \file    App_Start\RouteConfig.cs.
 *
 * \brief   Implements the route configuration class
 **************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace dev_hiring_chalenge_webclient
{
    /**********************************************************************************************//**
     * \class   RouteConfig
     *
     * \brief   A route configuration.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class RouteConfig
    {
        /**********************************************************************************************//**
         * \fn  public static void RegisterRoutes(RouteCollection routes)
         *
         * \brief   Registers the routes described by routes
         *
         * \author  Delmiro Paes
         *
         * \param   routes  The routes.
         **************************************************************************************************/
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
