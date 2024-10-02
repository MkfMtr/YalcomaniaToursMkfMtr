using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISubeCalisanService
    {
        Task<string> Create(SubeCalisan entity);
        Task<string> Update(SubeCalisan entity);
        Task<string> Destroy(SubeCalisan entity);
        List<SubeCalisan> GetAll();
        SubeCalisan GetById(int id);
    }
}
