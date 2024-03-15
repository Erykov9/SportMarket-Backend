using AutoMapper;
using SportMarket_Backend.Models.Domain;
using SportMarket_Backend.Models.DTO;

namespace SportMarket_Backend.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<AddProductRequestDTO, Product>().ReverseMap();
            CreateMap<UpdateProductRequestDTO, Product>().ReverseMap();
            CreateMap<Product, ProfileProductsDTO>().ReverseMap();

            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, ProfileDTO>().ReverseMap();

            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}
