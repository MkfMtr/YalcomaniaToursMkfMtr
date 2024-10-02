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
    public class BolgeService : IBolgeService
    {
        private readonly IGenericRepository<Bolge> _bolgeRepository;
        public BolgeService(IGenericRepository<Bolge> bolgeRepository)
        {
            _bolgeRepository = bolgeRepository;
        }

        public async Task<string> Create(Bolge entity)
        {
            return await _bolgeRepository.Create(entity);
        }

        public async Task<string> Destroy(Bolge entity)
        {
            return await _bolgeRepository.Destroy(entity);
        }

        public List<Bolge> GetAll()
        {
            return _bolgeRepository.GetAll();
        }

        public Bolge GetById(int id)
        {
            return _bolgeRepository.GetById(id);
        }

        public async Task<string> Update(Bolge entity)
        {
            return await _bolgeRepository.Update(entity);
        }
    }
}
