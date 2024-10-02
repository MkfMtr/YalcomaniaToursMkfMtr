using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICalisanService
    {
        Task<string> Create(Calisan entity);
        Task<string> Update(Calisan entity);
        Task<string> Destroy(Calisan entity);
        List<Calisan> GetAll();
        Calisan GetById(int id);
    }
}
