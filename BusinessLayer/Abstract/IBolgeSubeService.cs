using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBolgeSubeService
    {
        Task<string> Create(BolgeSube entity);
        Task<string> Update(BolgeSube entity);
        Task<string> Destroy(BolgeSube entity);
        List<BolgeSube> GetAll();
        BolgeSube GetById(int id);
    }
}
