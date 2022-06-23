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
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public void Add(Company t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Company t)
        {
            throw new NotImplementedException();
        }

        public Company GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetList()
        {
            return _companyDal.GetListAll();
        }

        public void Update(Company t)
        {
            throw new NotImplementedException();
        }
    }
}
