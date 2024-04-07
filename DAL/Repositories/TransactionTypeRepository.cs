using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DAL.Repositories
{
    public class TransactionTypeRepository : IRepository<TransactionType>
    {
        private DbSet<TransactionType> _types;

        public TransactionTypeRepository(DbSet<TransactionType> types)
        {
            _types = types;
        }

        public TransactionType Add(TransactionType entity)
        {
            return _types.Add(entity);
        }

        public void Delete(int id)
        {
            _types.Remove(_types.Find(id));
        }

        public void Delete(TransactionType entity)
        {
            _types.Remove(entity);
        }

        public IEnumerable<TransactionType> GetAll()
        {
            return _types.ToList();
        }

        public TransactionType GetById(int id)
        {
            return _types.Find(id);
        }

        public void Update(TransactionType entity)
        {
            _types.AddOrUpdate(entity);
        }
    }
}
