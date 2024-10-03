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
    public class PasVerecekService : IPasVerecekService
    {
        private readonly IGenericRepository<PasVerecek> _pasVerecekRepository;
        public PasVerecekService(IGenericRepository<PasVerecek> pasVerecekRepository)
        {
            _pasVerecekRepository = pasVerecekRepository;
        }
        public async Task<string> Create(PasVerecek entity)
        {
            return await _pasVerecekRepository.Create(entity);
        }
        public async Task<string> Destroy(PasVerecek entity)
        {
            return await _pasVerecekRepository.Destroy(entity);
        }
        public List<PasVerecek> GetAll()
        {
            return _pasVerecekRepository.GetAll();
        }
        public PasVerecek GetById(int id)
        {
            return _pasVerecekRepository.GetById(id);
        }
        public async Task<string> Update(PasVerecek entity)
        {
            return await _pasVerecekRepository.Update(entity);
        }
    }
}
