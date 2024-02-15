using Domain.Entities.CRM;
using Infrastructure.Data;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class Reporitory<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly ApplicationDbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;

    public Reporitory(ApplicationDbContext dbContext)
    {
         _dbContext = dbContext;
         _dbSet = _dbContext.Set<TEntity>();
    }
    public async Task<TEntity> AddAsync(TEntity entity)
    {
        if (entity == null) throw new ArgumentNullException("null");
        await _dbSet.AddAsync(entity);
        return entity;
    }

    public async Task<TEntity> DeleteAsync(int id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        if (entity == null) throw new ArgumentNullException(nameof(entity));
        _dbSet.Remove(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<IQueryable<TEntity>> GetAllAsync()
    {
         var entity =  _dbSet.AsQueryable();
        return entity;
    }

    public async Task<TEntity?> GetByIdAsync(int? id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    public Task UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);
        return Task.CompletedTask;
    }
}
