using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfUserRepository : GenericRepository<User>, IUserDal
    {
       

        public User Login(string username, string password)
        {
            using (var c = new Context())
            {
                return c.Users.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();
            }
        }
    }
}
