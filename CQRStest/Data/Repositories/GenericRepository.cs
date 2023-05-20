using CQRStest.Data.Models;
using CQRStest.Data.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace CQRStest.Data.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity>
    where TEntity : class, IEntity
{
    private readonly Context _dbContext;

    public GenericRepository(Context dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<TEntity> GetAll()
    {
        return _dbContext.Set<TEntity>();
    }

    public IQueryable<TEntity> GetAllAsNoTracking()
    {
        return _dbContext.Set<TEntity>().AsNoTracking();
    }

    public async Task<TEntity?> GetById(Guid id)
    {
        return await _dbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<TEntity?> GetByIdAsNoTracking(Guid id)
    {
        return await _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task Create(TEntity entity)
    {
        await _dbContext.Set<TEntity>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Update(Guid id, TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Delete(TEntity entity)
    {
        _dbContext.Set<TEntity>().Remove(entity);
        await _dbContext.SaveChangesAsync();
    }
}