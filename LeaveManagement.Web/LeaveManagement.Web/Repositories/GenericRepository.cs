using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context=context;
        }
        public async Task<T> Add(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;  
        }
        public async Task Delete(int id)
        {
            var entity = await Get(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await Get(id);
            return  entity !=null;
        }

        public async Task<T?> Get(int? id)
        {
            if (id==null)
            {
                return null;
            }
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAll()
        {
            return  _context.Set<T>().ToList();
        }

        public async Task Update(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
