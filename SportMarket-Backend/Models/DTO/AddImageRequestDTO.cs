using System.ComponentModel.DataAnnotations;

namespace SportMarket_Backend.Models.DTO
{
    public class AddImageRequestDTO
    {
        [Required]
        public IFormFile File { get; set; }

        [Required]
        public string FileName { get; set; }
        public string? FileDescription { get; set; }
        public string FileUsername { get; set; }
        public Guid ProductId { get; set; }
    }
}
