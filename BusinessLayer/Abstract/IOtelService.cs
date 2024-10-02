using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOtelService
    {
        Task<string> Create(Otel entity);
        Task<string> Update(Otel entity);
        Task<string> Destroy(Otel entity);
        List<Otel> GetAll();
        Otel GetById(int id);
    }
}
