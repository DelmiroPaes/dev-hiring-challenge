/**********************************************************************************************//**
 * \file    App_Start\BundleConfig.cs.
 *
 * \brief   Implements the bundle configuration class
 **************************************************************************************************/
using System.Web;
using System.Web.Optimization;

namespace dev_hiring_chalenge_webclient
{
    /**********************************************************************************************//**
     * \class   BundleConfig
     *
     * \brief   A bundle configuration.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class BundleConfig
    {
        /**********************************************************************************************//**
         * \fn  public static void RegisterBundles(BundleCollection bundles)
         *
         * \brief   For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
         *
         * \author  Delmiro Paes
         *
         * \param   bundles The bundles.
         **************************************************************************************************/
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap-dark01.css",
                "~/Content/site.css"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/Theme_Dark_01/bootstrap-dark01.css",
            //          "~/Content/site.css"));
        }
    }
}
