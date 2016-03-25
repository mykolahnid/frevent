using Frevent.Data.Infrastructure;
using Frevent.Model.Models;

namespace Frevent.Data.Repositories
{
    public class PlaceRepository : RepositoryBase<Place>, IPlaceRepository
    {
        public PlaceRepository(IDbFactory dbFactory)
            : base(dbFactory)
        { }
    }

    public interface IPlaceRepository : IRepository<Place>
    {

    }
}