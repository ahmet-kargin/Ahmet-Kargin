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
    public class SizeConfig : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasData(
                new Size { SizeId = 1, SizeName = "XS" },
                new Size { SizeId = 2, SizeName = "S" },
                new Size { SizeId = 3, SizeName = "M" },
                new Size { SizeId = 4, SizeName = "L" },
                new Size { SizeId = 5, SizeName = "XL" }
                );
        }
    }
}
