using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly YalcoContext _context;
        private DbSet<T> _entities;
        public GenericRepository(YalcoContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public async Task<string> Create(T entity)
        {
            try
            {
                await _entities.AddAsync(entity);
                var result = await _context.SaveChangesAsync();
                if (result > 0)
                {
                    Console.WriteLine("Create Başarılı.");
                    return "Create Başarılı.";
                }
                else
                {
                    Console.WriteLine("Save Changes başarısız.");
                    return "Save Changes başarısız.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> Destroy(T entity)
        {
            _entities.Remove(entity);
            int result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return "Destroy başarılı.";
            }
            else
            {
                return "Destroy hata!";
            }
        }

        public List<T> GetAll()
        {
           return _entities.ToList();
        }

        public T GetById(int id)
        {
            try
            {
                return _entities.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<string> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return "Update başarılı.";
        }
    }
}
