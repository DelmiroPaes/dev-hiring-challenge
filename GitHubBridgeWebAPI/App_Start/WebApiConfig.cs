/**********************************************************************************************//**
 * \file    App_Start\WebApiConfig.cs.
 *
 * \brief   Implements the web API configuration class
 **************************************************************************************************/

using System.Web.Http;

namespace GitHubBridgeWebAPI
{
    /**********************************************************************************************//**
     * \class   WebApiConfig
     *
     * \brief   A web API configuration.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public static class WebApiConfig
    {
        /**********************************************************************************************//**
         * \fn  public static void Register(HttpConfiguration config)
         *
         * \brief   Registers this object
         *
         * \author  Delmiro Paes
         *
         * \param   config  The configuration.
         **************************************************************************************************/
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //config. 

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
