using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>, IProductDal
    {
        public void Create(Product entity, int[] sizeIds)
        {
            using (var context = new Context())
            {
                context.Products.Add(entity);
                context.SaveChanges();
                entity.ProductSizes = sizeIds
                    .Select(sizId => new ProductSize
                    {
                        ProductId = entity.ProductID,
                        SizeId = sizId,
                        Stok=10
                    }).ToList();
                context.SaveChanges();
            }
        }

        public List<Product> GetProductByCategory(int id)
        {
            using (var c = new Context())
            {
                var products = c.Products.Where(x => x.CategoryId== id).ToList();
                return products;
            }
        }
        public List<Product> GetProductByCompany(int id)
        {
            using (var c = new Context())
            {
                var products = c.Products.Where(x => x.CompanyId == id).ToList();
                return products;
            }
        }

        public Product GetProductDetail(int id)
        {
            using (var c = new Context())
            {
                var products = c.Products.Include(x=>x.Category).Include(x=>x.Color).Include(x=>x.Company).Where(x => x.ProductID == id).FirstOrDefault();
                return products;
            }
        }

        public List<Product> GetProductDetailWithAll()
        {
            using (var c = new Context())
            {
                var products = c.Products.Include(x => x.Category).Include(x => x.Color).Include(x => x.Company).ToList();
                return products;
            }
        }
    }
}
