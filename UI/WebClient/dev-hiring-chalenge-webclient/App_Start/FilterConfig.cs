/**********************************************************************************************//**
 * \file    App_Start\FilterConfig.cs.
 *
 * \brief   Implements the filter configuration class
 **************************************************************************************************/
using System.Web;
using System.Web.Mvc;

namespace dev_hiring_chalenge_webclient
{
    /**********************************************************************************************//**
     * \class   FilterConfig
     *
     * \brief   A filter configuration.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class FilterConfig
    {
        /**********************************************************************************************//**
         * \fn  public static void RegisterGlobalFilters(GlobalFilterCollection filters)
         *
         * \brief   Registers the global filters described by filters
         *
         * \author  Delmiro Paes
         *
         * \param   filters The filters.
         **************************************************************************************************/
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
