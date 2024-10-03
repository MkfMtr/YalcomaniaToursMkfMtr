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
    public class GelirGiderKategoriService : IGelirGiderKategoriService
    {
        private readonly IGenericRepository<GelirGiderKategori> _gelirGiderKategoriRepository;
        public GelirGiderKategoriService(IGenericRepository<GelirGiderKategori> gelirGiderKategoriRepository)
        {
            _gelirGiderKategoriRepository = gelirGiderKategoriRepository;
        }

        public async Task<string> Create(GelirGiderKategori entity)
        {
            return await _gelirGiderKategoriRepository.Create(entity);

        }

        public async Task<string> Destroy(GelirGiderKategori entity)
        {
            return await _gelirGiderKategoriRepository.Destroy(entity);
        }

        public List<GelirGiderKategori> GetAll()
        {
            return _gelirGiderKategoriRepository.GetAll();
        }

        public GelirGiderKategori GetById(int id)
        {
            return _gelirGiderKategoriRepository.GetById(id);
        }

        public async Task<string> Update(GelirGiderKategori entity)
        {
            return await _gelirGiderKategoriRepository.Update(entity);
        }
    }
}
