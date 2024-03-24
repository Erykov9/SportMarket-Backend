namespace SportMarket_Backend.Models.DTO
{
    public class DeleteImageRequestDTO
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string FileExtension { get; set; }
    }
}
