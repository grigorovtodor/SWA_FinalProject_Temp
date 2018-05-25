namespace CarService.DataAccessLayer.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity item);
        void Update(TEntity item);
        void Delete(TEntity item);
        void Delete(int id);
        TEntity Read(int id);
        IEnumerable<TEntity> ReadAll();
    }
}
