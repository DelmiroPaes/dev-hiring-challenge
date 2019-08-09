/**********************************************************************************************//**
 * \file    Migrations\Configuration.cs.
 *
 * \brief   Implements the configuration class
 **************************************************************************************************/
namespace GitHub.Data.Migrations
{
    using System.Data.Entity.Migrations;


    /**********************************************************************************************//**
     * \class   Configuration
     *
     * \brief   A configuration. This class cannot be inherited..
     *
     * \author  Delmiro Paes
     **************************************************************************************************/
    internal sealed class Configuration : DbMigrationsConfiguration<GitHub.Data.GitHubDataContexts.GitHubDataContext>
    {
        /**********************************************************************************************//**
         * \fn  public Configuration()
         *
         * \brief   Default constructor
         *
         * \author  Delmiro Paes
         **************************************************************************************************/
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

            Seed(null);

            //Database.SetInitializer(new DropCreateDatabaseAlways < CodeFirstContext > ()); 
        }


        /**********************************************************************************************//**
         * \fn  protected override void Seed(GitHub.Data.GitHubDataContexts.GitHubDataContext context)
         *
         * \brief   Runs after upgrading to the latest migration to allow seed data to be updated.
         *
         * \author  Delmiro Paes
         *
         * \param   context Context to be used for updating seed data.
         **************************************************************************************************/
        protected override void Seed(GitHub.Data.GitHubDataContexts.GitHubDataContext context)
        {
            if (context == null)
            {
                return;
            }

            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
