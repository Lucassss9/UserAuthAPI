﻿using System.ComponentModel.DataAnnotations.Schema;

namespace UserAuthAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
