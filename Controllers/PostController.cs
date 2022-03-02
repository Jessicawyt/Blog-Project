using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
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
            return View(_context.Posts.OrderByDescending(p => p.PublishDate).ToList());
        }

        public IActionResult ChosenIndex(int categoryId)
        {
            ViewBag.Category = _context.Categories.Find(categoryId);
            ViewBag.CtgName = _context.Categories.Find(categoryId).Name;
            List<Post> ChosenPosts = _context.Posts.Where(post => post.CategoryId == categoryId).ToList();
            return View(ChosenPosts.OrderByDescending(p => p.PublishDate).ToList());
        }

        public IActionResult Detail(int id)
        {
            int ctgId = _context.Posts.Find(id).CategoryId;
            ViewBag.CtgImg = _context.Categories.Find(ctgId).Image;
            return View(_context.Posts.Find(id));
        }

        //Add
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            Post model = new Post();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (string.IsNullOrEmpty(post.Body) || string.IsNullOrEmpty(post.Title) || string.IsNullOrEmpty(post.Author))
            {
                ViewBag.Categories = _context.Categories.ToList();
                ViewBag.Error = "This can't be empty!";
                return View();
            }
            else
            {
                post.PublishDate = System.DateTime.Now;
                _context.Posts.Add(post);
                _context.SaveChanges();
                return RedirectToAction("Detail", new { id = post.Id });
            }

            
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
            if (string.IsNullOrEmpty(post.Body) || string.IsNullOrEmpty(post.Title) || string.IsNullOrEmpty(post.Author))
            {
                ViewBag.Categories = _context.Categories.ToList();
                ViewBag.Error = "This can't be empty!";
                return View(_context.Posts.Find(post.Id));
            }

            post.PublishDate=System.DateTime.Now;
            _context.Posts.Update(post);
            _context.SaveChanges(true);

            return RedirectToAction("Detail",new {id = post.Id});
        }

        //Delete
        public IActionResult Delete(int id)
        {
            _context.Posts.Remove(_context.Posts.Find(id));
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }

        public IActionResult AddByCtgId(int categoryId)
        {
            ViewBag.Category = _context.Categories.Find(categoryId).Name;
            Post model = new Post() { CategoryId = categoryId, Category = _context.Categories.Find(categoryId) };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddByCtgId(Post post)
        {
            if (string.IsNullOrEmpty(post.Body) || string.IsNullOrEmpty(post.Title) || string.IsNullOrEmpty(post.Author))
            {
                ViewBag.Categories = _context.Categories.ToList();
                ViewBag.Error = "This can't be empty!";
                return View();
            }
            else
            {
                post.PublishDate = System.DateTime.Now;
                _context.Posts.Add(post);
                _context.SaveChanges();
                return RedirectToAction("Detail", new { id = post.Id });
            }


        }

        public IActionResult LastPost(int id)
        {
            
            List<Post> allPosts = _context.Posts.OrderByDescending(p => p.PublishDate).ToList();

            var currentPost = allPosts.Where(p => p.Id == id).FirstOrDefault();
            
            var previousPost = allPosts.TakeWhile(n => n.Id != id).LastOrDefault();
            if (previousPost == null)
            {
                return RedirectToAction("Detail", new { id = id });
            }
            else
            {
                return RedirectToAction("Detail", new { id = previousPost.Id });
            }
            
            
            
        }

        public IActionResult NextPost(int id)
        {
            
            List<Post> allPosts = _context.Posts.OrderByDescending(p => p.PublishDate).ToList();
            var currentPost = allPosts.Where(p => p.Id == id).FirstOrDefault();
            //var nextPost = allPosts.SkipWhile(n => n.Id != allPosts.Last().Id).Skip(currentPost.Id).FirstOrDefault();
            int currentIndex = allPosts.IndexOf(currentPost);
            if (currentIndex + 1 >= allPosts.Count)
            {
                return RedirectToAction("Detail", new { id = id });
            }
            else
            {
                var nextPost = allPosts[currentIndex + 1];
                return RedirectToAction("Detail", new { id = nextPost.Id });
            }
            
            
        }
    }
}
