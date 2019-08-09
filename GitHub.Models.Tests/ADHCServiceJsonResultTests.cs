/**********************************************************************************************//**
 * \file    ADHCServiceJsonResultTests.cs.
 *
 * \brief   Implements the adhc service JSON result tests class
 **************************************************************************************************/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GitHub.Models.Tests
{
    /**********************************************************************************************//**
     * \class   ADHCServiceJsonResultTests
     *
     * \brief   (Unit Test Class) an adhc service JSON result tests.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    [TestClass]
    public class ADHCServiceJsonResultTests
    {
        /**********************************************************************************************//**
         * \fn  public void ADHCServiceJsonResultTests_JustToCoverability_Test()
         *
         * \brief   (Unit Test Method) tests adhc service JSON result tests just to coverability
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void ADHCServiceJsonResultTests_JustToCoverability_Test()
        {
            // arrange
            ADHCServiceJsonResult adhcServiceJsonResult = new ADHCServiceJsonResult();
            bool incomplete_results = false;
            int total_count = 0;
            List<LanguageItem> languageItems = new List<LanguageItem>();

            // Act
            adhcServiceJsonResult.incomplete_results = incomplete_results;
            adhcServiceJsonResult.total_count = total_count;
            adhcServiceJsonResult.LanguageItems = languageItems;

            // Assert
            Assert.IsTrue(adhcServiceJsonResult.incomplete_results == incomplete_results ||
                           adhcServiceJsonResult.total_count == total_count ||
                           adhcServiceJsonResult.LanguageItems == languageItems);
        }
    }
}
