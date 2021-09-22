using WMSPharmacy.Model;
using System.Data.Entity.Migrations;

namespace WMSPharmacy.Migrations
{
    

    internal sealed class Configuration : DbMigrationsConfiguration<WmsPharmacyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WmsPharmacyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
