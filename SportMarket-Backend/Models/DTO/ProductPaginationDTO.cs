namespace SportMarket_Backend.Models.DTO
{
    public class ProductPaginationResponseDTO<T>
    {

        public IEnumerable<T> Products { get; set; }
        public int TotalCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
    }
}
