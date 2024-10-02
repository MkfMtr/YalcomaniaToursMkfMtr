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
    public class SirketService : ISirketService
    {
        private readonly IGenericRepository<Sirket> _sirketRepository;
        public SirketService(IGenericRepository<Sirket> sirketRepository)
        {
            _sirketRepository = sirketRepository;
        }
        public async Task<string> Create(Sirket entity)
        {
            return await _sirketRepository.Create(entity);
        }
        public async Task<string> Destroy(Sirket entity)
        {
            return await _sirketRepository.Destroy(entity);
        }
        public List<Sirket> GetAll()
        {
            return _sirketRepository.GetAll();
        }
        public Sirket GetById(int id)
        {
            return _sirketRepository.GetById(id);
        }
        public async Task<string> Update(Sirket entity)
        {
            return await _sirketRepository.Update(entity);
        }
    }
}
