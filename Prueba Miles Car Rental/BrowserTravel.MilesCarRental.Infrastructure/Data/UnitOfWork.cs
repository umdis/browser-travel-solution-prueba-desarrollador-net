using BrowserTravel.MilesCarRental.Core.Entities;
using BrowserTravel.MilesCarRental.Core.Interfaces;
using BrowserTravel.MilesCarRental.Core.Interfaces.Repositories;
using BrowserTravel.MilesCarRental.Infrastructure.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserTravel.MilesCarRental.Infrastructure.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _dbContext;
    private Hashtable _repositories;

    public UnitOfWork(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> Complete()
    {
        return await _dbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }

    public IGenericRepository<TEntity> repository<TEntity>() where TEntity : BaseEntity
    {
        if (_repositories == null) _repositories = new Hashtable();
        var Type = typeof(TEntity).Name;
        if (!_repositories.ContainsKey(Type))
        {
            var repositiryType = typeof(GenericRepository<>);
            var repositoryInstance = Activator.CreateInstance(
                repositiryType.MakeGenericType(typeof(TEntity)), _dbContext);
            _repositories.Add(Type, repositoryInstance);
        }
        return (IGenericRepository<TEntity>)_repositories[Type];
    }
}