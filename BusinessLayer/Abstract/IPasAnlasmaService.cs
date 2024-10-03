using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPasAnlasmaService
    {
        Task<string> Create(PasAnlasma entity);
        Task<string> Update(PasAnlasma entity);
        Task<string> Destroy(PasAnlasma entity);
        List<PasAnlasma> GetAll();
        PasAnlasma GetById(int id);
    }
}
