using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SportMarket_Backend.Data;
using SportMarket_Backend.Models.Domain;
using SportMarket_Backend.Models.DTO;
using SportMarket_Backend.Repositories.Products;

namespace SportMarket_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly SportMarketDBContext _dbContext;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository productRepository, SportMarketDBContext dbContext, IMapper mapper)
        {
            _productRepository = productRepository;
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var productsDomain = await _productRepository.GetAllAsync();
            var productsDTO = _mapper.Map<List<ProductDTO>>(productsDomain);

            return Ok(productsDTO);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetById([FromRoute]Guid id)
        {
            var productDomain = await _productRepository.GetByIdAsync(id);

            if(productDomain == null)
            {
                return NotFound();
            }

            var productDTO = _mapper.Map<ProductDTO>(productDomain);

            return Ok(productDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddProductRequestDTO addProductDTO)
        {
            var productDomain = _mapper.Map<Product>(addProductDTO);
            await _productRepository.CreateAsync(productDomain);

            var productDTO = _mapper.Map<ProductDTO>(productDomain);
            return Ok(productDTO);
        }

    }
}
