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
    public class AracService : IAracService
    {
        private readonly IGenericRepository<Arac> _aracRepository;
        public AracService(IGenericRepository<Arac> aracRepository)
        {
            _aracRepository = aracRepository;
        }
        public async Task<string> Create(Arac entity)
        {
            return await _aracRepository.Create(entity);
        }

        public async Task<string> Destroy(Arac entity)
        {
            return await _aracRepository.Destroy(entity);
        }

        public List<Arac> GetAll()
        {
            return _aracRepository.GetAll();
        }

        public Arac GetById(int id)
        {
            return _aracRepository.GetById(id);
        }

        public async Task<string> Update(Arac entity)
        {
            return await _aracRepository.Update(entity);
        }
    }
}
