using LabP320_02_04_2022.DataAccessLayer;
using LabP320_02_04_2022.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabP320_02_04_2022.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Categories = _context.Categories.Include(x => x.FlowerCategories).ToList();
            return View(Categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var dbcategory = _context.Categories.Any(x => x.Name.ToLower().Trim() == category.Name.ToLower().Trim());
            if (dbcategory)
            {
                ModelState.AddModelError("Name", "Bu adda Category movcuddur!");
                return View();
            }
            _context.Categories.Add(category);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x=>x.Id == id);
            if (category == null)
                return NotFound();

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var existCategory = await _context.Categories.FindAsync(category.Id);
            if (existCategory == null)
                return NotFound();

            bool isSameName = await _context.Categories.AnyAsync(x => x.Name.ToLower().Trim() == category.Name.ToLower().Trim());
            if (isSameName)
            {
                ModelState.AddModelError("Name", "Eyni adda category movcuddur");
                return View();
            }

            existCategory.Name = category.Name;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            Category isExist = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (isExist == null) return Json(new { status = 404 });
            _context.Categories.Remove(isExist);
            _context.SaveChanges();
            return Json(new { status = 200 });
        }
    }
}
