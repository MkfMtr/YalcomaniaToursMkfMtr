using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGelirGiderKategoriService
    {
        Task<string> Create(GelirGiderKategori entity);
        Task<string> Update(GelirGiderKategori entity);
        Task<string> Destroy(GelirGiderKategori entity);
        List<GelirGiderKategori> GetAll();
        GelirGiderKategori GetById(int id);
    }
}
