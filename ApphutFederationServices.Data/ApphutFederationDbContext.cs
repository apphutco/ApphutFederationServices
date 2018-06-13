using ApphutFederationServices.Data.Entities;
using ApphutFederationServices.Data.Migrations;
using System.Data.Entity;

namespace ApphutFederationServices.Data
{
    public class ApphutFederationDbContext : DbContext
    {
        public ApphutFederationDbContext() : base("name=ApphutDbConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApphutFederationDbContext, Configuration>());
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<ApplicationInstitutionRole> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<InstitutionPayment> InstitutionPayments { get; set; }
        public DbSet<InstitutionSubsctiption> InstitutionSubsctiptions { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<SubscriptionScheme> SubscriptionSchemes { get; set; }
        public DbSet<SubscriptionType> SubscriptionTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
