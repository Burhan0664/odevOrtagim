using System;

namespace Abstract
{
    public interface IService<TEntity>
    {
        void Create(TEntity T);
        void Delete(TEntity T);
        TEntity GetById(int Id);

        List<TEntity> GetAll();
        List<TEntity> GetByName(string Title);
        List<TEntity> GetByFilter(int min_price, int max_price, string Gender);
        int GetCount();
        List<TEntity> GetProductsByPage(int page = 1, int pageSize = 5);

    }
}