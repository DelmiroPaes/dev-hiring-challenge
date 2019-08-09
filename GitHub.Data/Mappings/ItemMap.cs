/**********************************************************************************************//**
 * \file    Mappings\ItemMap.cs.
 *
 * \brief   Implements the item map class
 **************************************************************************************************/
using GitHub.Models;
using System.Data.Entity.ModelConfiguration;

namespace GitHub.Data.Mappings
{
    /**********************************************************************************************//**
     * \class   ItemMap
     *
     * \brief   Map of items.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class ItemMap : EntityTypeConfiguration<Item>
    {
        /**********************************************************************************************//**
         * \fn  public ItemMap()
         *
         * \brief   Default constructor
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        public ItemMap()
        {
            ToTable("Item");
            HasKey(x => x.Id);
        }
    }
}
