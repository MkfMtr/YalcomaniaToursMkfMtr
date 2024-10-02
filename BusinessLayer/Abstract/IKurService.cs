using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IKurService
    {
        Task<string> Create(Kur entity);
        Task<string> Update(Kur entity);
        Task<string> Destroy(Kur entity);
        List<Kur> GetAll();
        Kur GetById(int id);
    }
}
