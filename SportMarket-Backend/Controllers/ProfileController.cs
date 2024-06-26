﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportMarket_Backend.Models.DTO;
using SportMarket_Backend.Repositories.Profiles;

namespace SportMarket_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileRepository _profileRepository;
        private readonly IMapper _mapper;

        public ProfileController(IProfileRepository profileRepository, IMapper mapper)
        {
            _profileRepository = profileRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("{username}")]
        [Authorize]
        public async Task<IActionResult?> GetUserByUsername([FromRoute] string username)
        {
            var domainProfile = await _profileRepository.GetUserByUsernameAsync(username);

            if (domainProfile == null)
            {
                return NotFound("Profile was not found.");
            }

            var profileDTO = _mapper.Map<ProfileDTO>(domainProfile);

            return Ok(profileDTO);
        }

    }
}
