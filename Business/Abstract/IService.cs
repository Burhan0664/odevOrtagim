using System;

namespace Abstract
{
    public interface IService<TEntity>
    {
        void Create(TEntity T);
        void Delete(TEntity T);
        TEntity GetById(int Id);

        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetByName(string Title);
        IQueryable<TEntity> GetByFilter(int min_price, int max_price, string Gender);
        int GetCount();
        IQueryable<TEntity> GetProductsByPage(int page = 1, int pageSize = 5);

    }
}