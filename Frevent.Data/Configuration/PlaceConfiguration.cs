using System.Data.Entity.ModelConfiguration;
using Frevent.Model.Models;

namespace Frevent.Data.Configuration
{
    public class PlaceConfiguration : EntityTypeConfiguration<Place>
    {
        public PlaceConfiguration()
        {
            ToTable("Places");
            Property(p => p.Name).IsRequired();
            Property(p => p.IsDeleted).IsRequired();
        }
    }
}