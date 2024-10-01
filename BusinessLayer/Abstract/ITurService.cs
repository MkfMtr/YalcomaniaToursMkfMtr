using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITurService
    {
        Task<string> Create(Tur entity);
        Task<string> Update(Tur entity);
        Task<string> Destroy(Tur entity);
        //Task<string> Delete(Tur entity);
        List<Tur> GetAll();
        Tur GetById(int id);
    }
}
