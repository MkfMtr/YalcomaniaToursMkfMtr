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
    public class KurService : IKurService
    {
        private readonly IGenericRepository<Kur> _kurRepository;
        public KurService(IGenericRepository<Kur> kurRepository)
        {
            _kurRepository = kurRepository;
        }
        public async Task<string> Create(Kur entity)
        {
            return await _kurRepository.Create(entity);
        }
        public async Task<string> Destroy(Kur entity)
        {
            return await _kurRepository.Destroy(entity);
        }
        public List<Kur> GetAll()
        {
            return _kurRepository.GetAll();
        }
        public Kur GetById(int id)
        {
            return _kurRepository.GetById(id);
        }
        public async Task<string> Update(Kur entity)
        {
            return await _kurRepository.Update(entity);
        }
    }
}
