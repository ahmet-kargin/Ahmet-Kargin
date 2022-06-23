using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductSizeManager : IProductSizeService
    {
        IProductService _productService;

        public ProductSizeManager(IProductService productService)
        {
            _productService = productService;
        }

        public void Add(ProductSize t)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductSize t)
        {
            throw new NotImplementedException();
        }

        public ProductSize GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductSize> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(ProductSize t)
        {
            throw new NotImplementedException();
        }
    }
}
