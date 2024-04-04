using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SportMarket_Backend.Models.Domain;
using SportMarket_Backend.Models.DTO;
using SportMarket_Backend.Repositories.Purchases;

namespace SportMarket_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly UserManager<IdentityUser> _user;
        private readonly IMapper _mapper;

        public PurchasesController(IPurchaseRepository purchaseRepository, UserManager<IdentityUser> user, IMapper mapper)
        {
            _purchaseRepository = purchaseRepository;
            _user = user;
            _mapper = mapper;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> create([FromBody] AddPurchaseRequestDTO purchaseRequestDTO)
        {
            var purchaseDomain = _mapper.Map<Purchase>(purchaseRequestDTO);
            var user = await _user.GetUserAsync(User);

            if (user == null)
            {
                return NotFound("User doesn't exists.");
            }

            var purchase = await _purchaseRepository.AddPurchaseAsync(purchaseDomain, user);

            if (purchase == null)
            {
                return NotFound();
            }

            return Ok(purchase);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> getAll()
        {
            var user = await _user.GetUserAsync(User);

            if(user == null)
            {
                return NotFound("User doesn't exists.");
            }

            var purchases = await _purchaseRepository.GetAllAsync(user);

            return Ok(purchases);
        }

        
    }
}
