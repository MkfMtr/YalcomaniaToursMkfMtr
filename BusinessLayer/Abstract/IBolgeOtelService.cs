using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBolgeOtelService
    {
        Task<string> Create(BolgeOtel entity);
        Task<string> Update(BolgeOtel entity);
        Task<string> Destroy(BolgeOtel entity);
        List<BolgeOtel> GetAll();
        BolgeOtel GetById(int id);
    }
}
