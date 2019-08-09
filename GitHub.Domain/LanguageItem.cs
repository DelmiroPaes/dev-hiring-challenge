/**********************************************************************************************//**
 * \file    Z:\Prj\Delmiro\Ateliware\dev-hiring-challenge\dev-hiring-
 *          challenge\GitHub.Domain\LanguageItem.cs.
 *
 * \brief   Implements the language item class
 **************************************************************************************************/
using System.Collections.Generic;

namespace GitHub.Models
{
    /**********************************************************************************************//**
     * \class   LanguageItem
     *
     * \brief   A language item.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class LanguageItem
    {
        /**********************************************************************************************//**
         * \property    public string Name
         *
         * \brief   Gets or sets the name
         *
         * \returns The name.
         **************************************************************************************************/
        public string Name { get; set; }


        /**********************************************************************************************//**
         * \property    public int TotalStars
         *
         * \brief   Gets or sets the total number of stars
         *
         * \returns The total number of stars.
         **************************************************************************************************/
        public int TotalStars { get; set; }


        /**********************************************************************************************//**
         * \property    public int TotalProjects
         *
         * \brief   Gets or sets the total number of projects
         *
         * \returns The total number of projects.
         **************************************************************************************************/
        public int TotalProjects { get; set; }


        /**********************************************************************************************//**
         * \property    public List<Item> Items
         *
         * \brief   Gets or sets the items
         *
         * \returns The items.
         **************************************************************************************************/
        public List<Item> Items { get; set; }


        /**********************************************************************************************//**
         * \fn  public LanguageItem()
         *
         * \brief   Default constructor
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        public LanguageItem()
        {
            Items = new List<Item>();
        }
    }
}
