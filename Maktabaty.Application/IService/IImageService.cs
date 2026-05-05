using Microsoft.AspNetCore.Http;

namespace Maktabaty.Application.IService
{
    public interface IImageService
    {
        Task<string> UploadImageAsync(IFormFile imageFile);
        Task DeleteImageAsync(string imageName);
    }
}

