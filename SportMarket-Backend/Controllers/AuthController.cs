using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SportMarket_Backend.Data;
using SportMarket_Backend.Models.Domain;
using SportMarket_Backend.Models.DTO;
using SportMarket_Backend.Repositories.Auth;
using System.Text.Json;

namespace SportMarket_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _user;
        private readonly ITokenRepository _tokenRepository;
        private readonly ILogger<AuthController> _logger;
        private readonly SportMarketDBContext _dBContext;

        public AuthController(UserManager<IdentityUser> user, ITokenRepository tokenRepository, ILogger<AuthController> logger, SportMarketDBContext dBContext )
        {           
            _user = user;
            _tokenRepository = tokenRepository;
            _logger = logger;
            _dBContext = dBContext;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO registerRequestDTO)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerRequestDTO.Username,
                Email = registerRequestDTO.Email,
            };

            var identityResult = await _user.CreateAsync(identityUser, registerRequestDTO.Password);
 

            if (identityResult.Succeeded)
            {
                if(registerRequestDTO.Roles != null && registerRequestDTO.Roles.Any())
                {
                    await _user.AddToRolesAsync(identityUser, registerRequestDTO.Roles);

                    if (identityResult.Succeeded)
                    {
                        var newUser = new User()
                        {
                            Username = registerRequestDTO.Username,
                            Email = registerRequestDTO.Email,
                            UserId = Guid.Parse(identityUser.Id)
                        };

                        await _dBContext.AddAsync(newUser);
                        await _dBContext.SaveChangesAsync();

                        _logger.LogInformation($"User created: {JsonSerializer.Serialize(identityUser.Id)}");
                        return Ok($"{identityUser.UserName} was registered. You can log in now.");
                    }
                }
            }

            return BadRequest("Something went wrong.");
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginRequestDTO)
        {
            var user = await _user.FindByNameAsync(loginRequestDTO.Username);

            if (user != null)
            {
                var passwordResult = await _user.CheckPasswordAsync(user, loginRequestDTO.Password);

                if (passwordResult)
                {
                    var roles = await _user.GetRolesAsync(user);
                    if (roles != null)
                    {
                        var jwtToken = _tokenRepository.CreateJWTToken(user, roles.ToList());

                        var response = new LoginResponseDTO
                        {
                            JwtToken = jwtToken
                        };

                        return Ok(response);
                    }
                }
            }

            return BadRequest("Login or password was incorrect.");
        }
    }
}
