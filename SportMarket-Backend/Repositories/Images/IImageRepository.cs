using SportMarket_Backend.Models.Domain;

namespace SportMarket_Backend.Repositories.Images
{
    public interface IImageRepository
    {
       Task<Image> Upload(Image image);
    }
}
