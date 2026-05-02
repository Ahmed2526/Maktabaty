using Maktabaty.Custom_Attributes;
using Maktabaty.Data;
using Maktabaty.Models;
using Maktabaty.RequestContracts;
using Maktabaty.ResponseContracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Maktabaty.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var authors = await _context.Authors.Select(a => new AuthorResponse
            {
                Id = a.Id,
                Name = a.Name,
                IsDeleted = a.IsDeleted,
                CreatedOn = a.CreatedOn,
                UpdatedOn = a.UpdatedOn
            }).AsNoTracking()
            .ToListAsync();

            return View(authors);
        }

        [HttpGet]
        [AjaxOnly]
        public async Task<IActionResult> Add()
        {
            return PartialView("_Form");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AuthorRequest model)
        {
            if (!ModelState.IsValid)
                return PartialView("_Form", model);

            var author = new Author
            {
                Name = model.Name,
                IsDeleted = false,
                CreatedOn = DateTime.UtcNow
            };

            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();

            return Json(new
            {
                success = true,
                author = new
                {
                    id = author.Id,
                    name = author.Name,
                    createdOn = author.CreatedOn.ToString("g"),
                    updatedOn = author.UpdatedOn?.ToString("g"),
                    isDeleted = author.IsDeleted
                }
            });
        }

        [HttpGet]
        [AjaxOnly]
        public async Task<IActionResult> Edit(int id)
        {
            var author = await _context.Authors.FindAsync(id);

            if (author == null)
                return NotFound();

            var model = new AuthorRequest()
            {
                Name = author.Name
            };

            ViewBag.AuthorId = id;
            return PartialView("_Form", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AuthorRequest model)
        {
            if (!ModelState.IsValid)
                return PartialView("_Form", model);

            var author = await _context.Authors.FindAsync(id);

            if (author == null)
                return NotFound();

            author.Name = model.Name;
            author.UpdatedOn = DateTime.Now;

            _context.Authors.Update(author);
            await _context.SaveChangesAsync();

            return Json(new
            {
                success = true,
                author = new
                {
                    id = author.Id,
                    name = author.Name,
                    createdOn = author.CreatedOn.ToString("g"),
                    updatedOn = author.UpdatedOn?.ToString("g"),
                    isDeleted = author.IsDeleted
                }
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ToggleStatus(int id)
        {
            var author = await _context.Authors.FindAsync(id);

            if (author == null)
                return NotFound();

            author.IsDeleted = !author.IsDeleted;
            author.UpdatedOn = DateTime.Now;

            _context.Authors.Update(author);
            await _context.SaveChangesAsync();

            return Ok();
        }

        public async Task<IActionResult> CheckUnique(string name, int? id)
        {
            var exists = await _context.Authors
                .AnyAsync(a => a.Name == name && a.Id != id);

            return Json(!exists);
        }
    }
}
