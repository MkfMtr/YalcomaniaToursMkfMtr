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
    public class AracTipiService : IAracTipiService
    {
        private readonly IGenericRepository<AracTipi> _aracTipiRepository;
        public AracTipiService(IGenericRepository<AracTipi> aracTipiRepository)
        {
            _aracTipiRepository = aracTipiRepository;
        }
        public async Task<string> Create(AracTipi entity)
        {
            return await _aracTipiRepository.Create(entity);
        }

        public async Task<string> Destroy(AracTipi entity)
        {
            return await _aracTipiRepository.Destroy(entity);
        }

        public List<AracTipi> GetAll()
        {
            return _aracTipiRepository.GetAll();
        }

        public AracTipi GetById(int id)
        {
            return _aracTipiRepository.GetById(id);
        }

        public async Task<string> Update(AracTipi entity)
        {
            return await _aracTipiRepository.Update(entity);
        }
    }
}
