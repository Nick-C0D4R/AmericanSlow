using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DAL.Repositories
{
    public class TransactionRepository : IRepository<BankTransaction>
    {
        private DbSet<BankTransaction> _transactions;

        public TransactionRepository(DbSet<BankTransaction> transactions)
        {
            _transactions = transactions;
        }

        public BankTransaction Add(BankTransaction entity)
        {
            return _transactions.Add(entity);
        }

        public void Delete(int id)
        {
            _transactions.Remove(_transactions.Find(id));
        }

        public void Delete(BankTransaction entity)
        {
            _transactions.Remove(entity);
        }

        public IEnumerable<BankTransaction> GetAll()
        {
            return _transactions.ToList();
        }

        public BankTransaction GetById(int id)
        {
            return _transactions.Find(id);
        }

        public void Update(BankTransaction entity)
        {
            _transactions.AddOrUpdate(entity);
        }
    }
}
