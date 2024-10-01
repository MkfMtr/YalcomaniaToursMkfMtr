using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        Task<string> Create(T entity);
        Task<string> Update(T entity);
        Task<string> Destroy(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
