using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGorevCalisanService
    {
        Task<string> Create(GorevCalisan entity);
        Task<string> Update(GorevCalisan entity);
        Task<string> Destroy(GorevCalisan entity);
        List<GorevCalisan> GetAll();
        GorevCalisan GetById(int id);
    }
}
