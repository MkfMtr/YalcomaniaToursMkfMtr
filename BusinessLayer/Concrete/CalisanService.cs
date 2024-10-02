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
    public class CalisanService : ICalisanService
    {
        private readonly IGenericRepository<Calisan> _calisanRepository;
        public CalisanService(IGenericRepository<Calisan> calisanRepository)
        {
            _calisanRepository = calisanRepository;
        }
        public async Task<string> Create(Calisan entity)
        {
            return await _calisanRepository.Create(entity);
        }
        public async Task<string> Destroy(Calisan entity)
        {
            return await _calisanRepository.Destroy(entity);
        }
        public List<Calisan> GetAll()
        {
            return _calisanRepository.GetAll();
        }
        public Calisan GetById(int id)
        {
            return _calisanRepository.GetById(id);
        }
        public async Task<string> Update(Calisan entity)
        {
            return await _calisanRepository.Update(entity);
        }
    }
}
