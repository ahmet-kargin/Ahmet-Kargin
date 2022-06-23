using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        public List<Product> GetProductByCategory(int id);
        public List<Product> GetProductByCompany(int id);
        public Product GetProductDetail(int id);
        public List<Product> GetProductDetailWithAll();
        void Create(Product entity, int[] sizeIds);

    }
}
