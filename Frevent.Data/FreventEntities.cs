using System.Data.Entity;
using Frevent.Data.Configuration;
using Frevent.Model.Models;

namespace Frevent.Data
{
    public class FreventEntities : DbContext
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
            modelBuilder.Configurations.Add(new EventConfiguration());
            modelBuilder.Configurations.Add(new PlaceConfiguration());
        }
    }
}