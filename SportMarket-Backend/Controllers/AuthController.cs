using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SportMarket_Backend.Data;
using SportMarket_Backend.Models.Domain;
using SportMarket_Backend.Models.DTO;
using SportMarket_Backend.Repositories.Auth;
using System.IdentityModel.Tokens.Jwt;
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

                        var cookieOptions = new CookieOptions
                        {
                            Path = "/",
                            HttpOnly = true,
                            Secure = true,
                            SameSite = SameSiteMode.None,
                            Expires = DateTime.UtcNow.AddDays(7)
                        };

                        Response.Cookies.Append("AT", jwtToken, cookieOptions);

                        var response = new LoginResponseDTO
                        {
                            JwtToken = jwtToken
                        };

                        return Ok(response);
                    }
                }

                return NotFound(new { error = "Username or password are incorect." });
            }

            return NotFound(new { error = "Username or password are incorect."});
        }

        [HttpPost]
        [Route("Logout")]
        public IActionResult Logout()
        {
            var cookieOptions = new CookieOptions
            {
                Path = "/",
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None,
                Expires = DateTime.UtcNow.AddDays(-1)
            };

            Response.Cookies.Delete("AT", cookieOptions);
            return Ok("You have been logged out successfully.");
        }

        [HttpGet]
        [Route("IsLogged")]
        [Authorize]
        public IActionResult IsLogged()
        {
            var cookieValue = Request.Cookies["AT"];
            if(cookieValue != null)
            {
                var handler = new JwtSecurityTokenHandler();
                var jwt = handler.ReadToken(cookieValue) as JwtSecurityToken;

                if (jwt != null)
                {
                    foreach (var token in jwt.Claims)
                    {
                        var tokenClaim = token.Type.Split("/")[token.Type.Split("/").Length - 1];

                        if(tokenClaim == "name")
                        {
                            return Ok(new
                            {
                                data = true,
                                username = token.Value,
                            });
                        }
                    }
                }
            }
            return Ok(true);
        }
    }
}
