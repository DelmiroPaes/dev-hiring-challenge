/**********************************************************************************************//**
 * \file    Controllers\HomeControllerTest.cs.
 *
 * \brief   Implements the home controller test class
 **************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dev_hiring_chalenge_webclient;
using dev_hiring_chalenge_webclient.Controllers;
using dev_hiring_chalenge_webclient.Helpers;
using GitHub.Models;

namespace dev_hiring_chalenge_webclient.Tests.Controllers
{
    /**********************************************************************************************//**
     * \class   HomeControllerTest
     *
     * \brief   (Unit Test Class) a home controller test.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    [TestClass]
    public class HomeControllerTest
    {
        /**********************************************************************************************//**
         * \fn  public void Index_View_Test()
         *
         * \brief   (Unit Test Method) tests index view
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void Index_View_Test()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        /**********************************************************************************************//**
         * \fn  public void About_View_Test()
         *
         * \brief   (Unit Test Method) tests about view
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void About_View_Test()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result); 
        }


        /**********************************************************************************************//**
         * \fn  public void QueryResult_View_Test()
         *
         * \brief   (Unit Test Method) tests query result view
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void QueryResult_View_Test()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.QueryResult() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        /**********************************************************************************************//**
         * \fn  public void Ateliware_View_Test()
         *
         * \brief   (Unit Test Method) tests ateliware view
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void Ateliware_View_Test()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Ateliware() as ViewResult;

            // Assert
            Assert.IsNull(result);
        }
    }
}
