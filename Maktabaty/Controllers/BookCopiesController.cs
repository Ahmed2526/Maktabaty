using Maktabaty.Application.RequestContracts;
using Maktabaty.Custom_Attributes;
using Maktabaty.Domain.Entities;
using Maktabaty.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Maktabaty.Web.Controllers
{
    [Authorize]
    public class BookCopiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookCopiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AjaxOnly]
        public async Task<IActionResult> Add(int bookId)
        {
            var book = await _context.Books.FindAsync(bookId);
            if (book == null)
                return NotFound();

            return PartialView("Form", new BookCopiesRequest { BookId = bookId });
        }

        [HttpPost]
        [AjaxOnly]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(BookCopiesRequest bookRequest)
        {
            if (!ModelState.IsValid)
                return PartialView("Form", new BookCopiesRequest { BookId = bookRequest.BookId });

            var bookCopy = new BookCopy
            {
                BookId = bookRequest.BookId,
                EditionNumber = bookRequest.EditionNumber,
                IsAvailableForRental = bookRequest.IsAvailableForRental,
                CreatedOn = DateTime.UtcNow,
                IsDeleted = false
            };

            await _context.BookCopies.AddAsync(bookCopy);
            await _context.SaveChangesAsync();

            return Json(new
            {
                success = true,
                copy = new
                {
                    bookCopy.Id,
                    bookCopy.SerialNumber,
                    bookCopy.EditionNumber,
                    bookCopy.IsAvailableForRental,
                    bookCopy.IsDeleted
                }
            });
        }

        [HttpGet]
        [AjaxOnly]
        public async Task<IActionResult> Edit(int id)
        {
            var copy = await _context.BookCopies.FindAsync(id);
            if (copy == null)
                return NotFound();

            ViewBag.CopyId = id;
            return PartialView("Form", new BookCopiesRequest
            {
                BookId = copy.BookId,
                EditionNumber = copy.EditionNumber,
                IsAvailableForRental = copy.IsAvailableForRental
            });
        }

        [HttpPost]
        [AjaxOnly]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BookCopiesRequest bookRequest)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.CopyId = id;
                return PartialView("Form", bookRequest);
            }

            var copy = await _context.BookCopies.FindAsync(id);
            if (copy == null)
                return NotFound();

            copy.EditionNumber = bookRequest.EditionNumber;
            copy.IsAvailableForRental = bookRequest.IsAvailableForRental;
            copy.UpdatedOn = DateTime.UtcNow;

            _context.BookCopies.Update(copy);
            await _context.SaveChangesAsync();

            return Json(new
            {
                success = true,
                copy = new
                {
                    copy.Id,
                    copy.SerialNumber,
                    copy.EditionNumber,
                    copy.IsAvailableForRental,
                    copy.IsDeleted
                }
            });
        }

        [HttpPost]
        [AjaxOnly]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ToggleStatus(int id)
        {
            var copy = await _context.BookCopies.FindAsync(id);
            if (copy == null)
                return NotFound();

            copy.IsDeleted = !copy.IsDeleted;
            copy.UpdatedOn = DateTime.UtcNow;

            _context.BookCopies.Update(copy);
            await _context.SaveChangesAsync();

            return Json(new { success = true, isDeleted = copy.IsDeleted });
        }
    }
}