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

    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color t)
        {
            throw new NotImplementedException();
        }

        public Color GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetList()
        {
            return _colorDal.GetListAll();
        }

        public void Update(Color t)
        {
            throw new NotImplementedException();
        }
    }
}
