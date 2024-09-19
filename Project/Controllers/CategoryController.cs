using Project.Context;
using Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Project.Controllers
{
    public class CategoryController : Controller
    {

        /*----------------------------------------------------*/
        // Context
        ProjectContext db = new ProjectContext();
        /*----------------------------------------------------*/
        [HttpGet]
        public IActionResult Index()
        {
            // DbSet of all categories 
            var _Categorys = db.Categories;
            return View(db.Categories);
        }
        /*----------------------------------------------------*/
        [HttpGet]
        public IActionResult ViewDetails(int id)
        {
            // Single Obj category
            var _Category = db.Categories.FirstOrDefault(c => c.CategoryId == id);
            return View(_Category);
        }
        
        /*-------------------------------------------------*/
        // Create - Get Method to show the form for creating a new Department (Return View)
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        /*-------------------------------------------------*/
        // Create - Post Method to Save/Add a New Department to Data Base
        [HttpPost]
        public IActionResult Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        /*-------------------------------------------------*/
        // Edit - Get Method to show the form for Editing a Department (Return View)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var oldCategory = db.Categories.Find(id);
            if (oldCategory == null)
            {
                return RedirectToAction("Index");
            }
            return View(oldCategory);
        }
        /*-------------------------------------------------*/
        // Edit - Post Method to save Changes to Data Base
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            var oldCategory = db.Categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);
            if (oldCategory == null)
            {
                return RedirectToAction("Index");
            }
            oldCategory.Name = category.Name;
            oldCategory.Description = category.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        /*-------------------------------------------------*/
        // Delete
        public IActionResult Delete(int id)
        {
            var catToDelete = db.Categories.Find(id);
            if (catToDelete == null)
            {
                return RedirectToAction("Index");
            }
            db.Categories.Remove(catToDelete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        /*-------------------------------------------------*/

    }
}
