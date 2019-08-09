/**********************************************************************************************//**
 * \file    Z:\Prj\Delmiro\Ateliware\dev-hiring-challenge\dev-hiring-
 *          challenge\GitHub.Domain\Owner.cs.
 *
 * \brief   Implements the owner class
 **************************************************************************************************/
namespace GitHub.Models
{
    /**********************************************************************************************//**
     * \class   Owner
     *
     * \brief   An owner.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class Owner
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
         * \property    public string Login
         *
         * \brief   Gets or sets the login
         *
         * \returns The login.
         **************************************************************************************************/
        public string Login { get; set; }


        /**********************************************************************************************//**
         * \property    public string Node_id
         *
         * \brief   Gets or sets the identifier of the node
         *
         * \returns The identifier of the node.
         **************************************************************************************************/
        public string Node_id { get; set; }


        /**********************************************************************************************//**
         * \property    public string Avatar_url
         *
         * \brief   Gets or sets URL of the avatar
         *
         * \returns The avatar URL.
         **************************************************************************************************/
        public string Avatar_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Gravatar_id
         *
         * \brief   Gets or sets the identifier of the gravatar
         *
         * \returns The identifier of the gravatar.
         **************************************************************************************************/
        public string Gravatar_id { get; set; }


        /**********************************************************************************************//**
         * \property    public string Url
         *
         * \brief   Gets or sets URL of the document
         *
         * \returns The URL.
         **************************************************************************************************/
        public string Url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Html_url
         *
         * \brief   Gets or sets URL of the HTML
         *
         * \returns The HTML URL.
         **************************************************************************************************/
        public string Html_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Followers_url
         *
         * \brief   Gets or sets URL of the followers
         *
         * \returns The followers URL.
         **************************************************************************************************/
        public string Followers_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Following_url
         *
         * \brief   Gets or sets URL of the following
         *
         * \returns The following URL.
         **************************************************************************************************/
        public string Following_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Gists_url
         *
         * \brief   Gets or sets URL of the gists
         *
         * \returns The gists URL.
         **************************************************************************************************/
        public string Gists_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Starred_url
         *
         * \brief   Gets or sets URL of the starred
         *
         * \returns The starred URL.
         **************************************************************************************************/
        public string Starred_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Subscriptions_url
         *
         * \brief   Gets or sets URL of the subscriptions
         *
         * \returns The subscriptions URL.
         **************************************************************************************************/
        public string Subscriptions_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Organizations_url
         *
         * \brief   Gets or sets URL of the organizations
         *
         * \returns The organizations URL.
         **************************************************************************************************/
        public string Organizations_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Repos_url
         *
         * \brief   Gets or sets URL of the repos
         *
         * \returns The repos URL.
         **************************************************************************************************/
        public string Repos_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Events_url
         *
         * \brief   Gets or sets URL of the events
         *
         * \returns The events URL.
         **************************************************************************************************/
        public string Events_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Received_events_url
         *
         * \brief   Gets or sets URL of the received events
         *
         * \returns The received events URL.
         **************************************************************************************************/
        public string Received_events_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Type
         *
         * \brief   Gets or sets the type
         *
         * \returns The type.
         **************************************************************************************************/
        public string Type { get; set; }


        /**********************************************************************************************//**
         * \property    public bool Site_admin
         *
         * \brief   Gets or sets a value indicating whether the site admin
         *
         * \returns True if site admin, false if not.
         **************************************************************************************************/
        public bool Site_admin { get; set; }
    }
}
