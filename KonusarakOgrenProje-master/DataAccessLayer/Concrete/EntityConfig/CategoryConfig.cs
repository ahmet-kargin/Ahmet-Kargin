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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { CategoryId =1,  Name="Elbise"},
                new Category { CategoryId =2,  Name="Gömlek"},
                new Category { CategoryId =3,  Name="Tişört"},
                new Category { CategoryId =4,  Name="Kazak"}

                );
        }

       
    }
}
