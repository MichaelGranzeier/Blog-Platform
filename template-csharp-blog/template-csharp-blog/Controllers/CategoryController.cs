using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using template_csharp_blog.Models;

namespace template_csharp_blog.Controllers
{
    public class CategoryController : Controller
    {
        public BlogContext db { get; set; }
        public CategoryController(BlogContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        public IActionResult Details(int id)
        {
            return View(db.Categories.Find(id));
        }

        public IActionResult Delete(int id)
        {
            Category category = db.Categories.Find(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Delete(Category model)
        {
            db.Categories.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View(new Category());
        }
        [HttpPost]
        public IActionResult Create(Category model)
        {
            db.Categories.Add(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            return View(db.Categories.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Category model)
        {
            db.Categories.Update(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
