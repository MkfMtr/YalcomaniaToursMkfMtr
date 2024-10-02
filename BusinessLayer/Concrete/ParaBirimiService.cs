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
    public class ParaBirimiService : IParaBirimiService
    {
        private readonly IGenericRepository<ParaBirimi> _paraBirimiRepository;
        public ParaBirimiService(IGenericRepository<ParaBirimi> paraBirimiRepository)
        {
            _paraBirimiRepository = paraBirimiRepository;
        }
        public async Task<string> Create(ParaBirimi entity)
        {
            return await _paraBirimiRepository.Create(entity);
        }
        public async Task<string> Destroy(ParaBirimi entity)
        {
            return await _paraBirimiRepository.Destroy(entity);
        }
        public List<ParaBirimi> GetAll()
        {
            return _paraBirimiRepository.GetAll();
        }
        public ParaBirimi GetById(int id)
        {
            return _paraBirimiRepository.GetById(id);
        }
        public async Task<string> Update(ParaBirimi entity)
        {
            return await _paraBirimiRepository.Update(entity);
        }
    }
}
