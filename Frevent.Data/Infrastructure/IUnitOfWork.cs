namespace Frevent.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}