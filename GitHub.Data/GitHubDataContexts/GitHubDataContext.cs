/**********************************************************************************************//**
 * \file    GitHubDataContexts\GitHubDataContext.cs.
 *
 * \brief   Implements the git hub data context class
 **************************************************************************************************/
using GitHub.Models;
using System.Data.Entity;
using System.Linq;
using GitHub.Data.Mappings;

namespace GitHub.Data.GitHubDataContexts
{
    /**********************************************************************************************//**
     * \class   GitHubDataContext
     *
     * \brief   A git hub data context.
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    public class GitHubDataContext : DbContext
    {
        /**********************************************************************************************//**
         * \fn  static GitHubDataContext()
         *
         * \brief   Static constructor
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        static GitHubDataContext()
        {
            //Database.SetInitializer<GitHubDataContext>(null);
            //Database.SetInitializer(new DropCreateDatabaseAlways < GitHubDataContext > ()); 
            Database.SetInitializer(new CreateDatabaseIfNotExists<GitHubDataContext>());
        }


        /**********************************************************************************************//**
         * \fn  public GitHubDataContext() : base("Name=GitHubSqlDBConnectionString")
         *
         * \brief   Default constructor
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        public GitHubDataContext() : base("Name=GitHubSqlDBConnectionString")
        //public GitHubDataContext() : base("GitHubSqlDBConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }


        /**********************************************************************************************//**
         * \fn  public void ClearDatabase()
         *
         * \brief   Clears the database
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        public void ClearDatabase()
        {
            var tableNames = this.Database.SqlQuery<string>("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_NAME NOT LIKE '%Migration%'").ToList();

            foreach (var tableName in tableNames)
            {
                this.Database.ExecuteSqlCommand(string.Format("DELETE FROM {0}", tableName));
            }

            this.SaveChanges();
        }


        /**********************************************************************************************//**
         * \property    public DbSet<Item> Items
         *
         * \brief   Gets or sets the items
         *
         * \returns The items.
         **************************************************************************************************/
        public DbSet<Item> Items { get; set; }


        /**********************************************************************************************//**
         * \property    public DbSet<Owner> Owners
         *
         * \brief   Gets or sets the owners
         *
         * \returns The owners.
         **************************************************************************************************/
        public DbSet<Owner> Owners { get; set; }


        /**********************************************************************************************//**
         * \property    public DbSet<License> Licenses
         *
         * \brief   Gets or sets the licenses
         *
         * \returns The licenses.
         **************************************************************************************************/
        public DbSet<License> Licenses { get; set; }


        /**********************************************************************************************//**
         * \fn  protected override void OnModelCreating(DbModelBuilder modelBuilder)
         *
         * \brief   This method is called when the model for a derived context has been initialized, but
         *          before the model has been locked down and used to initialize the context.  The
         *          default implementation of this method does nothing, but it can be overridden in a
         *          derived class such that the model can be further configured before it is locked down.
         *
         * \author  Delmiro Paes
         *
         * \param   modelBuilder    The builder that defines the model for the context being created.
         **************************************************************************************************/
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ItemMap());
            modelBuilder.Configurations.Add(new OwnerMap());
            modelBuilder.Configurations.Add(new LicenseMap());

            base.OnModelCreating(modelBuilder);
        }
    }

    //public class GitHubDataContextInit : DropCreateDatabaseIfModelChanges<GitHubDataContext>
    //{
    //}
}
