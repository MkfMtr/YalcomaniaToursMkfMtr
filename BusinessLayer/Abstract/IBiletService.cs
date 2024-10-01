using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBiletService
    {
        Task<string> Create(Bilet entity);
        Task<string> Update(Bilet entity);
        Task<string> Destroy(Bilet entity);
        List<Bilet> GetAll();
        Bilet GetById(int id);
    }
}
