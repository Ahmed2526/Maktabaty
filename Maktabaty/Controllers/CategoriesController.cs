using Maktabaty.Custom_Attributes;
using Maktabaty.Data;
using Maktabaty.Models;
using Maktabaty.RequestContracts;
using Maktabaty.ResponseContracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Maktabaty.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories
                .AsNoTracking()
                .Select(e => new CategoryResponse
                {
                    Id = e.Id,
                    Name = e.Name,
                    IsDeleted = e.IsDeleted,
                    CreatedOn = e.CreatedOn,
                    UpdatedOn = e.UpdatedOn
                }).ToListAsync();

            return View(categories);
        }

        [HttpGet]
        [AjaxOnly]
        public async Task<IActionResult> Add()
        {
            return PartialView("_Form");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(CategoryRequest model)
        {
            if (!ModelState.IsValid)
                return PartialView("_Form", model);

            var category = new Category()
            {
                Name = model.Name,
                CreatedOn = DateTime.Now,
            };

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            return Json(new
            {
                success = true,
                category = new
                {
                    id = category.Id,
                    name = category.Name,
                    createdOn = category.CreatedOn.ToString("g"),
                    updatedOn = category.UpdatedOn?.ToString("g"),
                    isDeleted = category.IsDeleted
                }
            });
        }

        [HttpGet]
        [AjaxOnly]
        public async Task<IActionResult> Edit(int id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
                return NotFound();

            var model = new CategoryRequest()
            {
                Name = category.Name
            };

            ViewBag.CategoryId = id;
            return PartialView("_Form", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CategoryRequest model)
        {
            if (!ModelState.IsValid)
                return PartialView("_Form", model);

            var category = await _context.Categories.FindAsync(id);

            if (category == null)
                return NotFound();

            category.Name = model.Name;
            category.UpdatedOn = DateTime.Now;

            _context.Categories.Update(category);
            await _context.SaveChangesAsync();

            return Json(new
            {
                success = true,
                category = new
                {
                    id = category.Id,
                    name = category.Name,
                    createdOn = category.CreatedOn.ToString("g"),
                    updatedOn = category.UpdatedOn?.ToString("g"),
                    isDeleted = category.IsDeleted
                }
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ToggleStatus(int id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
                return NotFound();

            category.IsDeleted = !category.IsDeleted;
            category.UpdatedOn = DateTime.Now;

            _context.Categories.Update(category);
            await _context.SaveChangesAsync();

            return Ok();
        }

       public async Task<IActionResult> CheckUnique(string name, int? id)
        {
            var exists = await _context.Categories
                .AnyAsync(e => e.Name == name && e.Id != id);

            return Json(!exists);
        }
    }
}