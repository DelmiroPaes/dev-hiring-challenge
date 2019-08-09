/**********************************************************************************************//**
 * \file    Z:\Prj\Delmiro\Ateliware\dev-hiring-challenge\dev-hiring-
 *          challenge\GitHub.Domain\Item.cs.
 *
 * \brief   Implements the item class
 **************************************************************************************************/
using System;

namespace GitHub.Models
{
    /**********************************************************************************************//**
     * \class   Item
     *
     * \brief   An item.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class Item
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
         * \property    public string Node_id
         *
         * \brief   Gets or sets the identifier of the node
         *
         * \returns The identifier of the node.
         **************************************************************************************************/
        public string Node_id { get; set; }


        /**********************************************************************************************//**
         * \property    public string Name
         *
         * \brief   Gets or sets the name
         *
         * \returns The name.
         **************************************************************************************************/
        public string Name { get; set; }


        /**********************************************************************************************//**
         * \property    public string Full_name
         *
         * \brief   Gets or sets the name of the full
         *
         * \returns The name of the full.
         **************************************************************************************************/
        public string Full_name { get; set; }


        /**********************************************************************************************//**
         * \property    public bool Private
         *
         * \brief   Gets or sets a value indicating whether the private
         *
         * \returns True if private, false if not.
         **************************************************************************************************/
        public bool Private { get; set; }


        /**********************************************************************************************//**
         * \property    public virtual Owner Owner
         *
         * \brief   Gets or sets the owner
         *
         * \returns The owner.
         **************************************************************************************************/
        public virtual Owner Owner { get; set; }


        /**********************************************************************************************//**
         * \property    public string Html_url
         *
         * \brief   Gets or sets URL of the HTML
         *
         * \returns The HTML URL.
         **************************************************************************************************/
        public string Html_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Description
         *
         * \brief   Gets or sets the description
         *
         * \returns The description.
         **************************************************************************************************/
        public string Description { get; set; }


        /**********************************************************************************************//**
         * \property    public bool Fork
         *
         * \brief   Gets or sets a value indicating whether the fork
         *
         * \returns True if fork, false if not.
         **************************************************************************************************/
        public bool Fork { get; set; }


        /**********************************************************************************************//**
         * \property    public string Url
         *
         * \brief   Gets or sets URL of the document
         *
         * \returns The URL.
         **************************************************************************************************/
        public string Url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Forks_url
         *
         * \brief   Gets or sets URL of the forks
         *
         * \returns The forks URL.
         **************************************************************************************************/
        public string Forks_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Keys_url
         *
         * \brief   Gets or sets URL of the keys
         *
         * \returns The keys URL.
         **************************************************************************************************/
        public string Keys_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Collaborators_url
         *
         * \brief   Gets or sets URL of the collaborators
         *
         * \returns The collaborators URL.
         **************************************************************************************************/
        public string Collaborators_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Teams_url
         *
         * \brief   Gets or sets URL of the teams
         *
         * \returns The teams URL.
         **************************************************************************************************/
        public string Teams_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Hooks_url
         *
         * \brief   Gets or sets URL of the hooks
         *
         * \returns The hooks URL.
         **************************************************************************************************/
        public string Hooks_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Issue_events_url
         *
         * \brief   Gets or sets URL of the issue events
         *
         * \returns The issue events URL.
         **************************************************************************************************/
        public string Issue_events_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Events_url
         *
         * \brief   Gets or sets URL of the events
         *
         * \returns The events URL.
         **************************************************************************************************/
        public string Events_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Assignees_url
         *
         * \brief   Gets or sets URL of the assignees
         *
         * \returns The assignees URL.
         **************************************************************************************************/
        public string Assignees_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Branches_url
         *
         * \brief   Gets or sets URL of the branches
         *
         * \returns The branches URL.
         **************************************************************************************************/
        public string Branches_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Tags_url
         *
         * \brief   Gets or sets URL of the tags
         *
         * \returns The tags URL.
         **************************************************************************************************/
        public string Tags_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Blobs_url
         *
         * \brief   Gets or sets URL of the blobs
         *
         * \returns The blobs URL.
         **************************************************************************************************/
        public string Blobs_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Git_tags_url
         *
         * \brief   Gets or sets URL of the git tags
         *
         * \returns The git tags URL.
         **************************************************************************************************/
        public string Git_tags_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Git_refs_url
         *
         * \brief   Gets or sets URL of the git references
         *
         * \returns The git references URL.
         **************************************************************************************************/
        public string Git_refs_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Trees_url
         *
         * \brief   Gets or sets URL of the trees
         *
         * \returns The trees URL.
         **************************************************************************************************/
        public string Trees_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Statuses_url
         *
         * \brief   Gets or sets URL of the statuses
         *
         * \returns The statuses URL.
         **************************************************************************************************/
        public string Statuses_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Languages_url
         *
         * \brief   Gets or sets URL of the languages
         *
         * \returns The languages URL.
         **************************************************************************************************/
        public string Languages_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Stargazers_url
         *
         * \brief   Gets or sets URL of the stargazers
         *
         * \returns The stargazers URL.
         **************************************************************************************************/
        public string Stargazers_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Contributors_url
         *
         * \brief   Gets or sets URL of the contributors
         *
         * \returns The contributors URL.
         **************************************************************************************************/
        public string Contributors_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Subscribers_url
         *
         * \brief   Gets or sets URL of the subscribers
         *
         * \returns The subscribers URL.
         **************************************************************************************************/
        public string Subscribers_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Subscription_url
         *
         * \brief   Gets or sets URL of the subscription
         *
         * \returns The subscription URL.
         **************************************************************************************************/
        public string Subscription_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Commits_url
         *
         * \brief   Gets or sets URL of the commits
         *
         * \returns The commits URL.
         **************************************************************************************************/
        public string Commits_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Git_commits_url
         *
         * \brief   Gets or sets URL of the git commits
         *
         * \returns The git commits URL.
         **************************************************************************************************/
        public string Git_commits_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Comments_url
         *
         * \brief   Gets or sets URL of the comments
         *
         * \returns The comments URL.
         **************************************************************************************************/
        public string Comments_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Issue_comment_url
         *
         * \brief   Gets or sets URL of the issue comment
         *
         * \returns The issue comment URL.
         **************************************************************************************************/
        public string Issue_comment_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Contents_url
         *
         * \brief   Gets or sets URL of the contents
         *
         * \returns The contents URL.
         **************************************************************************************************/
        public string Contents_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Compare_url
         *
         * \brief   Gets or sets URL of the compare
         *
         * \returns The compare URL.
         **************************************************************************************************/
        public string Compare_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Merges_url
         *
         * \brief   Gets or sets URL of the merges
         *
         * \returns The merges URL.
         **************************************************************************************************/
        public string Merges_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Archive_url
         *
         * \brief   Gets or sets URL of the archive
         *
         * \returns The archive URL.
         **************************************************************************************************/
        public string Archive_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Downloads_url
         *
         * \brief   Gets or sets URL of the downloads
         *
         * \returns The downloads URL.
         **************************************************************************************************/
        public string Downloads_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Issues_url
         *
         * \brief   Gets or sets URL of the issues
         *
         * \returns The issues URL.
         **************************************************************************************************/
        public string Issues_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Pulls_url
         *
         * \brief   Gets or sets URL of the pulls
         *
         * \returns The pulls URL.
         **************************************************************************************************/
        public string Pulls_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Milestones_url
         *
         * \brief   Gets or sets URL of the milestones
         *
         * \returns The milestones URL.
         **************************************************************************************************/
        public string Milestones_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Notifications_url
         *
         * \brief   Gets or sets URL of the notifications
         *
         * \returns The notifications URL.
         **************************************************************************************************/
        public string Notifications_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Labels_url
         *
         * \brief   Gets or sets URL of the labels
         *
         * \returns The labels URL.
         **************************************************************************************************/
        public string Labels_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Releases_url
         *
         * \brief   Gets or sets URL of the releases
         *
         * \returns The releases URL.
         **************************************************************************************************/
        public string Releases_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Deployments_url
         *
         * \brief   Gets or sets URL of the deployments
         *
         * \returns The deployments URL.
         **************************************************************************************************/
        public string Deployments_url { get; set; }


        /**********************************************************************************************//**
         * \property    public DateTime Created_at
         *
         * \brief   Gets or sets the Date/Time of the created at
         *
         * \returns The created at.
         **************************************************************************************************/
        public DateTime Created_at { get; set; }


        /**********************************************************************************************//**
         * \property    public DateTime Updated_at
         *
         * \brief   Gets or sets the Date/Time of the updated at
         *
         * \returns The updated at.
         **************************************************************************************************/
        public DateTime Updated_at { get; set; }


        /**********************************************************************************************//**
         * \property    public DateTime Pushed_at
         *
         * \brief   Gets or sets the Date/Time of the pushed at
         *
         * \returns The pushed at.
         **************************************************************************************************/
        public DateTime Pushed_at { get; set; }


        /**********************************************************************************************//**
         * \property    public string Git_url
         *
         * \brief   Gets or sets URL of the git
         *
         * \returns The git URL.
         **************************************************************************************************/
        public string Git_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Ssh_url
         *
         * \brief   Gets or sets URL of the SSH
         *
         * \returns The SSH URL.
         **************************************************************************************************/
        public string Ssh_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Clone_url
         *
         * \brief   Gets or sets URL of the clone
         *
         * \returns The clone URL.
         **************************************************************************************************/
        public string Clone_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Svn_url
         *
         * \brief   Gets or sets URL of the svn
         *
         * \returns The svn URL.
         **************************************************************************************************/
        public string Svn_url { get; set; }


        /**********************************************************************************************//**
         * \property    public string Homepage
         *
         * \brief   Gets or sets the homepage
         *
         * \returns The homepage.
         **************************************************************************************************/
        public string Homepage { get; set; }


        /**********************************************************************************************//**
         * \property    public int Size
         *
         * \brief   Gets or sets the size
         *
         * \returns The size.
         **************************************************************************************************/
        public int Size { get; set; }


        /**********************************************************************************************//**
         * \property    public int Stargazers_count
         *
         * \brief   Gets or sets the number of stargazers
         *
         * \returns The number of stargazers.
         **************************************************************************************************/
        public int Stargazers_count { get; set; }


        /**********************************************************************************************//**
         * \property    public int Watchers_count
         *
         * \brief   Gets or sets the number of watchers
         *
         * \returns The number of watchers.
         **************************************************************************************************/
        public int Watchers_count { get; set; }


        /**********************************************************************************************//**
         * \property    public string Language
         *
         * \brief   Gets or sets the language
         *
         * \returns The language.
         **************************************************************************************************/
        public string Language { get; set; }


        /**********************************************************************************************//**
         * \property    public bool Has_issues
         *
         * \brief   Gets or sets a value indicating whether this object has issues
         *
         * \returns True if this object has issues, false if not.
         **************************************************************************************************/
        public bool Has_issues { get; set; }


        /**********************************************************************************************//**
         * \property    public bool Has_projects
         *
         * \brief   Gets or sets a value indicating whether this object has projects
         *
         * \returns True if this object has projects, false if not.
         **************************************************************************************************/
        public bool Has_projects { get; set; }


        /**********************************************************************************************//**
         * \property    public bool Has_downloads
         *
         * \brief   Gets or sets a value indicating whether this object has downloads
         *
         * \returns True if this object has downloads, false if not.
         **************************************************************************************************/
        public bool Has_downloads { get; set; }


        /**********************************************************************************************//**
         * \property    public bool Has_wiki
         *
         * \brief   Gets or sets a value indicating whether this object has wiki
         *
         * \returns True if this object has wiki, false if not.
         **************************************************************************************************/
        public bool Has_wiki { get; set; }


        /**********************************************************************************************//**
         * \property    public bool Has_pages
         *
         * \brief   Gets or sets a value indicating whether this object has pages
         *
         * \returns True if this object has pages, false if not.
         **************************************************************************************************/
        public bool Has_pages { get; set; }


        /**********************************************************************************************//**
         * \property    public int Forks_count
         *
         * \brief   Gets or sets the number of forks
         *
         * \returns The number of forks.
         **************************************************************************************************/
        public int Forks_count { get; set; }


        /**********************************************************************************************//**
         * \property    public object Mirror_url
         *
         * \brief   Gets or sets URL of the mirror
         *
         * \returns The mirror URL.
         **************************************************************************************************/
        public object Mirror_url { get; set; }


        /**********************************************************************************************//**
         * \property    public bool Archived
         *
         * \brief   Gets or sets a value indicating whether the archived
         *
         * \returns True if archived, false if not.
         **************************************************************************************************/
        public bool Archived { get; set; }


        /**********************************************************************************************//**
         * \property    public bool Disabled
         *
         * \brief   Gets or sets a value indicating whether this object is disabled
         *
         * \returns True if disabled, false if not.
         **************************************************************************************************/
        public bool Disabled { get; set; }


        /**********************************************************************************************//**
         * \property    public int Open_issues_count
         *
         * \brief   Gets or sets the number of open issues
         *
         * \returns The number of open issues.
         **************************************************************************************************/
        public int Open_issues_count { get; set; }


        /**********************************************************************************************//**
         * \property    public virtual License License
         *
         * \brief   Gets or sets the license
         *
         * \returns The license.
         **************************************************************************************************/
        public virtual License License { get; set; }


        /**********************************************************************************************//**
         * \property    public int Forks
         *
         * \brief   Gets or sets the forks
         *
         * \returns The forks.
         **************************************************************************************************/
        public int Forks { get; set; }


        /**********************************************************************************************//**
         * \property    public int Open_issues
         *
         * \brief   Gets or sets the open issues
         *
         * \returns The open issues.
         **************************************************************************************************/
        public int Open_issues { get; set; }


        /**********************************************************************************************//**
         * \property    public int Watchers
         *
         * \brief   Gets or sets the watchers
         *
         * \returns The watchers.
         **************************************************************************************************/
        public int Watchers { get; set; }


        /**********************************************************************************************//**
         * \property    public string Default_branch
         *
         * \brief   Gets or sets the default branch
         *
         * \returns The default branch.
         **************************************************************************************************/
        public string Default_branch { get; set; }


        /**********************************************************************************************//**
         * \property    public double Score
         *
         * \brief   Gets or sets the score
         *
         * \returns The score.
         **************************************************************************************************/
        public double Score { get; set; }
    }
}