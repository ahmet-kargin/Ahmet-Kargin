﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Color
    {
        public int ColorId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
