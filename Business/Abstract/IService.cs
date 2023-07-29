using System;

namespace Abstract
{
    public interface IService<TEntity>
    {
        void Create(TEntity T);
        void Delete(TEntity T);
        TEntity GetById(int Id);

        List<TEntity> GetAll();
        TEntity GetByName(string Title);


    }
}