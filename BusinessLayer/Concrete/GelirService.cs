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
    public class GelirService : IGelirService
    {
        private readonly IGenericRepository<Gelir> _gelirRepository;
        public GelirService(IGenericRepository<Gelir> gelirRepository)
        {
            _gelirRepository = gelirRepository;
        }
        public async Task<string> Create(Gelir entity)
        {
            return await _gelirRepository.Create(entity);
        }
        public async Task<string> Destroy(Gelir entity)
        {
            return await _gelirRepository.Destroy(entity);
        }
        public List<Gelir> GetAll()
        {
            return _gelirRepository.GetAll();
        }
        public Gelir GetById(int id)
        {
            return _gelirRepository.GetById(id);
        }
        public async Task<string> Update(Gelir entity)
        {
            return await _gelirRepository.Update(entity);
        }
    }
}
