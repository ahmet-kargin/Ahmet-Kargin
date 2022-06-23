using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string TelNo { get; set; }
        public List<Product> Products { get; set; }
    }
}
