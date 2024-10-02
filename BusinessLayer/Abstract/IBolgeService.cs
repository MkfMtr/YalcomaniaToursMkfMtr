using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBolgeService
    {
        Task<string> Create(Bolge entity);
        Task<string> Update(Bolge entity);
        Task<string> Destroy(Bolge entity);
        List<Bolge> GetAll();
        Bolge GetById(int id);
    }
}
