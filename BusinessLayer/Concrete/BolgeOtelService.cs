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
    public class BolgeOtelService : IBolgeOtelService
    {
        private readonly IGenericRepository<BolgeOtel> _bolgeOtelRepository;
        public BolgeOtelService(IGenericRepository<BolgeOtel> bolgeOtelRepository)
        {
            _bolgeOtelRepository = bolgeOtelRepository;
        }

        public async Task<string> Create(BolgeOtel entity)
        {
            return await _bolgeOtelRepository.Create(entity);
        }

        public async Task<string> Destroy(BolgeOtel entity)
        {
            return await _bolgeOtelRepository.Destroy(entity);
        }

        public List<BolgeOtel> GetAll()
        {
            return _bolgeOtelRepository.GetAll();
        }

        public BolgeOtel GetById(int id)
        {
            return _bolgeOtelRepository.GetById(id);
        }

        public async Task<string> Update(BolgeOtel entity)
        {
            return await _bolgeOtelRepository.Update(entity);
        }
    }
}
