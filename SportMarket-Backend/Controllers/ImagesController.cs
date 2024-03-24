using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportMarket_Backend.Data;
using SportMarket_Backend.Models.Domain;
using SportMarket_Backend.Models.DTO;
using SportMarket_Backend.Repositories.Images;

namespace SportMarket_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository _imageRepository;
        private readonly UserManager<IdentityUser> _user;
        private readonly SportMarketDBContext _dBContext;

        public ImagesController(IImageRepository imageRepository, UserManager<IdentityUser> user, SportMarketDBContext dBContext)
        {
            _imageRepository = imageRepository;
            _user = user;
            _dBContext = dBContext;
        }

        [HttpPost]
        [Route("Upload")]
        [Authorize]
        public async Task<IActionResult> Upload([FromForm] AddImageRequestDTO request)
        {
            ValidateFileUpload(request);
            var user = await _user.GetUserAsync(User);


            if (ModelState.IsValid && user != null)
            {
                var userId = Guid.Parse(user.Id);
                var userToInclude = await _dBContext.Users.FirstOrDefaultAsync(x => userId == x.UserId);

                if (userToInclude == null)
                {
                    return NotFound("User doesn't exists.");
                }

                var fileName = Guid.NewGuid();

                var imageDomainModel = new Image
                {
                    File = request.File,
                    FileExtension = Path.GetExtension(request.File.FileName),
                    FileSizeInBytes = request.File.Length,
                    FileName = fileName.ToString(),
                    FileUsername = userToInclude.Username,
                    ProductId = Guid.Parse($"{request.ProductId}"),
                };

                await _imageRepository.Upload(imageDomainModel);

                return Ok(imageDomainModel);
            }

            return BadRequest(ModelState);
        }

        [HttpDelete]
        [Route("Delete/{id:guid}")]
        [Authorize]
        public async Task<IActionResult> DeleteImage([FromRoute] Guid id)
        {
            var isDeletedImage = await _imageRepository.DeleteImage(id);

            if (isDeletedImage != null)
            {
                return Ok(isDeletedImage);
            }

            return NotFound();
        }

        private void ValidateFileUpload(AddImageRequestDTO request)
        {
            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png" };

            if (!allowedExtensions.Contains(Path.GetExtension(request.File.FileName)))
            {
                ModelState.AddModelError("file", "Unsupported file extension");
            }

            if (request.File.Length > 10485760)
            {
                ModelState.AddModelError("file", "Max file size is 10MB");
            }
        }
    }
}
