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
    public class OtelService : IOtelService
    {
        private readonly IGenericRepository<Otel> _otelRepository;
        public OtelService(IGenericRepository<Otel> otelRepository)
        {
            _otelRepository = otelRepository;
        }
        public async Task<string> Create(Otel entity)
        {
            return await _otelRepository.Create(entity);
        }
        public async Task<string> Destroy(Otel entity)
        {
            return await _otelRepository.Destroy(entity);
        }
        public List<Otel> GetAll()
        {
            return _otelRepository.GetAll();
        }
        public Otel GetById(int id)
        {
            return _otelRepository.GetById(id);
        }
        public async Task<string> Update(Otel entity)
        {
            return await _otelRepository.Update(entity);
        }
    }
}
