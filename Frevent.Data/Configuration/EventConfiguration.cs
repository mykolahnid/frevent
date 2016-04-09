using System.Data.Entity.ModelConfiguration;
using Frevent.Model.Models;

namespace Frevent.Data.Configuration
{
    public class EventConfiguration:EntityTypeConfiguration<Event>
    {
        public EventConfiguration()
        {
            ToTable("Events");
            Property(e => e.Name).IsRequired();
            HasOptional(e => e.Place).WithMany(p => p.Events);
        }
    }
}