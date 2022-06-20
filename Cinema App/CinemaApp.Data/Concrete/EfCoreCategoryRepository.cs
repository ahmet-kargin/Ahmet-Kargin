using CinemaApp.Data.Abstract;
using CinemaApp.Entity;

namespace CinemaApp.Data.Concrete
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(FilmAppContext context) : base(context)
        {

        }
        private FilmAppContext FilmAppContext
        {
            get { return _context as FilmAppContext; }
        }
    }
}