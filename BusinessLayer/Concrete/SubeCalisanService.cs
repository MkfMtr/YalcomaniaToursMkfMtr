using BusinessLayer.Abstract;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubeCalisanService : ISubeCalisanService
    {
        private readonly IGenericRepository<SubeCalisan> _subeCalisanRepository;
        public SubeCalisanService(IGenericRepository<SubeCalisan> subeCalisanRepository)
        {
            _subeCalisanRepository = subeCalisanRepository;
        }
        public async Task<string> Create(SubeCalisan entity)
        {
            return await _subeCalisanRepository.Create(entity);
        }
        public async Task<string> Destroy(SubeCalisan entity)
        {
            return await _subeCalisanRepository.Destroy(entity);
        }
        public List<SubeCalisan> GetAll()
        {
            return _subeCalisanRepository.GetAll();
        }
        public SubeCalisan GetById(int id)
        {
            return _subeCalisanRepository.GetById(id);
        }
        public async Task<string> Update(SubeCalisan entity)
        {
            return await _subeCalisanRepository.Update(entity);
        }
    }
}
