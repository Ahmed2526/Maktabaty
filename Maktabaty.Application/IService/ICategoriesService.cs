using Maktabaty.Application.ResponseContracts;

namespace Maktabaty.Application.IService
{
    public interface ICategoriesService
    {
        public Task<IEnumerable<CategoryResponse>> GetAllCategoriesAsync();

       // public Task<CategoryResponse> GetCategoryByIdAsync(int id);

    }
}
