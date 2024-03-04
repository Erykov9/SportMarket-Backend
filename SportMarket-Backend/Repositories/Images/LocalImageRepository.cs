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
        private readonly IMapper _mapper;
        private readonly string _folderName = "Images";

        public LocalImageRepository(IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, SportMarketDBContext dbContext, IMapper mapper)
        {
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<Image> Upload(Image image)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(i => i.Username == image.FileUsername);

            if (user == null)
            {
                throw new Exception("User not found.");
            }

            var username = _mapper.Map<GetUsernameUserDTO>(user);
            var userFolderPath = Path.Combine(_webHostEnvironment.ContentRootPath, _folderName, username.Username);

            if (!Directory.Exists(userFolderPath))
            {
                Directory.CreateDirectory(userFolderPath);
            }

            var localFilePath = Path.Combine(userFolderPath, $"{image.FileName}{image.FileExtension}");

            using var stream = new FileStream(localFilePath, FileMode.Create);
            await image.File.CopyToAsync(stream);

            var urlFilePath = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}{_httpContextAccessor.HttpContext.Request.PathBase}/{_folderName}/{username.Username}/{image.FileName}{image.FileExtension}";

            image.FilePath = urlFilePath;

            await _dbContext.Images.AddAsync(image);
            await _dbContext.SaveChangesAsync();

            return image;
        }
    }
}
