using Microsoft.AspNetCore.Mvc;
using System.Linq;
using template_csharp_blog.Models;

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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
