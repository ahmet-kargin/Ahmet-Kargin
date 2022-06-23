using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int CompanyId { get; set; }
        public bool Status { get; set; }
        public Company Company { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public Category Category { get; set; }
        public List<ProductSize> ProductSizes { get; set; }

    }
}
