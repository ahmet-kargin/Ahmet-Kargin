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
    public class ColorConfig : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
                new Color { ColorId=1,Name="Siyah"},
                new Color { ColorId=2,Name="Beyaz"},
                new Color { ColorId=3,Name="Mavi"},
                new Color { ColorId=4,Name="Kırmızı"}
                );
        }
    }
}
