using System;

namespace Frevent.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        FreventEntities Init();
    }
}