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
    public class SizeManager : ISizeService
    {
        ISizeDal _sizeDal;

        public SizeManager(ISizeDal sizeDal)
        {
            _sizeDal = sizeDal;
        }

        public void Add(Size t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Size t)
        {
            throw new NotImplementedException();
        }

        public Size GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Size> GetList()
        {
            return _sizeDal.GetListAll();
        }

        public void Update(Size t)
        {
            throw new NotImplementedException();
        }
    }
}
