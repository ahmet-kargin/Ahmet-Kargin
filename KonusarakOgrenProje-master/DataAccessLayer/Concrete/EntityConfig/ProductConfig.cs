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
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { ProductID=1,Name="Ürün1", CategoryId =1  ,Price=700,Description= "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",ColorId=1,ImageUrl="1.png",CompanyId=1,Status=true},
                new Product { ProductID=2,Name="Ürün2", CategoryId =2 , Price=600,Description= "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",ColorId=2,ImageUrl="2.png",CompanyId=1,Status=true},
                new Product { ProductID=3,Name="Ürün3", CategoryId =3 , Price=500,Description= "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",ColorId=3,ImageUrl="3.png",CompanyId=2,Status=true},
                new Product { ProductID=4,Name="Ürün4", CategoryId =4 , Price=400,Description= "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",ColorId=1,ImageUrl="4.png",CompanyId=2,Status=true},
                new Product { ProductID=5,Name="Ürün5", CategoryId =4 , Price=300,Description= "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",ColorId=2,ImageUrl="5.png",CompanyId=3,Status=true},
                new Product { ProductID=6,Name="Ürün6", CategoryId =3 , Price=200,Description= "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",ColorId=3,ImageUrl="6.png",CompanyId=4,Status=true},
                new Product { ProductID=7,Name="Ürün7", CategoryId =2 , Price=100,Description= "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",ColorId=1,ImageUrl="7.png",CompanyId=3,Status=true}
                );
        }
    }
}
