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
    public class BolgeSubeService : IBolgeSubeService
    {
        private readonly IGenericRepository<BolgeSube> _bolgeSubeRepository;
        public BolgeSubeService(IGenericRepository<BolgeSube> bolgeSubeRepository)
        {
            _bolgeSubeRepository = bolgeSubeRepository;
        }
        public async Task<string> Create(BolgeSube entity)
        {
            return await _bolgeSubeRepository.Create(entity);
        }
        public async Task<string> Destroy(BolgeSube entity)
        {
            return await _bolgeSubeRepository.Destroy(entity);
        }
        public List<BolgeSube> GetAll()
        {
            return _bolgeSubeRepository.GetAll();
        }
        public BolgeSube GetById(int id)
        {
            return _bolgeSubeRepository.GetById(id);
        }
        public async Task<string> Update(BolgeSube entity)
        {
            return await _bolgeSubeRepository.Update(entity);
        }
    }
}
