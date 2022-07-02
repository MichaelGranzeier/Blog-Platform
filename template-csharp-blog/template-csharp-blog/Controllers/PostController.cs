using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using template_csharp_blog.Models;

namespace template_csharp_blog.Controllers
{
    public class PostController : Controller
    {
        public BlogContext db { get; set; }
        public PostController(BlogContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        public IActionResult Details(int id)
        {
            return View(db.Posts.Find(id));
        }
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(db.Categories.ToList(), "Id", "Name");
            return View(new Post());
        }
        [HttpPost]
        public IActionResult Create(Post model)
        {
            db.Posts.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(db.Categories.ToList(), "Id", "Name");
            return  View(db.Posts.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(Post model)
        {
            db.Posts.Update(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Post post = db.Posts.Find(id);
            return View(post);
        }
        [HttpPost]
        public IActionResult Delete(Post model)
        {
            db.Posts.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
