using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DAL.Repositories
{
    public class ClientRepository : IRepository<Client>
    {
        private DbSet<Client> _clients;

        public ClientRepository(DbSet<Client> clients)
        {
            _clients = clients;
        }

        public Client Add(Client entity)
        {
            return _clients.Add(entity);
        }

        public void Delete(int id)
        {
            _clients.Remove(_clients.Find(id));
        }

        public void Delete(Client entity)
        {
            _clients.Remove(entity);
        }

        public IEnumerable<Client> GetAll()
        {
            return _clients.ToList();
        }

        public Client GetById(int id)
        {
            return _clients.Find(id);
        }

        public void Update(Client entity)
        {
            _clients.AddOrUpdate(entity);
        }
    }
}
