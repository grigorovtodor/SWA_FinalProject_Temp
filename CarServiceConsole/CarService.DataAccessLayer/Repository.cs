namespace CarService.DataAccessLayer
{
    using Data;
    using System;
    using System.Collections.Generic;
    using DataAccessLayer.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using Models;

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        private CarServiceDbContext database = new CarServiceDbContext();

        public void Create(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity item)
        {
            throw new NotImplementedException();
        }

        public TEntity Read(int id)
        {
            return 
            var item = TEntity;
            var item = database. Currencies.FirstOrDefault(x => x.Id == id);
            return Mapping.ToCurrencyEntity(item);
        }

        public IEnumerable<TEntity> ReadAll()
        {
            var dataSet = Context.Set<TEntity>().ToList();
            var resultBusinessObjects = dataSet.Select(r => Mapping.ConvertToBusinessEntity(r));
            foreach (var item in dataSet)
            {
                var current = Mapping.ConvertToBusinessEntity(itme);
                resultBusinessObjects.Add(Mapping.ConvertToBusinessEntity(item));
            }

            return null;
        }

        public void Update(TEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
