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
    public class GorevService : IGorevService
    {
        private readonly IGenericRepository<Gorev> _gorevRepository;
        public GorevService(IGenericRepository<Gorev> gorevRepository)
        {
            _gorevRepository = gorevRepository;
        }
        public async Task<string> Create(Gorev entity)
        {
            return await _gorevRepository.Create(entity);
        }
        public async Task<string> Destroy(Gorev entity)
        {
            return await _gorevRepository.Destroy(entity);
        }
        public List<Gorev> GetAll()
        {
            return _gorevRepository.GetAll();
        }
        public Gorev GetById(int id)
        {
            return _gorevRepository.GetById(id);
        }
        public async Task<string> Update(Gorev entity)
        {
            return await _gorevRepository.Update(entity);
        }
    }
}
