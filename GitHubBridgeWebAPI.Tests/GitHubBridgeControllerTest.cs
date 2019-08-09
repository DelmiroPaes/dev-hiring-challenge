/**********************************************************************************************//**
 * \file    UnitTest1.cs.
 *
 * \brief   Implements the unit test 1 class
 **************************************************************************************************/

using System.Net.Http;
using GitHubBridgeWebAPI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GitHubBridgeWebAPI.Tests
{
    /**********************************************************************************************//**
     * \class   UnitTest1
     *
     * \brief   (Unit Test Class) a unit test 1.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    [TestClass]
    public class GitHubBridgeControllerTest
    {
        /**********************************************************************************************//**
         * \fn  public void TestMethod1()
         *
         * \brief   (Unit Test Method) tests method 1
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void GitHubQuery_Request_Test()
        {
            // Arrange
            GitHubBridgeController controller = new GitHubBridgeController();

            // Act
            HttpResponseMessage httpResponseMessage = controller.GitHubQuery();

            // Assert
            Assert.IsNotNull(httpResponseMessage);
        }
    }
}
