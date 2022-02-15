using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace template_csharp_blog.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationContext _context;
        public CategoryController()
        {
            _context = new ApplicationContext();
        }

        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }

        public IActionResult Detail(int id)
        {
            return View(_context.Categories.Find(id));
        }
    }
}
