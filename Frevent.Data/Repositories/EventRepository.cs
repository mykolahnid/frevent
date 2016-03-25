using Frevent.Data.Infrastructure;
using Frevent.Model.Models;

namespace Frevent.Data.Repositories
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
        public EventRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }

    public interface IEventRepository : IRepository<Event>
    {

    }
}