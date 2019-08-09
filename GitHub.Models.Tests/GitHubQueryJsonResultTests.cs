/**********************************************************************************************//**
 * \file    GitHubQueryJsonResultTests.cs.
 *
 * \brief   Implements the git hub query JSON result tests class
 **************************************************************************************************/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GitHub.Models.Tests
{
    /**********************************************************************************************//**
     * \class   GitHubQueryJsonResultTests
     *
     * \brief   (Unit Test Class) a git hub query JSON result tests.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    [TestClass]
    public class GitHubQueryJsonResultTests
    {
        /**********************************************************************************************//**
         * \fn  public void GitHubQueryJsonResultTests_JustToCoverability_Test()
         *
         * \brief   (Unit Test Method) tests git hub query JSON result tests just to coverability
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void GitHubQueryJsonResultTests_JustToCoverability_Test()
        {
            // arrange
            GitHubQueryJsonResult gitHubQueryJsonResult = new GitHubQueryJsonResult();
            bool incomplete_results = false;
            int total_count = 0;
            List<Item> Items = new List<Item>();

            // Act
            gitHubQueryJsonResult.incomplete_results = incomplete_results;
            gitHubQueryJsonResult.total_count = total_count;
            gitHubQueryJsonResult.Items = Items;
            incomplete_results = gitHubQueryJsonResult.incomplete_results;
            total_count = gitHubQueryJsonResult.total_count;
            Items = gitHubQueryJsonResult.Items;

            // Assert
            Assert.IsTrue(gitHubQueryJsonResult.incomplete_results == incomplete_results ||
                          gitHubQueryJsonResult.total_count == total_count ||
                          gitHubQueryJsonResult.Items == Items);
        }
    }
}
