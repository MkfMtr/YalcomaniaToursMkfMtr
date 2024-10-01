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
    public class TurService : ITurService
    {
        private readonly IGenericRepository<Tur> _turRepository;
        public TurService(IGenericRepository<Tur> turRepository)
        {
            _turRepository = turRepository;
        }

        public async Task<string> Create(Tur entity)
        {
            return await _turRepository.Create(entity);
        }

        public async Task<string> Update(Tur entity)
        {
            return await _turRepository.Update(entity);
        }

        public async Task<string> Destroy(Tur entity)
        {
            return await _turRepository.Destroy(entity);
        }

        //public async Task<string> Delete(Tur entity)
        //{
        //    try
        //    {
        //        entity.SilindiMi = true;
        //        return await _turRepository.Update(entity);
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //}

        public List<Tur> GetAll()
        {
            return _turRepository.GetAll();
        }

        public Tur GetById(int id)
        {
            return _turRepository.GetById(id);
        }
    }
}
