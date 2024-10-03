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
    public class PasAlacakService : IPasAlacakService
    {
        private readonly IGenericRepository<PasAlacak> _pasAlacakRepository;
        public PasAlacakService(IGenericRepository<PasAlacak> pasAlacakRepository)
        {
            _pasAlacakRepository = pasAlacakRepository;
        }
        public async Task<string> Create(PasAlacak entity)
        {
            return await _pasAlacakRepository.Create(entity);
        }
        public async Task<string> Destroy(PasAlacak entity)
        {
            return await _pasAlacakRepository.Destroy(entity);
        }
        public List<PasAlacak> GetAll()
        {
            return _pasAlacakRepository.GetAll();
        }
        public PasAlacak GetById(int id)
        {
            return _pasAlacakRepository.GetById(id);
        }
        public async Task<string> Update(PasAlacak entity)
        {
            return await _pasAlacakRepository.Update(entity);
        }
    }
}
