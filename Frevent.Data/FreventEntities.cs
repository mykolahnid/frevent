using System.Data.Entity;
using Frevent.Data.Configuration;
using Frevent.Model.Models;
using Frevent.Model.Models.Auth;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Frevent.Data
{
    public class FreventEntities : IdentityDbContext<AspNetUser>
    {
        public FreventEntities() : base("StoreEntities")
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Place> Places { get; set; }        

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });

            modelBuilder.Configurations.Add(new EventConfiguration());
            modelBuilder.Configurations.Add(new PlaceConfiguration());            
        }
    }
}