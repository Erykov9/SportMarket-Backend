﻿using System.ComponentModel.DataAnnotations;

namespace SportMarket_Backend.Models.DTO
{
    public class LoginRequestDTO
    {
        public string Username { get; set; }

        public string Password { get; set; }

    }
}
