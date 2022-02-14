using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace template_csharp_blog.Controllers
{
    public class PostController : Controller
    {
        private ApplicationContext _context;
        public PostController()
        {
            _context = new ApplicationContext();
        }

        public IActionResult Index()
        {
            return View(_context.Posts.ToList());
        }

        public IActionResult ChosenIndex(int categoryId)
        {
            return View(_context.Posts.Where(post => post.CategoryId == categoryId).ToList());
        }


        public IActionResult Detail(int id)
        {
            return View(_context.Posts.Find(id));
        }
    }
}
