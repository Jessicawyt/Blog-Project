using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using template_csharp_blog.Models;

namespace template_csharp_blog.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationContext _context;
        private readonly string ApplicationRoot = "/Users/Jessica/source/repos/m3-blog-platform-Jessicawyt/";
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
        public IActionResult Create(Category model, IFormFile CtgImg)
        {
            string uploads = Path.Combine(ApplicationRoot, "wwwroot/uploads");

            if (CtgImg == null || model.Name == null)
            {
                ViewBag.Error = "Hey, this can't be empty!";
                return View();
            }

            else /*(CtgImg.Length > 0)*/
            {
                string filePath = Path.Combine(uploads, CtgImg.FileName);
                using (Stream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    CtgImg.CopyTo(fileStream);
                }
            
            }
            try
            {
                model.Image = CtgImg.FileName;
                _context.Categories.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");   
            }
            catch (System.Exception e)
            {

               
            }

            return View();
        }

        public IActionResult Edit(int id)
        {
            return View(_context.Categories.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Category model,IFormFile CtgImg)
        {
            string uploads = Path.Combine(ApplicationRoot, "wwwroot/uploads");

            if (CtgImg == null)
            {
                Category updatedCtg = _context.Categories.Find(model.Id);
                updatedCtg.Name = model.Name; 
                _context.Categories.Update(updatedCtg);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            else /*(CtgImg.Length > 0)*/
            {
                string filePath = Path.Combine(uploads, CtgImg.FileName);
                using (Stream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    CtgImg.CopyTo(fileStream);
                }

            }

            try
            {
                model.Image = CtgImg.FileName;
                _context.Categories.Update(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (System.Exception e)
            {


            }

            return View();


        }


        public IActionResult Delete(int id)
        {
            Category model = _context.Categories.Find(id);
            _context.Categories.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
