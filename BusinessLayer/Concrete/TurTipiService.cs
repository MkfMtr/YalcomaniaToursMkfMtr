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
    public class TurTipiService : ITurTipiService
    {
        private readonly IGenericRepository<TurTipi> _turTipiRepository;
        public TurTipiService(IGenericRepository<TurTipi> turTipiRepository)
        {
            _turTipiRepository = turTipiRepository;
        }
        public async Task<string> Create(TurTipi entity)
        {
            return await _turTipiRepository.Create(entity);
        }
        public async Task<string> Destroy(TurTipi entity)
        {
            return await _turTipiRepository.Destroy(entity);
        }
        public List<TurTipi> GetAll()
        {
            return _turTipiRepository.GetAll();
        }
        public TurTipi GetById(int id)
        {
            return _turTipiRepository.GetById(id);
        }
        public async Task<string> Update(TurTipi entity)
        {
            return await _turTipiRepository.Update(entity);
        }
    }
}
