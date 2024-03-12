using BrowserTravel.MilesCarRental.Core.Entities;
using BrowserTravel.MilesCarRental.Core.Interfaces.Repositories;
using BrowserTravel.MilesCarRental.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrowserTravel.MilesCarRental.Infrastructure.Data;

namespace BrowserTravel.MilesCarRental.Infrastructure.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _dbContext;

    public GenericRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public void DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        try
        {
            return await _dbContext.Set<T>().ToListAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<T> GetByIdAsync(int id)
    {
        try
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
        catch (Exception)
        {

            throw;
        }
    }
    
    public void UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
    
    //Specification Pattern
    public async Task<T> GetEntityWithSpec(ISpecifications<T> specification)
    {
        return await ApplySpecification(specification).FirstOrDefaultAsync();
    }

    public async Task<IReadOnlyList<T>> ListAsync(ISpecifications<T> specification)
    {
        return await ApplySpecification(specification).ToListAsync();
    }

    public async Task<int> CountAsync(ISpecifications<T> specifications)
    {
        return await ApplySpecification(specifications).CountAsync();
    }

    private IQueryable<T> ApplySpecification(ISpecifications<T> specifications)
    {
        return SpecificationEvaluatOr<T>.GetQuery(_dbContext.Set<T>().AsQueryable(), specifications);
    }

    public void Add(T entity)
    {
        _dbContext.Add(entity);
    }

    public void Update(T entity)
    {
        _dbContext.Attach(entity);
        _dbContext.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
    }
}