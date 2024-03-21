using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportMarket_Backend.Data;
using SportMarket_Backend.Models.Domain;
using SportMarket_Backend.Models.DTO;

namespace SportMarket_Backend.Repositories.Images
{
    public class LocalImageRepository : IImageRepository
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly SportMarketDBContext _dbContext;
        private readonly string _folderName = "Images";

        public LocalImageRepository(IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, SportMarketDBContext dbContext)
        {
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
            _dbContext = dbContext;
        }
        public async Task<Image> Upload(Image image)
        {
            var userFolderPath = Path.Combine(_webHostEnvironment.ContentRootPath, _folderName, image.FileUsername);

            if (!Directory.Exists(userFolderPath))
            {
                Directory.CreateDirectory(userFolderPath);
            }

            var localFilePath = Path.Combine(userFolderPath, $"{image.FileName}{image.FileExtension}");

            using var stream = new FileStream(localFilePath, FileMode.Create);
            await image.File.CopyToAsync(stream);

            var urlFilePath = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}{_httpContextAccessor.HttpContext.Request.PathBase}/{_folderName}/{image.FileUsername}/{image.FileName}{image.FileExtension}";

            image.FilePath = urlFilePath;

            await _dbContext.Images.AddAsync(image);
            await _dbContext.SaveChangesAsync();

            return image;
        }
    }
}
