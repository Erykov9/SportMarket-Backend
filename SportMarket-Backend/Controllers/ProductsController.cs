using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SportMarket_Backend.Data;
using SportMarket_Backend.Models.Domain;
using SportMarket_Backend.Models.DTO;
using SportMarket_Backend.Repositories.Products;
using System.Security.Claims;

namespace SportMarket_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _user;

        public ProductsController(IProductRepository productRepository, IMapper mapper, UserManager<IdentityUser> user)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _user = user;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(
            [FromQuery] string? filterOn, [FromQuery] string? filterQuery,
            [FromQuery] string? sortBy, [FromQuery] string? filterCategory,
            [FromQuery] bool isAscending = true,
            [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10
            
            )
        {
            var productsDomain = await _productRepository.GetAllAsync(filterOn, filterQuery, sortBy, filterCategory, isAscending, pageNumber, pageSize);
            var productsDTO = _mapper.Map<List<ProductDTO>>(productsDomain.Products);
            var paginatedProductsDTO = new ProductPaginationResponseDTO<ProductDTO>
            {
                Products = productsDTO,
                PageNumber = productsDomain.PageNumber,
                PageSize = productsDomain.PageSize,
                TotalCount = productsDomain.TotalCount,
            };


            return Ok(paginatedProductsDTO);
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
        [Authorize]
        public async Task<IActionResult> Create([FromBody] AddProductRequestDTO addProductDTO)
        {
            var productDomain = _mapper.Map<Product>(addProductDTO);
            var user = await _user.GetUserAsync(User);

            if(user == null)
            {
                return NotFound("Please log in.");
            }
            
            var product = await _productRepository.CreateAsync(productDomain, user);

            if(product == null)
            {
                return NotFound("User doesn't exists.");
            }

            var productDTO = _mapper.Map<ProductDTO>(productDomain);
            return Ok(productDTO);
        }


        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var deletedProductDomain = await _productRepository.DeleteAsync(id);
            if (deletedProductDomain == null)
            {
                return NotFound();
            }
            var deletedProductDTO = _mapper.Map<ProductDTO>(deletedProductDomain);

            return Ok(deletedProductDTO);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateProductRequestDTO updateProductRequestDTO)
        {
            var productDomainModel = _mapper.Map<Product>(updateProductRequestDTO);

            productDomainModel = await _productRepository.UpdateAsync(id, productDomainModel);

            if(productDomainModel == null)
            {
                return NotFound();
            }

            var productDTO = _mapper.Map<ProductDTO>(productDomainModel);

            return Ok(productDTO);
        }
    }
}
