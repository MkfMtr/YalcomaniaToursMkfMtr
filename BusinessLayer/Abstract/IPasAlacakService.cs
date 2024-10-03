using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPasAlacakService
    {
        Task<string> Create(PasAlacak entity);
        Task<string> Update(PasAlacak entity);
        Task<string> Destroy(PasAlacak entity);
        List<PasAlacak> GetAll();
        PasAlacak GetById(int id);
    }
}
