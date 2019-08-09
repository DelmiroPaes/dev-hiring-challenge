/**********************************************************************************************//**
 * \file    Z:\Prj\Delmiro\Ateliware\dev-hiring-challenge\dev-hiring-
 *          challenge\GitHub.Domain\ADHCServiceJsonResult.cs.
 *
 * \brief   Implements the adhc service JSON result class
 **************************************************************************************************/
using System.Collections.Generic;

namespace GitHub.Models
{
    /**********************************************************************************************//**
     * \class   ADHCServiceJsonResult
     *
     * \brief   Encapsulates the result of an adhc service json.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class ADHCServiceJsonResult
    {
        /**********************************************************************************************//**
         * \property    public int total_count
         *
         * \brief   Gets or sets the number of totals
         *
         * \returns The total number of count.
         **************************************************************************************************/
        public int total_count { get; set; }


        /**********************************************************************************************//**
         * \property    public bool incomplete_results
         *
         * \brief   Gets or sets a value indicating whether the incomplete results
         *
         * \returns True if incomplete results, false if not.
         **************************************************************************************************/
        public bool incomplete_results { get; set; }


        /**********************************************************************************************//**
         * \property    public List<LanguageItem> LanguageItems
         *
         * \brief   Gets or sets the language items
         *
         * \returns The language items.
         **************************************************************************************************/
        public List<LanguageItem> LanguageItems { get; set; }


        /**********************************************************************************************//**
         * \fn  public ADHCServiceJsonResult()
         *
         * \brief   Default constructor
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        public ADHCServiceJsonResult()
        {
            LanguageItems = new List<LanguageItem>();
        }
    }
}
