using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<T> where T : BaseModel
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        T Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void Delete(T entity);

    }
}
