/**********************************************************************************************//**
 * \file    GitHubApiQueryTests.cs.
 *
 * \brief   Implements the git hub API query tests class
 **************************************************************************************************/
using GitHubQuery;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace GitHubQueryTests
{
    /**********************************************************************************************//**
     * \class   GitHubApiQueryTests
     *
     * \brief   (Unit Test Class) a git hub API query tests.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    [TestClass()]
    public class GitHubApiQueryTests
    {
        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_GetApiVersionTest()
         *
         * \brief   (Unit Test Method) executes the query test get API version test operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_GetApiVersionTest()
        {
            // arrange
            string apiResult = string.Empty;
            GitHubApiQuery gitHubApiQuery = new GitHubApiQuery("Java");

            // act
            apiResult = gitHubApiQuery.GetApiVersion();
             
            // assert
            Assert.IsFalse(apiResult == string.Empty);
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_GetApiBaseSearch()
         *
         * \brief   (Unit Test Method) executes the query test get API base search operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_GetApiBaseSearch()
        {
            // arrange
            string apiResult = string.Empty;
            GitHubApiQuery gitHubApiQuery = new GitHubApiQuery("Java");

            // act
            apiResult = gitHubApiQuery.GetApiBaseSearch();
             
            // assert
            Assert.IsFalse(apiResult == string.Empty);
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_GetApiSortCommand()
         *
         * \brief   (Unit Test Method) executes the query test get API sort command operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_GetApiSortCommand()
        {
            // arrange
            string apiResult = string.Empty;
            GitHubApiQuery gitHubApiQuery = new GitHubApiQuery("Java");

            // act
            apiResult = gitHubApiQuery.GetApiSortCommand();
             
            // assert
            Assert.IsFalse(apiResult == string.Empty);
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_GetApiOrderCommand()
         *
         * \brief   (Unit Test Method) executes the query test get API order command operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_GetApiOrderCommand()
        {
            // arrange
            string apiResult = string.Empty;
            GitHubApiQuery gitHubApiQuery = new GitHubApiQuery("Java");

            // act
            apiResult = gitHubApiQuery.GetApiOrderCommand();
             
            // assert
            Assert.IsFalse(apiResult == string.Empty);
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_ApiQueryMinStars()
         *
         * \brief   (Unit Test Method) executes the query test API query minimum stars operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_ApiQueryMinStars()
        {
            // arrange
            int apiResult = 1000;
            GitHubApiQuery gitHubApiQuery = new GitHubApiQuery("Java");

            // act
            gitHubApiQuery.ApiQueryMinStars = apiResult;
            
            // assert
            Assert.IsTrue(apiResult == gitHubApiQuery.ApiQueryMinStars);
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_WithValidLanguageName()
         *
         * \brief   (Unit Test Method) executes the query test with valid language name operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_WithValidLanguageName()
        {
            // arrange
            string queryResult = string.Empty; 
            GitHubApiQuery gitHubApiQuery = new GitHubApiQuery("Java");

            // act
            queryResult = gitHubApiQuery.RunQuery();

            // assert
            Assert.IsFalse(string.IsNullOrEmpty(queryResult));
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_EmptyLanguageNameArgument_Exception()
         *
         * \brief   (Unit Test Method) executes the query test empty language name argument exception
         *          operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_EmptyLanguageNameArgument_Exception()
        {
            // arrange
            bool throwArgumentException = false;

            // act
            try
            {
                GitHubApiQuery gitHubApiQuery = new GitHubApiQuery("");
            }
            catch (Exception ex)
            {
                throwArgumentException = ex is ArgumentException;
            }

            // assert
            Assert.IsTrue(throwArgumentException);
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_WhiteSpaceLanguageName_Exception()
         *
         * \brief   (Unit Test Method) executes the query test white space language name exception
         *          operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_WhiteSpaceLanguageName_Exception()
        {
            // arrange
            bool throwArgumentException = false;

            // act
            try
            {
                GitHubApiQuery gitHubApiQuery = new GitHubApiQuery("     ");
            }
            catch (Exception ex)
            {
                throwArgumentException = ex is ArgumentException;
            }

            // assert
            Assert.IsTrue(throwArgumentException);
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_HttpRequest_TimeOutException()
         *
         * \brief   (Unit Test Method) executes the query test HTTP request time out exception
         *          operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_HttpRequest_TimeOutException()
        {
            // arrange
            bool throwException = false;
            bool throwTimeOutException = false;
            string result = string.Empty;
            GitHubApiQuery gitHubApiQuery = new GitHubApiQuery("Java");
            gitHubApiQuery.MillisecondsToWait = 500;

            // act
            try
            {
                result = gitHubApiQuery.RunQuery();

                if (string.IsNullOrEmpty(result))
                {
                    throwException = true;
                    throwTimeOutException = true;
                }
            }
            //
            //  HttpClient take care about TimeoutException so TaskCanceledException should be used instead.
            //  Keep this code here things may change in the future.
            //
            catch (TimeoutException)
            {
                throwException = true;
                throwTimeOutException = true;
            }

            // assert
            Assert.IsTrue(throwException && throwTimeOutException);
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_HttpRequest_Exception()
         *
         * \brief   (Unit Test Method) executes the query test HTTP request exception operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_HttpRequest_Exception()
        {
            // arrange
            bool throwException = false;
            bool throwArgumentException = false;
            GitHubApiQuery gitHubApiQuery = null;

            // act
            try
            {
                gitHubApiQuery = new GitHubApiQuery("");
            }
            catch (Exception ex)
            {
                throwException = true;
                throwArgumentException = ex is ArgumentException;
            }

            // assert
            Assert.IsTrue(throwException && throwArgumentException);
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_GitHubApiOffline_Exception()
         *
         * \brief   (Unit Test Method) executes the query test git hub API offline exception operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_GitHubApiOffline_Exception()
        {
            // arrange
            GitHubApiQuery gitHubApiQuery = null;
            string gitHubApiResult = string.Empty;

            // act
            try
            {
                gitHubApiQuery = new GitHubApiQuery("Java");
                gitHubApiResult = gitHubApiQuery.RunQuery();

                if (!string.IsNullOrEmpty(gitHubApiResult))
                {
                    Assert.IsTrue(string.IsNullOrEmpty(gitHubApiResult),
                        "\nO serviço GitHubApi tem que estar fora do ar para este teste passar\nDesconecte-se da internet.");
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message, ex);
            }

            // assert
            Assert.IsTrue(string.IsNullOrEmpty(gitHubApiResult));
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_GetItemsTest_EmptyObjectListFromJson()
         *
         * \brief   (Unit Test Method) executes the query test get items test empty object list from JSON
         *          operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_GetItemsTest_EmptyObjectListFromJson()
        {
            // arrange
            GitHubApiQuery gitHubApiQuery = null; 

            // act
            try
            {
                gitHubApiQuery = new GitHubApiQuery("");
                gitHubApiQuery.RunQuery();
            }
            catch (ArgumentException)
            {
                gitHubApiQuery = null;
            }

            // assert
            Assert.IsTrue(gitHubApiQuery == null);
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_GetItemsTest_NotEmptyObjectListFromJson()
         *
         * \brief   (Unit Test Method) executes the query test get items test not empty object list from
         *          JSON operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_GetItemsTest_NotEmptyObjectListFromJson()
        {
            // arrange
            string jsonResult = string.Empty;
            GitHubApiQuery gitHubApiQuery = null;

            // act
            try
            {
                gitHubApiQuery = new GitHubApiQuery(new List<string>(new string[] {"Java", "C", "Python", "C++", "C#"}));
                gitHubApiQuery.MillisecondsToWait = 100000; //  Adjust for LAN service access.
                jsonResult = gitHubApiQuery.RunQuery();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message, ex);
            }

            // assert
            Assert.IsFalse(gitHubApiQuery == null && string.IsNullOrEmpty(jsonResult));
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_GitHubApiQuery_EmptyListString()
         *
         * \brief   (Unit Test Method) executes the query test git hub API query empty list string
         *          operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_GitHubApiQuery_EmptyListString()
        {
            // arrange
            List<string> languages = new List<string>();
            GitHubApiQuery gitHubApiQuery = null;

            // act
            try
            {
                gitHubApiQuery = new GitHubApiQuery(languages);
            }
            catch (ArgumentException)
            {
                return;
            }

            // assert
            Assert.Fail();
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_GetJsonFromSqlTest_SQLServerOnline()
         *
         * \brief   (Unit Test Method) executes the query test get JSON from SQL test SQL server online
         *          operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_GetJsonFromSqlTest_SQLServerOnline()
        {
            // arrange
            List<string> languages =  new List<string>(new string[] { "Java", "C", "Python", "C++", "C#" });
            string jsonResult = string.Empty;
            GitHubApiQuery gitHubApiQuery = null;

            // act
            try
            {
                gitHubApiQuery = new GitHubApiQuery(languages);
                gitHubApiQuery.MillisecondsToWait = 100000; //  Adjust for LAN service access.
                gitHubApiQuery.ApiItemsPerPage = 5;
                gitHubApiQuery.ApiPages = 1;

                gitHubApiQuery.RunQuery();

                jsonResult = gitHubApiQuery.GetJsonFromSql();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message, ex);
            }

            // assert
            Assert.IsFalse(string.IsNullOrEmpty(jsonResult));
        }


        /**********************************************************************************************//**
         * \fn  public void RunQueryTest_GetJsonFromSqlTest_SQLServerOffline()
         *
         * \brief   (Unit Test Method) executes the query test get JSON from SQL test SQL server offline
         *          operation
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void RunQueryTest_GetJsonFromSqlTest_SQLServerOffline()
        {
            // arrange
            string jsonResult = string.Empty;
            GitHubApiQuery gitHubApiQuery = null;

            // act
            try
            {
                gitHubApiQuery = new GitHubApiQuery(new List<string>(new string[] { "Java" }));
                gitHubApiQuery.MillisecondsToWait = 10000; //  Adjust for LAN service access.
                gitHubApiQuery.ApiItemsPerPage = 5;
                gitHubApiQuery.ApiPages = 1;

                gitHubApiQuery.RunQuery();

                jsonResult = gitHubApiQuery.GetJsonFromSql();

                Assert.IsTrue(string.IsNullOrEmpty(jsonResult), "\n\nPara este teste passar o SQL Server deve estar indisponível.\n");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message, ex);
            }

            // assert
            Assert.IsTrue(string.IsNullOrEmpty(jsonResult));
        }


        /**********************************************************************************************//**
         * \fn  public void CheckGitWebApiAccess_JustToCoverability_Test()
         *
         * \brief   (Unit Test Method) tests check git web API access just to coverability
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void CheckGitWebApiAccess_JustToCoverability_Test()
        {
            // arrange
            bool result = false; 
            GitHubApiQuery gitHubApiQuery = null;

            // act
            try
            {
                gitHubApiQuery = new GitHubApiQuery(new List<string>(new string[] { "Java" }));
                gitHubApiQuery.CheckGitWebApiAccess();
                result = true;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message, ex);
            }

            // assert
            Assert.IsTrue(result);
        }


        /**********************************************************************************************//**
         * \fn  public void ApiVersion_JustToCoverability_Test()
         *
         * \brief   (Unit Test Method) tests API version just to coverability
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod()]
        public void ApiVersion_JustToCoverability_Test()
        {
            // arrange
            string apiVersion = string.Empty;
            GitHubApiQuery gitHubApiQuery = null;

            // act
            try
            {
                gitHubApiQuery = new GitHubApiQuery(new List<string>(new string[] { "Java" }));
                apiVersion = gitHubApiQuery.ApiVersion;
                gitHubApiQuery.ApiVersion = apiVersion;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message, ex);
            }

            // assert
            Assert.IsFalse(string.IsNullOrEmpty(apiVersion));
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
            result = GitHubApiQuery.CheckByPing("127.0.0.1", 2000);

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

            //Act
            result = GitHubApiQuery.CheckByPing("8.8.8.8", 2000);

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
            result = GitHubApiQuery.CheckByPing("");

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
            result = GitHubApiQuery.CheckByPing("www.google.com");

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
            result = GitHubApiQuery.CheckByPing("127.0.0.1", -1);

            //Assert
            Assert.IsFalse(result);
        }
    }
}

//[TestMethod]
//public void Withdraw_ValidAmount_ChangesBalance()
//{
//    // arrange
//    double currentBalance = 10.0;
//    double withdrawal = 1.0;
//    double expected = 9.0;
//    var account = new CheckingAccount("JohnDoe", currentBalance);

//    // act
//    account.Withdraw(withdrawal);

//    // assert
//    Assert.AreEqual(expected, account.Balance);
//}
