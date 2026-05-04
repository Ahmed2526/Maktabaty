using Maktabaty.Services.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Maktabaty.Services.Implementations
{
    public class ImageService : IImageService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<ImageService> _logger;
        private const string ImagesFolder = "images";
        private const long MaxFileSize = 5242880; // 5MB
        private readonly string[] AllowedExtensions = { ".jpg", ".jpeg", ".png", ".svg" };

        public ImageService(IWebHostEnvironment webHostEnvironment, ILogger<ImageService> logger)
        {
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }

        public async Task<string> UploadImageAsync(IFormFile imageFile)
        {
            if (imageFile == null || imageFile.Length == 0)
            {
                throw new ArgumentException("Image file is required", nameof(imageFile));
            }

            // Validate file size
            if (imageFile.Length > MaxFileSize)
            {
                throw new InvalidOperationException($"File size exceeds the maximum allowed size of 5MB");
            }

            // Validate file extension
            var fileExtension = Path.GetExtension(imageFile.FileName).ToLowerInvariant();
            if (!AllowedExtensions.Contains(fileExtension))
            {
                throw new InvalidOperationException($"File type '{fileExtension}' is not allowed. Allowed types: jpg, jpeg, png, svg");
            }

            try
            {
                // Create images folder if it doesn't exist
                var imagesPath = Path.Combine(_webHostEnvironment.WebRootPath, ImagesFolder);
                if (!Directory.Exists(imagesPath))
                {
                    Directory.CreateDirectory(imagesPath);
                }

                // Generate unique filename
                var uniqueFileName = $"{Guid.NewGuid()}{fileExtension}";
                var filePath = Path.Combine(imagesPath, uniqueFileName);

                // Save file to disk
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(fileStream);
                }

                _logger.LogInformation($"Image uploaded successfully: {uniqueFileName}");
                return uniqueFileName;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error uploading image: {ex.Message}");
                throw new InvalidOperationException("An error occurred while uploading the image", ex);
            }
        }

        public async Task DeleteImageAsync(string imageName)
        {
            if (string.IsNullOrEmpty(imageName))
            {
                throw new ArgumentException("Image name is required", nameof(imageName));
            }

            try
            {
                var filePath = Path.Combine(_webHostEnvironment.WebRootPath, ImagesFolder, imageName);

                // Verify file exists and is within the images folder (security check)
                var imagesPath = Path.Combine(_webHostEnvironment.WebRootPath, ImagesFolder);
                var fullPath = Path.GetFullPath(filePath);
                var fullImagesPath = Path.GetFullPath(imagesPath);

                if (!fullPath.StartsWith(fullImagesPath))
                {
                    throw new UnauthorizedAccessException("Invalid file path");
                }

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    _logger.LogInformation($"Image deleted successfully: {imageName}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error deleting image: {ex.Message}");
                throw new InvalidOperationException("An error occurred while deleting the image", ex);
            }
        }
    }
}
