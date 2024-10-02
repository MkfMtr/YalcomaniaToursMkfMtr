using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUyrukService
    {
        Task<string> Create(Uyruk entity);
        Task<string> Update(Uyruk entity);
        Task<string> Destroy(Uyruk entity);
        List<Uyruk> GetAll();
        Uyruk GetById(int id);
    }
}
