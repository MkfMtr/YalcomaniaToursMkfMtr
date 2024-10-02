using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAracTipiService
    {
        Task<string> Create(AracTipi entity);
        Task<string> Update(AracTipi entity);
        Task<string> Destroy(AracTipi entity);
        List<AracTipi> GetAll();
        AracTipi GetById(int id);
    }
}
