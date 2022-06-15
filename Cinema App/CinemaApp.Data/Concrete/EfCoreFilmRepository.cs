using CinemaApp.Data.Abstract;
using CinemaApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp.Data.Concrete
{
    public class EfCoreFilmRepository : EfCoreGenericRepository<Film>, IFilmRepository
    {
        public EfCoreFilmRepository(FilmAppContext context) : base(context)
        {

        }
        private FilmAppContext FilmAppContext
        {
            get { return _context as FilmAppContext; }
        }
    }
}