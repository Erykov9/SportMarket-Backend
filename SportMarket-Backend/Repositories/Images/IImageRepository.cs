using SportMarket_Backend.Models.Domain;
using SportMarket_Backend.Models.DTO;

namespace SportMarket_Backend.Repositories.Images
{
    public interface IImageRepository
    {
        Task<Image?> Upload(Image image);
        Task<Image?> DeleteImage(Guid id);
    }
}
