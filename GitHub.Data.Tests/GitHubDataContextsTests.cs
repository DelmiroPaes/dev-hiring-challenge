/**********************************************************************************************//**
 * \file    GitHubDataContextsTests.cs.
 *
 * \brief   Implements the git hub data contexts tests class
 **************************************************************************************************/

using System.Linq;
using GitHub.Data.GitHubDataContexts;
using GitHub.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using License = GitHub.Models.License;

namespace GitHub.Data.Tests
{
    /**********************************************************************************************//**
     * \class   GitHubDataContextsTests
     *
     * \brief   (Unit Test Class) a git hub data contexts tests.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    [TestClass]
    public class GitHubDataContextsTests
    {
        /**********************************************************************************************//**
         * \fn  public void GitHubDataContextTest_Licenses()
         *
         * \brief   (Unit Test Method) git hub data context test licenses
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void GitHubDataContextTest_Licenses()
        {
            //  Arrange
            License license = null;
            int count = 0;
            GitHubDataContext dbContext = new GitHubDataContext();

            //Act.
            license = new License();
            count = dbContext.Licenses.Count();
            dbContext.Licenses.Add(license);
            dbContext.Licenses.Remove(license);

            //Assert
            Assert.IsTrue(count == dbContext.Licenses.Count());
        }


        /**********************************************************************************************//**
         * \fn  public void GitHubDataContextTest_Owners()
         *
         * \brief   (Unit Test Method) git hub data context test owners
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void GitHubDataContextTest_Owners()
        {
            //  Arrange
            Owner owner = null;
            int count = 0;
            GitHubDataContext dbContext = new GitHubDataContext();

            //Act.
            owner = new Owner();
            count = dbContext.Owners.Count();
            dbContext.Owners.Add(owner);
            dbContext.Owners.Remove(owner);

            //Assert
            Assert.IsTrue(count == dbContext.Owners.Count());
        }
    }
}
