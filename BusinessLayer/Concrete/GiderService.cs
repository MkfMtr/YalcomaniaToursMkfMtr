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
    public class GiderService: IGiderService
    {
        private readonly IGenericRepository<Gider> _giderRepository;
        public GiderService(IGenericRepository<Gider> giderRepository)
        {
            _giderRepository = giderRepository;
        }
        public async Task<string> Create(Gider entity)
        {
            return await _giderRepository.Create(entity);
        }
        public async Task<string> Destroy(Gider entity)
        {
            return await _giderRepository.Destroy(entity);
        }
        public List<Gider> GetAll()
        {
            return _giderRepository.GetAll();
        }
        public Gider GetById(int id)
        {
            return _giderRepository.GetById(id);
        }
        public async Task<string> Update(Gider entity)
        {
            return await _giderRepository.Update(entity);
        }
    }
}
