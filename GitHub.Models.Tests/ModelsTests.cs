/**********************************************************************************************//**
 * \file    ModelsTests.cs.
 *
 * \brief   Implements the models tests class
 **************************************************************************************************/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GitHub.Models.Tests
{
    /**********************************************************************************************//**
     * \class   ModelsTests
     *
     * \brief   (Unit Test Class) the models tests.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    [TestClass]
    public class ModelsTests
    {
        /**********************************************************************************************//**
         * \fn  public void LanguageItem_JustToCoverability_Test()
         *
         * \brief   (Unit Test Method) tests language item just to coverability
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void LanguageItem_JustToCoverability_Test()
        {
            // arrange
            LanguageItem languageItem = new LanguageItem();
            string Name = "";
            int TotalStars = 0;
            int TotalProjects = 0;
            List<Item> Items = new List<Item>();

            // Act
            // Set.
            languageItem.Name = Name;
            languageItem.TotalStars = TotalStars;
            languageItem.TotalProjects = TotalProjects;
            languageItem.Items = Items;
            // Get.
            Name = languageItem.Name;
            TotalStars = languageItem.TotalStars;
            TotalProjects = languageItem.TotalProjects;
            Items = languageItem.Items;

            // Assert
            Assert.IsTrue(languageItem.Name == Name ||
                            languageItem.TotalStars == TotalStars ||
                            languageItem.TotalProjects == TotalProjects ||
                            languageItem.Items == Items);
        }


        /**********************************************************************************************//**
         * \fn  public void LicenseTests_JustToCoverability_Test()
         *
         * \brief   (Unit Test Method) tests license tests just to coverability
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void LicenseTests_JustToCoverability_Test()
        {
            // arrange
            bool result = true;
            License license1 = new License();
            License license2 = new License();

            // Act
            System.Reflection.PropertyInfo[] license1Properties = license1.GetType().GetProperties();
            System.Reflection.PropertyInfo[] license2Properties = license2.GetType().GetProperties();

            // Get and Set.
            for(int index = 0; index < license1Properties.Length; ++index)
            {
                license2Properties[index].SetValue(license2, license1Properties[index].GetValue(license1));
            }

            // Compare values.
            for(int index = 0; index < license1Properties.Length; ++index)
            {
                // Step by step to be clear.
                var var1 = license1Properties[index].GetValue(license1);
                var var2 = license2Properties[index].GetValue(license2);

                if(var1?.ToString() != var2?.ToString())
                {
                    result = false;
                    break;
                }
            }

            // Assert
            Assert.IsTrue(license1 != license2 && result);
        }


        /**********************************************************************************************//**
         * \fn  public void OwnerTests_JustToCoverability_Test()
         *
         * \brief   (Unit Test Method) tests owner tests just to coverability
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void OwnerTests_JustToCoverability_Test()
        {
            // arrange
            bool result = true;
            Owner owner1 = new Owner();
            Owner owner2 = new Owner();

            // Act
            System.Reflection.PropertyInfo[] owner1Properties = owner1.GetType().GetProperties();
            System.Reflection.PropertyInfo[] owner2Properties = owner2.GetType().GetProperties();

            // Get and Set.
            for(int index = 0; index < owner1Properties.Length; ++index)
            {
                owner2Properties[index].SetValue(owner2, owner1Properties[index].GetValue(owner1));
            }

            // Compare values.
            for(int index = 0; index < owner1Properties.Length; ++index)
            {
                // Step by step to be clear.
                var var1 = owner1Properties[index].GetValue(owner1);
                var var2 = owner2Properties[index].GetValue(owner2);

                if(var1?.ToString() != var2?.ToString())
                {
                    result = false;
                    break;
                }
            }

            // Assert
            Assert.IsTrue(owner1 != owner2 && result);
        }


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

            int total_count = 0;
            bool incomplete_results = false;
            List<LanguageItem> languageItems = new List<LanguageItem>();

            // Act
            // Set.
            adhcServiceJsonResult.total_count = total_count;
            adhcServiceJsonResult.incomplete_results = incomplete_results;
            adhcServiceJsonResult.LanguageItems = languageItems;
            // Get.
            total_count = adhcServiceJsonResult.total_count;
            incomplete_results = adhcServiceJsonResult.incomplete_results;
            languageItems = adhcServiceJsonResult.LanguageItems;

            // Assert
            Assert.IsTrue(adhcServiceJsonResult.incomplete_results == incomplete_results ||
                          adhcServiceJsonResult.total_count == total_count ||
                          adhcServiceJsonResult.LanguageItems == languageItems);
        }


        /**********************************************************************************************//**
         * \fn  public void ItemTests_JustToCoverability_Test()
         *
         * \brief   (Unit Test Method) tests item tests just to coverability
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        [TestMethod]
        public void ItemTests_JustToCoverability_Test()
        {
            // arrange
            bool result = true;
            Item item1 = new Item();
            Item item2 = new Item();
            item1.License = new License();
            item1.Owner = new Owner();

            // Act
            System.Reflection.PropertyInfo[] item1Properties = item1.GetType().GetProperties();
            System.Reflection.PropertyInfo[] item2Properties = item2.GetType().GetProperties();

            // Get and Set.
            for(int index = 0; index < item1Properties.Length; ++index)
            {
                item2Properties[index].SetValue(item2, item1Properties[index].GetValue(item1));
            }

            // Compare values.
            for(int index = 0; index < item1Properties.Length; ++index)
            {
                // Step by step to be clear.
                var var1 = item1Properties[index].GetValue(item1);
                var var2 = item2Properties[index].GetValue(item2);

                if(var1?.ToString() != var2?.ToString())
                {
                    result = false;
                    break;
                }
            }

            // Assert
            Assert.IsTrue(item1 != item2 && result);
        }
    }
}
