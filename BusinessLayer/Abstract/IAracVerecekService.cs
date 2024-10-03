using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAracVerecekService
    {
        Task<string> Create(AracVerecek entity);
        Task<string> Update(AracVerecek entity);
        Task<string> Destroy(AracVerecek entity);
        List<AracVerecek> GetAll();
        AracVerecek GetById(int id);
    }
}
