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
    public class UyrukService : IUyrukService
    {
        private readonly IGenericRepository<Uyruk> _uyrukRepository;
        public UyrukService(IGenericRepository<Uyruk> uyrukRepository)
        {
            _uyrukRepository = uyrukRepository;
        }
        public async Task<string> Create(Uyruk entity)
        {
            return await _uyrukRepository.Create(entity);
        }
        public async Task<string> Destroy(Uyruk entity)
        {
            return await _uyrukRepository.Destroy(entity);
        }
        public List<Uyruk> GetAll()
        {
            return _uyrukRepository.GetAll();
        }
        public Uyruk GetById(int id)
        {
            return _uyrukRepository.GetById(id);
        }
        public async Task<string> Update(Uyruk entity)
        {
            return await _uyrukRepository.Update(entity);
        }
    }
}
