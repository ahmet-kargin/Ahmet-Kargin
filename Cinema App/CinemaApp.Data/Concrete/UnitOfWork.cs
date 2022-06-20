using CinemaApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FilmAppContext _context;

        public UnitOfWork(FilmAppContext context)
        {
            _context = context;
        }

        private EfCoreFilmRepository _filmRepository;
        private EfCoreCategoryRepository _categoryRepository;


        public IFilmRepository Films => _filmRepository = _filmRepository ?? new EfCoreFilmRepository(_context);

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new EfCoreCategoryRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
