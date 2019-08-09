/**********************************************************************************************//**
 * \file    GitHubQueryJsonResult.cs.
 *
 * \brief   Implements the git hub query JSON result class
 **************************************************************************************************/
using System.Collections.Generic;

namespace GitHub.Models
{
    /**********************************************************************************************//**
     * \class   GitHubQueryJsonResult
     *
     * \brief   Encapsulates the result of a git hub query json.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class GitHubQueryJsonResult
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
         * \property    public List<Item> Items
         *
         * \brief   Gets or sets the items
         *
         * \returns The items.
         **************************************************************************************************/
        public List<Item> Items { get; set; }
    }
}
