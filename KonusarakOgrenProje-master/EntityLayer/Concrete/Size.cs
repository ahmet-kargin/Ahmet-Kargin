using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Size
    {
        public int SizeId { get; set; }
        public string SizeName { get; set; }
        List<ProductSize> ProductSizes { get; set; }
    }
}
