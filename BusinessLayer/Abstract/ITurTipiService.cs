using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITurTipiService
    {
        Task<string> Create(TurTipi entity);
        Task<string> Update(TurTipi entity);
        Task<string> Destroy(TurTipi entity);
        List<TurTipi> GetAll();
        TurTipi GetById(int id);
    }
}
