using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISirketTurTipiService
    {
        Task<string> Create(SirketTurTipi entity);
        Task<string> Update(SirketTurTipi entity);
        Task<string> Destroy(SirketTurTipi entity);
        List<SirketTurTipi> GetAll();
        SirketTurTipi GetById(int id);
    }
}
