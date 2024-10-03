using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGiderService
    {
        Task<string> Create(Gider entity);
        Task<string> Update(Gider entity);
        Task<string> Destroy(Gider entity);
        List<Gider> GetAll();
        Gider GetById(int id);
    }
}
