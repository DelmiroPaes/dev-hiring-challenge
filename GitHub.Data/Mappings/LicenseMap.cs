/**********************************************************************************************//**
 * \file    Mappings\LicenseMap.cs.
 *
 * \brief   Implements the license map class
 **************************************************************************************************/

using System.Data.Entity.ModelConfiguration;
using GitHub.Models;

namespace GitHub.Data.Mappings
{
    /**********************************************************************************************//**
     * \class   LicenseMap
     *
     * \brief   Map of licenses.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    class LicenseMap : EntityTypeConfiguration<License>
    {
        /**********************************************************************************************//**
         * \fn  public LicenseMap()
         *
         * \brief   Default constructor
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        public LicenseMap()
        {
            ToTable("License");
            HasKey(x => x.Id);
        }
    }
}
