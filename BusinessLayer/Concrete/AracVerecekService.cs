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
    public class AracVerecekService : IAracVerecekService
    {
        private readonly IGenericRepository<AracVerecek> _aracVerecekRepository;
        public AracVerecekService(IGenericRepository<AracVerecek> aracVerecekRepository)
        {
            _aracVerecekRepository = aracVerecekRepository;
        }
        public async Task<string> Create(AracVerecek entity)
        {
            return await _aracVerecekRepository.Create(entity);
        }

        public async Task<string> Destroy(AracVerecek entity)
        {
            return await _aracVerecekRepository.Destroy(entity);
        }

        public List<AracVerecek> GetAll()
        {
            return _aracVerecekRepository.GetAll();
        }

        public AracVerecek GetById(int id)
        {
            return _aracVerecekRepository.GetById(id);
        }
        public async Task<string> Update(AracVerecek entity)
        {
            return await _aracVerecekRepository.Update(entity);
        }
    }
}
