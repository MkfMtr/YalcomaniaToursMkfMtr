using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGorevService
    {
        Task<string> Create(Gorev entity);
        Task<string> Update(Gorev entity);
        Task<string> Destroy(Gorev entity);
        List<Gorev> GetAll();
        Gorev GetById(int id);
    }
}
