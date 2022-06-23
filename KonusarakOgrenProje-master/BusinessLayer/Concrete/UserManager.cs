using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User t)
        {
            throw new NotImplementedException();
        }

        public void Delete(User t)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetList()
        {
            throw new NotImplementedException();
        }

        public User Login(string username, string password)
        {
          return _userDal.Login(username, password);
        }

        public void Update(User t)
        {
            throw new NotImplementedException();
        }
    }
}
