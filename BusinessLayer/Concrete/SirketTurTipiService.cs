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
    public class SirketTurTipiService : ISirketTurTipiService
    {
        private readonly IGenericRepository<SirketTurTipi> _sirketTurTipiRepository;
        public SirketTurTipiService(IGenericRepository<SirketTurTipi> sirketTurTipiRepository)
        {
            _sirketTurTipiRepository = sirketTurTipiRepository;
        }
        public async Task<string> Create(SirketTurTipi entity)
        {
            return await _sirketTurTipiRepository.Create(entity);
        }
        public async Task<string> Destroy(SirketTurTipi entity)
        {
            return await _sirketTurTipiRepository.Destroy(entity);
        }
        public List<SirketTurTipi> GetAll()
        {
            return _sirketTurTipiRepository.GetAll();
        }
        public SirketTurTipi GetById(int id)
        {
            return _sirketTurTipiRepository.GetById(id);
        }
        public async Task<string> Update(SirketTurTipi entity)
        {
            return await _sirketTurTipiRepository.Update(entity);
        }
    }
}
