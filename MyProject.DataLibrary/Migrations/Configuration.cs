namespace Identity.DataLibrary.Migrations
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Identity.DataLibrary.IdentityContext.IdentityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //SetSqlGenerator("Devart.Data.SQLite", new Devart.Data.SQLite.Entity.Migrations.SQLiteEntityMigrationSqlGenerator());

        }

        protected override void Seed(Identity.DataLibrary.IdentityContext.IdentityContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
