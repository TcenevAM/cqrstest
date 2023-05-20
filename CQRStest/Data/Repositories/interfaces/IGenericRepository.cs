using CQRStest.Data.Models;

namespace CQRStest.Data.Repositories.interfaces;

public interface IGenericRepository<TEntity>
    where TEntity : class, IEntity
{
    IQueryable<TEntity> GetAll();
    IQueryable<TEntity> GetAllAsNoTracking();
    Task<TEntity?> GetById(Guid id);
    Task<TEntity?> GetByIdAsNoTracking(Guid id);
    Task Create(TEntity entity);
    Task Update(Guid id, TEntity entity);
    Task Delete(TEntity entity);
}