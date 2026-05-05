using Maktabaty.Application.IService;
using Maktabaty.Application.ResponseContracts;
using Maktabaty.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Maktabaty.Application.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ApplicationDbContext _context;

        public CategoriesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CategoryResponse>> GetAllCategoriesAsync()
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
            
            return categories;
        }
    }
}
