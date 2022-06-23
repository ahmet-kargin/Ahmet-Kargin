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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product t)
        {
            throw new NotImplementedException();
        }

        public void Create(Product entity, int[] sizeIds)
        {
            _productDal.Create(entity, sizeIds);
        }

        public void Delete(Product t)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            return _productDal.GetListAll();
        }

        public List<Product> GetProductByCategory(int id)
        {
            return _productDal.GetProductByCategory(id);
        }
        public List<Product> GetProductByCompany(int id)
        {
            return _productDal.GetProductByCompany(id);
        }
        public Product GetProductDetail(int id)
        {
            
                return _productDal.GetProductDetail(id);
        }

        public List<Product> GetProductDetailWithAll()
        {
            return _productDal.GetProductDetailWithAll();
        }

        public void Update(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
