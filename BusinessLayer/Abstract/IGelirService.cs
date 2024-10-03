using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGelirService
    {
        Task<string> Create(Gelir entity);
        Task<string> Update(Gelir entity);
        Task<string> Destroy(Gelir entity);
        List<Gelir> GetAll();
        Gelir GetById(int id);
    }
}
