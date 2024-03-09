﻿using AutoMapper;
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
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(
            [FromQuery] string? filterOn, [FromQuery] string? filterQuery,
            [FromQuery] string? sortBy, [FromQuery] bool isAscending = true,
            [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10
            )
        {
            var productsDomain = await _productRepository.GetAllAsync(filterOn, filterQuery, sortBy, isAscending, pageNumber, pageSize);
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
