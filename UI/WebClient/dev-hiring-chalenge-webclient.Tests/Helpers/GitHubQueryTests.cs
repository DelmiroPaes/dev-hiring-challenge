/**********************************************************************************************//**
 * \file    Helpers\GitHubQueryTests.cs.
 *
 * \brief   Implements the git hub query tests class
 **************************************************************************************************/
using System;
using dev_hiring_chalenge_webclient.Helpers;
using GitHub.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dev_hiring_chalenge_webclient.Tests.Helpers
{
    /**********************************************************************************************//**
     * \class   GitHubQueryTests
     *
     * \brief   (Unit Test Class) a git hub query tests.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    [TestClass]
    public class GitHubQueryTests
    {
        /**********************************************************************************************//**
         * \fn  public void GitHubQuery_QueryResult_Test()
         *
         * \brief   (Unit Test Method) tests git hub query result
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void GitHubQuery_QueryResult_Test()
        {
            //Arrange
            GitHubQuery gitHubQuery = new GitHubQuery();

            //Act
            ADHCServiceJsonResult adhcServiceJsonResult = gitHubQuery.RunQuery();

            //Assert
            Assert.IsTrue(adhcServiceJsonResult != null);
        }


        /**********************************************************************************************//**
         * \fn  public void GitHubQuery_PingLocal_Test()
         *
         * \brief   (Unit Test Method) tests git hub query ping local
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void GitHubQuery_PingLocal_Test()
        {
            //Arrange
            bool result = false;

            //Act
            result = GitHubQuery.CheckByPing("127.0.0.1", 2000);

            //Assert
            Assert.IsTrue(result);
        }


        /**********************************************************************************************//**
         * \fn  public void GitHubQuery_PingWEB_Test()
         *
         * \brief   (Unit Test Method) tests git hub query ping web
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void GitHubQuery_PingWEB_Test()
        {
            //Arrange
            bool result = false;
            GitHubQuery gitHubQuery = new GitHubQuery();

            //Act
            result = GitHubQuery.CheckByPing("8.8.8.8", 2000);

            //Assert
            Assert.IsTrue(result);
        }


        /**********************************************************************************************//**
         * \fn  public void GitHubQuery_PingNoHost_Test()
         *
         * \brief   (Unit Test Method) tests git hub query ping no host
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void GitHubQuery_PingNoHost_Test()
        {
            //Arrange
            bool result = false;

            //Act
            result = GitHubQuery.CheckByPing("");

            //Assert
            Assert.IsFalse(result);
        }


        /**********************************************************************************************//**
         * \fn  public void GitHubQuery_PingHostName_Test()
         *
         * \brief   (Unit Test Method) tests git hub query ping host name
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void GitHubQuery_PingHostName_Test()
        {
            //Arrange
            bool result = false;

            //Act
            result = GitHubQuery.CheckByPing("www.google.com");

            //Assert
            Assert.IsTrue(result);
        }


        /**********************************************************************************************//**
         * \fn  public void GitHubQuery_PingAssert_Test()
         *
         * \brief   (Unit Test Method) tests git hub query ping assert
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void GitHubQuery_PingAssert_Test()
        {
            //Arrange
            bool result = false;

            //Act
            result = GitHubQuery.CheckByPing("127.0.0.1", -1);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
