using System;
using Entity;
namespace Abstract
{
    public interface IRepository<TEntity>
    {
        void Create(TEntity T);
        void Delete(TEntity T);
        TEntity GetById(int Id);

        List<TEntity> GetAll();
        TEntity GetByName(string Title);
    }
}