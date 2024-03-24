using System.ComponentModel.DataAnnotations;

namespace SportMarket_Backend.Models.DTO
{
    public class AddImageRequestDTO
    {
        [Required]
        public IFormFile File { get; set; }

        [Required]
        public Guid ProductId { get; set; }
    }
}
