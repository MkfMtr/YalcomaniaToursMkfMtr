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
    public class SubeService : ISubeService
    {
        private readonly IGenericRepository<Sube> _subeRepository;
        public SubeService(IGenericRepository<Sube> subeRepository)
        {
            _subeRepository = subeRepository;
        }
        public async Task<string> Create(Sube entity)
        {
            return await _subeRepository.Create(entity);
        }
        public async Task<string> Destroy(Sube entity)
        {
            return await _subeRepository.Destroy(entity);
        }
        public List<Sube> GetAll()
        {
            return _subeRepository.GetAll();
        }
        public Sube GetById(int id)
        {
            return _subeRepository.GetById(id);
        }
        public async Task<string> Update(Sube entity)
        {
            return await _subeRepository.Update(entity);
        }
    }
}
