using Microsoft.AspNetCore.Mvc;
using System.Linq;
using template_csharp_blog.Models;

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

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //Edit
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _context.Categories.ToList();
            
            return View(_context.Posts.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Post post)
        {
            _context.Posts.Update(post);
            _context.SaveChanges(true);

            return RedirectToAction("Detail",new {id = post.Id});
        }



    }
}
