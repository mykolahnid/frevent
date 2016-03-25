namespace Frevent.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        FreventEntities dbContext;

        public FreventEntities Init()
        {
            return dbContext ?? (dbContext = new FreventEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}