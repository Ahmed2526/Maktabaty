using Maktabaty.Application.IService;
using Maktabaty.Application.RequestContracts;
using Maktabaty.Application.ResponseContracts;
using Maktabaty.Custom_Attributes;
using Maktabaty.Domain.Entities.Models;
using Maktabaty.Infrastructure.Data;
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

        [HttpPost]
        [AjaxOnly]
        public async Task<IActionResult> GetBooks()
        {
            var draw = Request.Form["draw"].FirstOrDefault();

            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();

            var searchValue = Request.Form["search[value]"].FirstOrDefault();
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"] + "][data]"].FirstOrDefault();
            var sortDirection = Request.Form["order[0][dir]"].FirstOrDefault();


            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;

            var query = _context.Books.Include(b => b.Author).AsQueryable();

            //sorting
            if (sortColumn == "title")
            {
                query = sortDirection == "asc"
                    ? query.OrderBy(x => x.Title)
                    : query.OrderByDescending(x => x.Title);
            }
            else if (sortColumn == "author")
            {
                query = sortDirection == "asc"
                    ? query.OrderBy(x => x.Author.Name)
                    : query.OrderByDescending(x => x.Author.Name);
            }

            else if (sortColumn == "publishingDate")
            {
                query = sortDirection == "asc"
                    ? query.OrderBy(x => x.PublishingDate)
                    : query.OrderByDescending(x => x.PublishingDate);
            }
            else
            {
                query = query.OrderBy(x => x.Id); // default sorting
            }

            // 🔍 Search
            if (!string.IsNullOrEmpty(searchValue))
            {
                query = query.Where(x =>
                    x.Title.Contains(searchValue) ||
                    x.Author.Name.Contains(searchValue));
            }

            // total count
            var recordsTotal = await query.CountAsync();

            // paging
            var data = await query
                .Skip(skip)
                .Take(pageSize)
                .Select(x => new
                {
                    id = x.Id,
                    title = x.Title,
                    author = x.Author.Name,
                    publisher = x.Publisher,
                    image = x.ImageUrl,
                    isAvailableForRental = x.IsAvailableForRental,
                    isDeleted = x.IsDeleted,
                    publishingDate = x.PublishingDate.ToString("yyyy-MM-dd")
                })
                .AsNoTracking()
                .ToListAsync();

            var response = new
            {
                draw = draw,
                recordsFiltered = recordsTotal,
                recordsTotal = recordsTotal,
                data = data
            };

            return Json(response);
        }

        [HttpPost]
        [AjaxOnly]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ToggleStatus(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
                return NotFound();

            book.IsDeleted = !book.IsDeleted;
            book.UpdatedOn = DateTime.UtcNow;

            _context.Books.Update(book);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var book = await _context.Books
                .Include(b => b.Author)
                .Include(b => b.BookCopies)
                .Include(b => b.BookCategories)
                    .ThenInclude(bc => bc.Category)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (book == null)
                return NotFound();

            var bookResponse = new BookResponse
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author.Name,
                Publisher = book.Publisher,
                PublishingDate = book.PublishingDate,
                ImageUrl = book.ImageUrl!,
                Hall = book.Hall,
                IsAvailableForRental = book.IsAvailableForRental,
                Description = book.Description,
                Categories = book.BookCategories.Select(bc => bc.Category.Name),
                Copies = book.BookCopies.Select(bc => new BookCopiesResponse
                {
                    Id = bc.Id,
                    IsAvailableForRental = bc.IsAvailableForRental,
                    CreatedOn = bc.CreatedOn,
                    SerialNumber = bc.SerialNumber,
                    EditionNumber = bc.EditionNumber,
                    UpdatedOn = bc.UpdatedOn,
                    IsDeleted = bc.IsDeleted,
                })
            };

            return View(bookResponse);
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

