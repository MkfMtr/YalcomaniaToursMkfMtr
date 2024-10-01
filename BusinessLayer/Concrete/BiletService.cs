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
    public class BiletService : IBiletService
    {
        private readonly IGenericRepository<Bilet> _biletRepository;
        public BiletService(IGenericRepository<Bilet> biletRepository)
        {
            _biletRepository = biletRepository;
        }

        public async Task<string> Create(Bilet entity)
        {
            return await _biletRepository.Create(entity);
        }

        public async Task<string> Destroy(Bilet entity)
        {
            return await _biletRepository.Destroy(entity);
        }

        public List<Bilet> GetAll()
        {
            return _biletRepository.GetAll();
        }

        public Bilet GetById(int id)
        {
            return _biletRepository.GetById(id);
        }

        public async Task<string> Update(Bilet entity)
        {
            return await _biletRepository.Update(entity);
        }
    }
}
