using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents
{
    public class CommentViewComponent : ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {

            return View(cm.GetCommentListByBlog(id));
        }
       
    }
}
