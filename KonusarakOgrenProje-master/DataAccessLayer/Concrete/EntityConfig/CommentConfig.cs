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
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment { CommentID=1, CommentTitle="Harika bir Ürün" , CommentContent="lorem ıpsum", CommentUserName="Murat Kuşcan", ProductId=1,CommentStatus=true},
                new Comment { CommentID=2, CommentTitle="Kötü bir Ürün" , CommentContent="lorem ıpsum", CommentUserName="Hakan Derkan", ProductId=1,CommentStatus=true},
                new Comment { CommentID=3, CommentTitle="Çok pahalı" , CommentContent="lorem ıpsum", CommentUserName="Berkay", ProductId=2,CommentStatus=true},
                new Comment { CommentID=4, CommentTitle="ucuz bayıldım" , CommentContent="lorem ıpsum", CommentUserName="Ahmet", ProductId=3,CommentStatus=true},
                new Comment { CommentID=5, CommentTitle="İnanılmaz" , CommentContent="lorem ıpsum", CommentUserName="Mahir", ProductId=4,CommentStatus=true},
                new Comment { CommentID=6, CommentTitle="Yırtık geldi" , CommentContent="lorem ıpsum", CommentUserName="Eren", ProductId=5,CommentStatus=true},
                new Comment { CommentID=7, CommentTitle="Bir Tanede kardeşime aldım" , CommentContent="lorem ıpsum", CommentUserName="İsmimi vermek istemiyorum", ProductId=6,CommentStatus=true}
                );
        }
    }
}
