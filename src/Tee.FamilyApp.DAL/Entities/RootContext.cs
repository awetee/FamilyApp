using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Tee.FamilyApp.DAL.Entities;

namespace Tee.FamilyApp.DAL
{
    internal class RootContext : DbContext
    {
        public RootContext() : base("RootContext")
        {
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Link> Links { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}