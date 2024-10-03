using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPasVerecekService
    {
        Task<string> Create(PasVerecek entity);
        Task<string> Update(PasVerecek entity);
        Task<string> Destroy(PasVerecek entity);
        List<PasVerecek> GetAll();
        PasVerecek GetById(int id);
    }
}
