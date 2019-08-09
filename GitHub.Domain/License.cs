/**********************************************************************************************//**
 * \file    Z:\Prj\Delmiro\Ateliware\dev-hiring-challenge\dev-hiring-
 *          challenge\GitHub.Domain\License.cs.
 *
 * \brief   Implements the license class
 **************************************************************************************************/
namespace GitHub.Models
{
    /**********************************************************************************************//**
     * \class   License
     *
     * \brief   A license.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class License
    {
        /**********************************************************************************************//**
         * \property    public int Id
         *
         * \brief   Gets or sets the identifier
         *
         * \returns The identifier.
         **************************************************************************************************/
        public int Id { get; set; }


        /**********************************************************************************************//**
         * \property    public string Key
         *
         * \brief   Gets or sets the key
         *
         * \returns The key.
         **************************************************************************************************/
        public string Key { get; set; }


        /**********************************************************************************************//**
         * \property    public string Name
         *
         * \brief   Gets or sets the name
         *
         * \returns The name.
         **************************************************************************************************/
        public string Name { get; set; }


        /**********************************************************************************************//**
         * \property    public string Spdx_id
         *
         * \brief   Gets or sets the identifier of the spdx
         *
         * \returns The identifier of the spdx.
         **************************************************************************************************/
        public string Spdx_id { get; set; }


        /**********************************************************************************************//**
         * \property    public string Url
         *
         * \brief   Gets or sets URL of the document
         *
         * \returns The URL.
         **************************************************************************************************/
        public string Url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Node_id
         *
         * \brief   Gets or sets the identifier of the node
         *
         * \returns The identifier of the node.
         **************************************************************************************************/
        public string Node_id { get; set; }
    }
}
