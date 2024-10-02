using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISubeService
    {
        Task<string> Create(Sube entity);
        Task<string> Update(Sube entity);
        Task<string> Destroy(Sube entity);
        List<Sube> GetAll();
        Sube GetById(int id);
    }
}
