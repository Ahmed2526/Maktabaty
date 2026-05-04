using Microsoft.AspNetCore.Http;

namespace Maktabaty.Services.Interfaces
{
    public interface IImageService
    {
        Task<string> UploadImageAsync(IFormFile imageFile);
        Task DeleteImageAsync(string imageName);
    }
}
