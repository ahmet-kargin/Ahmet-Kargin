using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IFilmRepository Films { get; }
        ICategoryRepository Categories { get; }
        void Save();
    }
}
