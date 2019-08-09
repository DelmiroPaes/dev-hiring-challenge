/**********************************************************************************************//**
 * \file    Global.asax.cs.
 *
 * \brief   Implements the global.asax class
 **************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace dev_hiring_chalenge_webclient
{
    /**********************************************************************************************//**
     * \class   MvcApplication
     *
     * \brief   A MVC application.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class MvcApplication : System.Web.HttpApplication
    {
        /**********************************************************************************************//**
         * \fn  protected void Application_Start()
         *
         * \brief   Application start
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
