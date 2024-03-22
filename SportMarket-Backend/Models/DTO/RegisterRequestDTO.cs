using System.ComponentModel.DataAnnotations;

namespace SportMarket_Backend.Models.DTO
{
    public class RegisterRequestDTO
    {
        [Required]
        [MinLength(4)]
        [MaxLength(18)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string[] Roles { get; set; }
    }
}
