﻿using System.ComponentModel.DataAnnotations;

namespace SportMarket_Backend.Models.DTO
{
    public class LoginRequestDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
