using System.Data.Entity;
using Frevent.Data.Configuration;
using Frevent.Data.Configuration.Auth;
using Frevent.Model.Models;
using Frevent.Model.Models.Auth;
using TestAuthentication.Models.Mapping;

namespace Frevent.Data
{
    public class FreventEntities : DbContext
    {
        public FreventEntities() : base("StoreEntities")
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<AspNetRole> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EventConfiguration());
            modelBuilder.Configurations.Add(new PlaceConfiguration());
            modelBuilder.Configurations.Add(new AspNetRoleConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserClaimConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserLoginConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserConfiguration());
        }
    }
}