using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISirketService
    {
        Task<string> Create(Sirket entity);
        Task<string> Update(Sirket entity);
        Task<string> Destroy(Sirket entity);
        List<Sirket> GetAll();
        Sirket GetById(int id);

    }
}
