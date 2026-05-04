using Maktabaty.Data;
using Maktabaty.Models;
using Maktabaty.RequestContracts;
using Maktabaty.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Maktabaty.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IImageService _imageService;
        private readonly ILogger<BooksController> _logger;

        public BooksController(ApplicationDbContext context, IImageService imageService, ILogger<BooksController> logger)
        {
            _context = context;
            _imageService = imageService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var authors = await _context.Authors.ToListAsync();
            var categories = await _context.Categories.ToListAsync();

            var bookRequest = new BookRequest
            {
                Authors = new SelectList(authors, "Id", "Name"),
                Categories = new SelectList(categories, "Id", "Name"),
            };

            return View(bookRequest);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(BookRequest bookRequest)
        {
            if (!ModelState.IsValid || bookRequest.ImageUrl is null)
            {
                if (bookRequest.ImageUrl is null)
                    ModelState.AddModelError("", "Must add a poster");

                var authors = await _context.Authors.ToListAsync();
                var categories = await _context.Categories.ToListAsync();
                bookRequest.Authors = new SelectList(authors, "Id", "Name");
                bookRequest.Categories = new SelectList(categories, "Id", "Name");
                return View(bookRequest);
            }

            string imageFileName = null;

            // Handle image upload
            if (bookRequest.ImageUrl != null && bookRequest.ImageUrl.Length > 0)
            {
                try
                {
                    imageFileName = await _imageService.UploadImageAsync(bookRequest.ImageUrl);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("ImageUrl", ex.Message);

                    var authors = await _context.Authors.ToListAsync();
                    var categories = await _context.Categories.ToListAsync();
                    bookRequest.Authors = new SelectList(authors, "Id", "Name");
                    bookRequest.Categories = new SelectList(categories, "Id", "Name");
                    return View(bookRequest);
                }
            }

            var book = new Book
            {
                Title = bookRequest.Title,
                AuthorId = bookRequest.AuthorId,
                Publisher = bookRequest.Publisher,
                PublishingDate = bookRequest.PublishingDate,
                Hall = bookRequest.Hall,
                IsAvailableForRental = bookRequest.IsAvailableForRental,
                Description = bookRequest.Description,
                ImageUrl = imageFileName
            };

            book.BookCategories = bookRequest.CategoryIds.Select(categoryId => new BookCategory
            {
                CategoryId = categoryId
            }).ToList();

            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Book added successfully!";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var book = await _context.Books
                .Include(b => b.BookCategories)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
                return NotFound();

            var authors = await _context.Authors.ToListAsync();
            var categories = await _context.Categories.ToListAsync();

            var bookRequest = new BookRequest
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Publisher = book.Publisher,
                PublishingDate = book.PublishingDate,
                Hall = book.Hall,
                IsAvailableForRental = book.IsAvailableForRental,
                Description = book.Description,
                ExistingImageUrl = book.ImageUrl,
                Authors = new SelectList(authors, "Id", "Name", book.AuthorId),
                Categories = new SelectList(categories, "Id", "Name"),
                CategoryIds = book.BookCategories.Select(bc => bc.CategoryId).ToList()
            };

            return View(bookRequest);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BookRequest bookRequest)
        {
            if (id != bookRequest.Id)
                return NotFound();

            if (!ModelState.IsValid)
            {
                var authors = await _context.Authors.ToListAsync();
                var categories = await _context.Categories.ToListAsync();
                bookRequest.Authors = new SelectList(authors, "Id", "Name", bookRequest.AuthorId);
                bookRequest.Categories = new SelectList(categories, "Id", "Name");
                return View(bookRequest);
            }

            var book = await _context.Books
                .Include(b => b.BookCategories)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
                return NotFound();

            // Handle image upload if a new image is provided
            if (bookRequest.ImageUrl != null && bookRequest.ImageUrl.Length > 0)
            {
                try
                {
                    // Delete old image if exists
                    if (!string.IsNullOrEmpty(book.ImageUrl))
                    {
                        await _imageService.DeleteImageAsync(book.ImageUrl);
                    }

                    book.ImageUrl = await _imageService.UploadImageAsync(bookRequest.ImageUrl);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("ImageUrl", ex.Message);
                    var authors = await _context.Authors.ToListAsync();
                    var categories = await _context.Categories.ToListAsync();
                    bookRequest.Authors = new SelectList(authors, "Id", "Name", bookRequest.AuthorId);
                    bookRequest.Categories = new SelectList(categories, "Id", "Name");
                    return View(bookRequest);
                }
            }

            // Update book properties
            book.Title = bookRequest.Title;
            book.AuthorId = bookRequest.AuthorId;
            book.Publisher = bookRequest.Publisher;
            book.PublishingDate = bookRequest.PublishingDate;
            book.Hall = bookRequest.Hall;
            book.IsAvailableForRental = bookRequest.IsAvailableForRental;
            book.Description = bookRequest.Description;

            // Update categories
            book.BookCategories.Clear();
            book.BookCategories = bookRequest.CategoryIds.Select(categoryId => new BookCategory
            {
                BookId = book.Id,
                CategoryId = categoryId
            }).ToList();

            _context.Books.Update(book);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Book updated successfully!";

            return RedirectToAction(nameof(Index));
        }
    }
}
