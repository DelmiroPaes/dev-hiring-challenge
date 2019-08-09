/**********************************************************************************************//**
 * \file    Mappings\OwnerMap.cs.
 *
 * \brief   Implements the owner map class
 **************************************************************************************************/

using System.Data.Entity.ModelConfiguration;
using GitHub.Models;

namespace GitHub.Data.Mappings
{
    /**********************************************************************************************//**
     * \class   OwnerMap
     *
     * \brief   Map of owners.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    class OwnerMap : EntityTypeConfiguration<Owner>
    {
        /**********************************************************************************************//**
         * \fn  public OwnerMap()
         *
         * \brief   Default constructor
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        public OwnerMap()
        {
            ToTable("Owner");
            HasKey(x => x.Id);
        }
    }
}
