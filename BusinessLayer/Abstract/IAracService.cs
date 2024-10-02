using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAracService
    {
        Task<string> Create(Arac entity);
        Task<string> Update(Arac entity);
        Task<string> Destroy(Arac entity);
        List<Arac> GetAll();
        Arac GetById(int id);
    }
}
