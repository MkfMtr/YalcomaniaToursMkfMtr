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
    public class GorevCalisanService : IGorevCalisanService
    {
        private readonly IGenericRepository<GorevCalisan> _gorevCalisanRepository;
        public GorevCalisanService(IGenericRepository<GorevCalisan> gorevCalisanRepository)
        {
            _gorevCalisanRepository = gorevCalisanRepository;
        }
        public async Task<string> Create(GorevCalisan entity)
        {
            return await _gorevCalisanRepository.Create(entity);
        }
        public async Task<string> Destroy(GorevCalisan entity)
        {
            return await _gorevCalisanRepository.Destroy(entity);
        }
        public List<GorevCalisan> GetAll()
        {
            return _gorevCalisanRepository.GetAll();
        }
        public GorevCalisan GetById(int id)
        {
            return _gorevCalisanRepository.GetById(id);
        }
        public async Task<string> Update(GorevCalisan entity)
        {
            return await _gorevCalisanRepository.Update(entity);
        }
    }
}
