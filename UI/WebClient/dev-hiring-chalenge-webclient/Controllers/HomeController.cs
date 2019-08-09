/**********************************************************************************************//**
 * \file    Controllers\HomeController.cs.
 *
 * \brief   Implements the home controller class
 **************************************************************************************************/
using dev_hiring_chalenge_webclient.Helpers;
using GitHub.Models;
using System.Web.Mvc;

namespace dev_hiring_chalenge_webclient.Controllers
{
    /**********************************************************************************************//**
     * \class   HomeController
     *
     * \brief   A controller for handling homes.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class HomeController : Controller
    {
        /**********************************************************************************************//**
         * \fn  public ActionResult Index()
         *
         * \brief   Gets the index
         *
         * \author  Delmiro Paes
         *
         * \returns A response stream to send to the Index View.
         **************************************************************************************************/
        public ActionResult Index()
        {
            return View();
        }


        /**********************************************************************************************//**
         * \fn  public ActionResult Ateliware()
         *
         * \brief   Gets the ateliware
         *
         * \author  Delmiro Paes
         *
         * \returns A response stream to send to the Ateliware View.
         **************************************************************************************************/
        public ActionResult Ateliware()
        {
            return this.Redirect("https://github.com/ateliware/dev-hiring-challenge/blob/master/README.md");
        }


        /**********************************************************************************************//**
         * \fn  public ActionResult About()
         *
         * \brief   Gets the about
         *
         * \author  Delmiro Paes
         *
         * \returns A response stream to send to the About View.
         **************************************************************************************************/
        public ActionResult About()
        {
            ViewBag.Message = "";
            return View();
        }


        /**********************************************************************************************//**
         * \fn  public ActionResult QueryResult()
         *
         * \brief   Queries the result
         *
         * \author  Delmiro Paes
         *
         * \returns A response stream to send to the QueryResult View.
         **************************************************************************************************/
        public ActionResult QueryResult()
        {
            ViewBag.Message = "Resultado da consulta ao GitHub.";

            GitHubQuery gitHubQuery = new GitHubQuery();

            //TODO: Check query result.
            ADHCServiceJsonResult adhcServiceJsonResult = gitHubQuery.RunQuery();

            // Fail.
            if (null == adhcServiceJsonResult)
            {
                return View("Error");
            }

            ViewBag.ADHCServiceJsonResult = adhcServiceJsonResult;

            return View();
        }
    }
}