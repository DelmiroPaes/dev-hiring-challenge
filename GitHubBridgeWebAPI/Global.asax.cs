/**********************************************************************************************//**
 * \file    Global.asax.cs.
 *
 * \brief   Implements the global.asax class
 **************************************************************************************************/

using System.Web.Http;

namespace GitHubBridgeWebAPI
{
    /**********************************************************************************************//**
     * \class   WebApiApplication
     *
     * \brief   A web API application.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class WebApiApplication : System.Web.HttpApplication
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
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
