using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T : class 
    {
        Task<T> Get(int? id);
        Task<List<T>> GetAll();
        Task<T> Add(T entity);

        Task<bool> Exists(int id);
        Task Delete(int id);
        Task Update(T entity);

    }
}
