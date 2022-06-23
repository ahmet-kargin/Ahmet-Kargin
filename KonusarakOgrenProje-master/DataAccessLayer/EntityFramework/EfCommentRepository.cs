using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetCommentListByBlog(int id)
        {
            using (var c =new Context())
            {
                return c.Comments.Where(x => x.ProductId == id).ToList();
            }
        }
    }
}
