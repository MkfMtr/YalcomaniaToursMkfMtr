using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IParaBirimiService
    {
        Task<string> Create(ParaBirimi entity);
        Task<string> Update(ParaBirimi entity);
        Task<string> Destroy(ParaBirimi entity);
        List<ParaBirimi> GetAll();
        ParaBirimi GetById(int id);
    }
}
