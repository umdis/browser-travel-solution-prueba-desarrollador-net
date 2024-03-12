using BrowserTravel.MilesCarRental.Core.Entities;
using BrowserTravel.MilesCarRental.Core.Interfaces.Repositories;

namespace BrowserTravel.MilesCarRental.Core.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<TEntity> repository<TEntity>() where TEntity : BaseEntity;
    Task<int> Complete();
}