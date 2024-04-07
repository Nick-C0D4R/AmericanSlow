using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DAL.Repositories
{
    public class ClientTypeRepository : IRepository<ClientType>
    {
        private DbSet<ClientType> _clients;

        ClientTypeRepository(DbSet<ClientType> clients)
        {
            _clients = clients;
        }

        public ClientType Add(ClientType entity)
        {
            return _clients.Add(entity);
        }

        public void Delete(int id)
        {
            Delete(_clients.Find(id));
        }

        public void Delete(ClientType entity)
        {
            _clients.Remove(entity);
        }

        public IEnumerable<ClientType> GetAll()
        {
            return _clients.ToList();
        }

        public ClientType GetById(int id)
        {
            return _clients.Find(id);
        }

        public void Update(ClientType entity)
        {
            _clients.AddOrUpdate(entity);
        }
    }
}
