using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityConfig
{
    public class ProductSizeConfig : IEntityTypeConfiguration<ProductSize>
    {

        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            builder.HasData(
                new ProductSize { ProductId = 1, SizeId = 1, Stok = 10 },
                new ProductSize { ProductId = 1, SizeId = 2, Stok = 10 },
                new ProductSize { ProductId = 1, SizeId = 3, Stok = 10 },
                new ProductSize { ProductId = 1, SizeId = 4, Stok = 10 },
                new ProductSize { ProductId = 2, SizeId = 1, Stok = 10 },
                new ProductSize { ProductId = 2, SizeId = 2, Stok = 10 },
                new ProductSize { ProductId = 2, SizeId = 3, Stok = 10 },
                new ProductSize { ProductId = 2, SizeId = 4, Stok = 10 },
                new ProductSize { ProductId = 3, SizeId = 1, Stok = 10 },
                new ProductSize { ProductId = 3, SizeId = 2, Stok = 10 },
                new ProductSize { ProductId = 3, SizeId = 3, Stok = 10 },
                new ProductSize { ProductId = 4, SizeId = 1, Stok = 10 },
                new ProductSize { ProductId = 4, SizeId = 2, Stok = 10 },
                new ProductSize { ProductId = 4, SizeId = 3, Stok = 10 },
                new ProductSize { ProductId = 4, SizeId = 4, Stok = 10 },
                new ProductSize { ProductId = 5, SizeId = 1, Stok = 10 },
                new ProductSize { ProductId = 5, SizeId = 2, Stok = 10 },
                new ProductSize { ProductId = 5, SizeId = 3, Stok = 10 },
                new ProductSize { ProductId = 5, SizeId = 4, Stok = 10 }
                );
        }

       
    }
}
