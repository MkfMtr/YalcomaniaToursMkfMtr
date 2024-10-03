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
    public class PasAnlasmaService : IPasAnlasmaService
    {
        private readonly IGenericRepository<PasAnlasma> _pasAnlasmaRepository;
        public PasAnlasmaService(IGenericRepository<PasAnlasma> pasAnlasmaRepository)
        {
            _pasAnlasmaRepository = pasAnlasmaRepository;
        }
        public async Task<string> Create(PasAnlasma entity)
        {
            return await _pasAnlasmaRepository.Create(entity);
        }
        public async Task<string> Destroy(PasAnlasma entity)
        {
            return await _pasAnlasmaRepository.Destroy(entity);
        }
        public List<PasAnlasma> GetAll()
        {
            return _pasAnlasmaRepository.GetAll();
        }
        public PasAnlasma GetById(int id)
        {
            return _pasAnlasmaRepository.GetById(id);
        }
        public async Task<string> Update(PasAnlasma entity)
        {
            return await _pasAnlasmaRepository.Update(entity);
        }
    }
}
