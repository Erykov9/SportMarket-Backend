using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportMarket_Backend.Models.DTO;
using SportMarket_Backend.Repositories.Categories;

namespace SportMarket_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categoriesDomain = await _categoryRepository.GetAllAsync();
            var categoriesDTO = _mapper.Map<List<CategoryDTO>>(categoriesDomain);
   
            return Ok(categoriesDTO);
        }
    }
}
